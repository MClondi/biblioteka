using Biblioteka.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.Forms
{
    public partial class LibrarianForm : Form
    {
        private User librarian;
        Form parent;
        LibraryDBContainer dbContext;
        Boolean help;
        private Dictionary<String, Author> authorTagSet = new Dictionary<string, Author>();
        private Dictionary<String, Publisher> publisherTagSet = new Dictionary<string, Publisher>();
        private Dictionary<String, Genre> genreTagSet = new Dictionary<string, Genre>();
        private Dictionary<String, Book> bookTagSet = new Dictionary<string, Book>();
        private Dictionary<String, Magazine> magazineTagSet = new Dictionary<string, Magazine>();
        private Dictionary<String, Position> positionTagSet = new Dictionary<string, Position>();
        private Dictionary<String, Resource> resourceTagSet = new Dictionary<string, Resource>();
        private Dictionary<String, User> userTagSet = new Dictionary<string, User>();
        private Dictionary<String, Borrowing> borrowingTagSet = new Dictionary<string, Borrowing>();
        private Dictionary<String, Reservation> reservationTagSet = new Dictionary<string, Reservation>();
        private Dictionary<String, ReaderApplication> readerApplicationTagSet = new Dictionary<string, ReaderApplication>();

        List<Position> cachedPositions;
        List<Resource> cachedResources;

        public LibrarianForm(Form parent, LibraryDBContainer dbContext, User librarian)
        {
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            this.librarian = librarian;
            InitializeComponent();
        }

        

        private void LibrarianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SearchUser searchUserForm = new SearchUser(dbContext, searchUserClicked);
            searchUserForm.ShowDialog();
        }
        
        void searchUserClicked(object sender, List<User> searchResults)
        {
            userTagSet.Clear();
            lstViewUsers.Items.Clear();
            foreach (User usr in searchResults)
            {
                string[] row = { usr.Name, usr.Surname };
                ListViewItem item = new ListViewItem(row);
                item.Tag = usr.GetHashCode();
                userTagSet.Add(item.Tag.ToString(), usr);
                lstViewUsers.Items.Add(item);
            }
        }

        // Akcje

        private void btnShowBorrowings_Click(object sender, EventArgs e)
        {
            ResourceOrUserForm choiceForm = new ResourceOrUserForm();
            choiceForm.ShowDialog(); 

            if (choiceForm.Choice)
                ShowBorrowingsForUser();
            else
                ShowBorrowingsForResource();            
        }

        private void ShowBorrowingsForUser()
        {
            User temp = GuiUtils.GetSelected<User>(lstViewUsers, userTagSet);
            Reader reader = null;

            if (temp != null)
                reader = temp.Reader;

            if (reader != null)
            {
                ShowBorrowings(reader);
            }
            else
            {
                MessageBox.Show("Nie wybrano czytelnika!", "Błąd");
            }
        }

        private void ShowBorrowingsForResource()
        {
            Resource resource = GuiUtils.GetSelected<Resource>(lstViewResources, resourceTagSet);

            if (resource != null)
            {
                ShowBorrowings(resource);
            }
            else
            {
                MessageBox.Show("Nie wybrano zasobu!", "Błąd");
            }
        }

        private void ShowBorrowings(Reader reader)
        {
            borrowingTagSet.Clear();
            lstViewActions.Items.Clear();
            lstViewActions.Columns.Clear();
            lstViewActions.Columns.Add("Tytuł");
            lstViewActions.Columns.Add("Autor");
            lstViewActions.Columns.Add("Data publikacji");
            lstViewActions.Columns.Add("Data wypożyczenia");
            lstViewActions.Columns.Add("Termin zwrotu");

            List<Borrowing> borrowings = dbContext.Borrowings
                                            .Include("Reader")
                                            .Include("User")
                                            .Include("Resource")
                                            .Where(b => b.ReaderId == reader.Id)
                                            .Where(b => b.ReturnDate == null)
                                            .ToList();

            foreach(Borrowing borrowing in borrowings)
            {
                string[] row = null;
                switch(borrowing.Resource.Category)
                {
                    case "K":
                        row = GenerateBookRow(borrowing);
                        break;
                    case "G":
                        row = GenerateGameRow(borrowing);
                        break;
                    case "M":
                        row = GenerateMagazineNumberRow(borrowing);
                        break;
                }
                ListViewItem item = new ListViewItem(row);
                item.Tag = borrowing.GetHashCode();
                borrowingTagSet.Add(item.Tag.ToString(), borrowing);
                lstViewActions.Items.Add(item);
            }
        }

        private void ShowBorrowings(Resource resource)
        {
            borrowingTagSet.Clear();
            lstViewActions.Items.Clear();
            lstViewActions.Columns.Clear();
            lstViewActions.Columns.Add("Użytkownik");
            lstViewActions.Columns.Add("Data wypożyczenia");
            lstViewActions.Columns.Add("Termin zwrotu");

            List<Borrowing> borrowings = dbContext.Borrowings
                                            .Include("Reader")
                                            .Include("User")
                                            .Include("Resource")
                                            .Where(b => b.ResourceId == resource.Id)
                                            .Where(b => b.ReturnDate == null)
                                            .ToList();

            foreach (Borrowing borrowing in borrowings)
            {
                string[] row = { borrowing.Reader.User.Name + " " + borrowing.Reader.User.Surname, borrowing.BorrowingDate.ToString(), borrowing.ReturnTerm.ToString() };
                ListViewItem item = new ListViewItem(row);
                item.Tag = borrowing.GetHashCode();
                borrowingTagSet.Add(item.Tag.ToString(), borrowing);
                lstViewActions.Items.Add(item);
            }
        }

        private string[] GenerateBookRow(Borrowing borrowing)
        {
            BookEdition book = (BookEdition) borrowing.Resource.Position;
            string authors = "";
            foreach(Authorship authorship in book.Book.Authorship)
            {
                authors += authorship.Author.Name + " " + authorship.Author.Surname + "; ";
            }

            string[] row = { book.Book.Title, authors, "", borrowing.BorrowingDate.ToString(), borrowing.ReturnTerm.ToString() };
            
            return row;
        }

        private string[] GenerateBookRow(Reservation reservation)
        {
            BookEdition book = (BookEdition)reservation.Resource.Position;
            string authors = "";
            foreach (Authorship authorship in book.Book.Authorship)
            {
                authors += authorship.Author.Name + " " + authorship.Author.Surname + "; ";
            }

            string[] row = { book.Book.Title, authors, "", reservation.RealizationDate.ToString() };

            return row;
        }

        private string[] GenerateGameRow(Borrowing borrowing)
        {
            Game game = (Game)borrowing.Resource.Position;            
            string[] row = { game.Name, "", "", borrowing.BorrowingDate.ToString(), borrowing.ReturnTerm.ToString() };

            return row;
        }

        private string[] GenerateGameRow(Reservation reservation)
        {
            Game game = (Game)reservation.Resource.Position;
            string[] row = { game.Name, "", "", reservation.RealizationDate.ToString() };

            return row;
        }

        private string[] GenerateMagazineNumberRow(Borrowing borrowing)
        {
            MagazineNumber magazineNumber = (MagazineNumber)borrowing.Resource.Position;
            string[] row = { magazineNumber.Magazine.Title, "", magazineNumber.PublicationDate.ToString(), borrowing.BorrowingDate.ToString(), borrowing.ReturnTerm.ToString() };

            return row;
        }

        private string[] GenerateMagazineNumberRow(Reservation reservation)
        {
            MagazineNumber magazineNumber = (MagazineNumber)reservation.Resource.Position;
            string[] row = { magazineNumber.Magazine.Title, "", magazineNumber.PublicationDate.ToString(), reservation.RealizationDate.ToString() };

            return row;
        }

        private void btnBorrowResource_Click(object sender, EventArgs e)
        {
            User temp = GuiUtils.GetSelected<User>(lstViewUsers, userTagSet);
            Reader reader = null;

            if (temp != null)
                reader = temp.Reader;

            Resource resource = GuiUtils.GetSelected<Resource>(lstViewResources, resourceTagSet);

            if (reader != null && resource != null)
            {
                BorrowingForm addBorrowing = new BorrowingForm(dbContext, resource, reader, librarian);
                addBorrowing.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano czytelnika i/lub zasobu!", "Błąd");
            }
        }

        private void btnNoteReturn_Click(object sender, EventArgs e)
        {
            Borrowing borrowing = GuiUtils.GetSelected<Borrowing>(lstViewActions, borrowingTagSet);

            if(borrowing != null)
            {
                borrowing.ReturnDate = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Nie wybrano wypożyczenia!", "Błąd");
                return;
            }

            dbContext.SaveChanges();
            MessageBox.Show("Zaksięgowano wypożyczenie.", "Informacja");
        }


        private void btnShowReservations_Click(object sender, EventArgs e)
        {
            ResourceOrUserForm choiceForm = new ResourceOrUserForm();
            choiceForm.ShowDialog();

            if (choiceForm.Choice)
                ShowReservationsForUser();
            else
                ShowReservationsForResource();   
        }

        private void ShowReservationsForUser()
        {
            User temp = GuiUtils.GetSelected<User>(lstViewUsers, userTagSet);
            Reader reader = null;

            if (temp != null)
                reader = temp.Reader;

            if (reader != null)
            {
                ShowReservations(reader);
            }
            else
            {
                MessageBox.Show("Nie wybrano czytelnika!", "Błąd");
            }
        }

        private void ShowReservationsForResource()
        {
            Resource resource = GuiUtils.GetSelected<Resource>(lstViewResources, resourceTagSet);

            if (resource != null)
            {
                ShowReservations(resource);
            }
            else
            {
                MessageBox.Show("Nie wybrano zasobu!", "Błąd");
            }
        }

        private void ShowReservations(Reader reader)
        {
            reservationTagSet.Clear();
            lstViewActions.Items.Clear();
            lstViewActions.Columns.Clear();
            lstViewActions.Columns.Add("Tytuł");
            lstViewActions.Columns.Add("Autor");
            lstViewActions.Columns.Add("Data publikacji");
            lstViewActions.Columns.Add("Data realizacji");

            List<Reservation> reservations = dbContext.Reservations
                                            .Include("Reader")
                                            .Include("Resource")
                                            .Where(r => r.ReaderId == reader.Id)
                                            .Where(r => r.RealizationDate > DateTime.Now)
                                            .ToList();

            foreach (Reservation reservation in reservations)
            {
                string[] row = null;
                switch (reservation.Resource.Category)
                {
                    case "K":
                        row = GenerateBookRow(reservation);
                        break;
                    case "G":
                        row = GenerateGameRow(reservation);
                        break;
                    case "M":
                        row = GenerateMagazineNumberRow(reservation);
                        break;
                }
                ListViewItem item = new ListViewItem(row);
                item.Tag = reservation.GetHashCode();
                reservationTagSet.Add(item.Tag.ToString(), reservation);
                lstViewActions.Items.Add(item);
            }
        }

        private void ShowReservations(Resource resource)
        {
            reservationTagSet.Clear();
            lstViewActions.Items.Clear();
            lstViewActions.Columns.Clear();
            lstViewActions.Columns.Add("Użytkownik");
            lstViewActions.Columns.Add("Data realizacji");

            List<Reservation> reservations = dbContext.Reservations
                                            .Include("Reader")
                                            .Include("Resource")
                                            .Where(r => r.ResourceId == resource.Id)
                                            .Where(r => r.RealizationDate > DateTime.Now)
                                            .ToList();

            foreach (Reservation reservation in reservations)
            {
                string[] row = { reservation.Reader.User.Name + " " + reservation.Reader.User.Surname, reservation.RealizationDate.ToString() };
                ListViewItem item = new ListViewItem(row);
                item.Tag = reservation.GetHashCode();
                reservationTagSet.Add(item.Tag.ToString(), reservation);
                lstViewActions.Items.Add(item);
            }
        }

        private void btnReserveResource_Click(object sender, EventArgs e)
        {
            User temp = GuiUtils.GetSelected<User>(lstViewUsers, userTagSet);
            Reader reader = null;

            if (temp != null)
                reader = temp.Reader;

            Resource resource = GuiUtils.GetSelected<Resource>(lstViewResources, resourceTagSet);

            if (reader != null && resource != null)
            {
                ReservationForm addReservation = new ReservationForm(dbContext, resource, reader, librarian);
                addReservation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano czytelnika i/lub zasobu!", "Błąd");
            }
        }       

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = GuiUtils.GetSelected<Reservation>(lstViewActions, reservationTagSet);

            if (reservation != null)
            {
                dbContext.Reservations.Remove(reservation);
            }
            else
            {
                MessageBox.Show("Nie wybrano rezerwacji!", "Błąd");
                return;
            }

            dbContext.SaveChanges();
            MessageBox.Show("Usunięto rezerwację.", "Informacja");
        }

       

        
        void refresh(object sender, List<Author> users)
        {
            // todo refresh the listview after add/edit/delete action
        }




        //Authors

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm addAuthor = new AuthorForm(dbContext);
            addAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            addAuthor.ShowDialog();
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            Author author = (Author) GuiUtils.GetSelected<Author>(lstViewAuthors, authorTagSet);

            if(author != null) 
            {
                AuthorForm editAuthor = new AuthorForm(dbContext, author);
                editAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
                editAuthor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano autora!", "Błąd");
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = GuiUtils.GetSelected<Author>(lstViewAuthors, authorTagSet);

            if (selectedAuthor != null)
            {
                List<Authorship> authorships = dbContext.Authorships
                                                .Where(a => a.AuthorId == selectedAuthor.Id)
                                                .ToList();

                if (authorships == null)
                {
                    dbContext.Authors.Remove(selectedAuthor);
                    dbContext.SaveChanges();
                    RefreshAuthorListView();
                }
                else
                {
                    MessageBox.Show("Istnieją dzieła tego autora, nie możesz go usunąć!", "Błąd");
                }
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm searchAuthor = new AuthorForm(dbContext, true);
            searchAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            searchAuthor.ShowDialog();
        }

        void authorSaved(object sender, List<Author> authors)
        {
            RefreshAuthorListView(authors);
        }

        private void RefreshAuthorListView(List<Author> authors = null)
        {
            GuiUtils.RefreshAuthorListView(dbContext, ref lstViewAuthors, ref authorTagSet, authors);
        }

        //Publishers

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm addPublisher = new PublisherForm(dbContext);
            addPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
            addPublisher.ShowDialog();
        }

        private void btnEditPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = (Publisher)GuiUtils.GetSelected<Publisher>(lstViewPublishers, publisherTagSet);

            if (publisher != null)
            {
                PublisherForm editPublisher = new PublisherForm(dbContext, publisher);
                editPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
                editPublisher.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano wydawcy!", "Błąd");
            }
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            Publisher selectedPublisher = GuiUtils.GetSelected<Publisher>(lstViewPublishers, publisherTagSet);

            if (selectedPublisher != null)
            {
                var books = dbContext.Books.Where(b => b.GenreId == selectedPublisher.Id).FirstOrDefault();
                var magazines = dbContext.Magazines.Where(m => m.GenreId == selectedPublisher.Id).FirstOrDefault();

                if (books == null && magazines == null)
                {
                    dbContext.Publishers.Remove(selectedPublisher);
                    dbContext.SaveChanges();
                    RefreshPublisherListView();
                }
                else
                {
                    MessageBox.Show("Istnieją książki lub magazyny tego wydawcy, nie możesz go usunąć!", "Błąd");
                }
            }
        }

        private void btnSearchPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm searchPublisher = new PublisherForm(dbContext, true);
            searchPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
            searchPublisher.ShowDialog();
        }

        void publisherSaved(object sender, List<Publisher> publishers)
        {
            RefreshPublisherListView(publishers);
        }

        private void RefreshPublisherListView(List<Publisher> publishers = null)
        {
            if (publishers == null)
            {
                publishers = dbContext.Publishers.ToList();
            }

            lstViewPublishers.Items.Clear();
            publisherTagSet.Clear();
            foreach (Publisher publisher in publishers)
            {
                string[] row = { publisher.Name };
                ListViewItem item = new ListViewItem(row);
                item.Tag = publisher.GetHashCode();
                publisherTagSet.Add(item.Tag.ToString(), publisher);
                lstViewPublishers.Items.Add(item);
            }
        }

        //Genres

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            GenreForm addGenre = new GenreForm(dbContext);
            addGenre.genreSaved += new EventHandler<List<Genre>>(genreSaved);
            addGenre.ShowDialog();
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            Genre genre = (Genre)GuiUtils.GetSelected<Genre>(lstViewGenres, genreTagSet);

            if(genre != null)
            {
                GenreForm editGenre = new GenreForm(dbContext, genre);
                editGenre.genreSaved += new EventHandler<List<Genre>>(genreSaved);
                editGenre.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano rodzaju!", "Błąd");
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            Genre selectedGenre = GuiUtils.GetSelected<Genre>(lstViewGenres, genreTagSet);

            if (selectedGenre != null)
            {
                var books = dbContext.Books.Where(b => b.GenreId == selectedGenre.Id).FirstOrDefault();
                var magazines = dbContext.Magazines.Where(m => m.GenreId == selectedGenre.Id).FirstOrDefault();
                if (books == null && magazines == null)
                {
                    dbContext.Genres.Remove(selectedGenre);
                    dbContext.SaveChanges();
                    RefreshGenresListView();
                }
                else
                {
                    MessageBox.Show("Istnieją książki lub magazyny tego rodzaju, nie możesz go usunąć!", "Błąd");
                }
            }
        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            GenreForm searchGenre = new GenreForm(dbContext, true);
            searchGenre.genreSaved += new EventHandler<List<Genre>>(genreSaved);
            searchGenre.ShowDialog();
        }

        void genreSaved(object sender, List<Genre> genres)
        {
            RefreshGenresListView(genres);
        }

        private void RefreshGenresListView(List<Genre> genres = null)
        {
            if (genres == null)
            {
                genres = dbContext.Genres.ToList();
            }

            lstViewGenres.Items.Clear();
            genreTagSet.Clear();
            foreach (Genre genre in genres)
            {
                string[] row = { genre.Name };
                ListViewItem item = new ListViewItem(row);
                item.Tag = genre.GetHashCode();
                genreTagSet.Add(item.Tag.ToString(), genre);
                lstViewGenres.Items.Add(item);
            }
        }


        // Books
 
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookForm addBook = new BookForm(dbContext);
            addBook.bookSaved += new EventHandler<List<Book>>(bookSaved);
            addBook.ShowDialog();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            Book book = (Book)GuiUtils.GetSelected<Book>(lstViewBooks, bookTagSet);

            if(book != null)
            {
                BookForm editBook = new BookForm(dbContext, book);
                editBook.bookSaved += new EventHandler<List<Book>>(bookSaved);
                editBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano książki!", "Błąd");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            Book selectedBook = GuiUtils.GetSelected<Book>(lstViewBooks, bookTagSet);
            

            if (selectedBook != null)
            {
                List<BookEdition> positions = dbContext.Positions.OfType<BookEdition>()
                                            .Where(p => p.BookId == selectedBook.Id)
                                            .ToList();

                if (positions == null)
                {
                    dbContext.Authorships.RemoveRange(selectedBook.Authorship);
                    dbContext.Books.Remove(selectedBook);
                    dbContext.SaveChanges();
                    RefreshBooksListView();
                }
                else
                {
                    MessageBox.Show("Istnieją pozycje powiązane z tą książką, nie możesz jej usunąć!", "Błąd");
                }
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            BookForm searchBook = new BookForm(dbContext, true);
            searchBook.bookSaved += new EventHandler<List<Book>>(bookSaved);
            searchBook.ShowDialog();
        }

        void bookSaved(object sender, List<Book> books)
        {
            RefreshBooksListView(books);
        }

        private void RefreshBooksListView(List<Book> books = null)
        {
            GuiUtils.RefreshBookListView(dbContext, ref lstViewBooks, ref bookTagSet, books);
        }

        // Magazines

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {
            MagazineForm addMagazine = new MagazineForm(dbContext);
            addMagazine.magazineSaved += new EventHandler<List<Magazine>>(magazineSaved);
            addMagazine.ShowDialog();
        }

        private void btnEditMagazine_Click(object sender, EventArgs e)
        {
            Magazine magazine =  (Magazine)GuiUtils.GetSelected<Magazine>(lstViewMagazines, magazineTagSet);

            if(magazine != null)
            {
                MagazineForm editMagazine = new MagazineForm(dbContext, magazine);
                editMagazine.magazineSaved += new EventHandler<List<Magazine>>(magazineSaved);
                editMagazine.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano magazynu!", "Błąd");
            }
        }

        private void btnDeleteMagazine_Click(object sender, EventArgs e)
        {
            Magazine selectedMagazine = GuiUtils.GetSelected<Magazine>(lstViewMagazines, magazineTagSet);

            if (selectedMagazine != null)
            {
                var magazineNumbers = dbContext.Positions.OfType<MagazineNumber>().Where(mn => mn.MagazineId == selectedMagazine.Id).FirstOrDefault();

                if (magazineNumbers == null)
                {
                    dbContext.Magazines.Remove(selectedMagazine);
                    dbContext.SaveChanges();
                    RefreshMagazinesListView();
                }
                else
                {
                    MessageBox.Show("Istnieją numery tego magazynu, nie możesz go usunąć!", "Błąd");
                }
            }
        }

        private void btnSearchMagazine_Click(object sender, EventArgs e)
        {
            MagazineForm searchMagazine = new MagazineForm(dbContext, true);
            searchMagazine.magazineSaved += new EventHandler<List<Magazine>>(magazineSaved);
            searchMagazine.ShowDialog();
        }

        void magazineSaved(object sender, List<Magazine> magazines)
        {
            RefreshMagazinesListView(magazines);
        }

        private void RefreshMagazinesListView(List<Magazine> magazines = null)
        {
            if (magazines == null)
            {
                magazines = dbContext.Magazines.ToList();
            }

            lstViewMagazines.Items.Clear();
            magazineTagSet.Clear();
            foreach (Magazine magazine in magazines)
            {
                string[] row = { magazine.Title };
                ListViewItem item = new ListViewItem(row);
                item.Tag = magazine.GetHashCode();
                magazineTagSet.Add(item.Tag.ToString(), magazine);
                lstViewMagazines.Items.Add(item);
            }
        }

        // Positions

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            PositionForm addPosition = new PositionForm(dbContext);
            addPosition.ShowDialog();
        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            Position position = (Position)GuiUtils.GetSelected<Position>(lstViewPositions, positionTagSet);

            if(position != null)
            {
                PositionForm editPosition = new PositionForm(dbContext, position);
                editPosition.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano pozycji!", "Błąd");
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            Position selectedPosition = GuiUtils.GetSelected<Position>(lstViewPositions, positionTagSet);

            if (selectedPosition != null)
            {
                List<Resource> resources = dbContext.Resources
                                            .Where(r => r.PositionId == selectedPosition.PositionId)
                                            .ToList();
                if(resources == null)
                {
                    dbContext.Positions.Remove(selectedPosition);
                    cachedPositions.Remove(selectedPosition);
                    dbContext.SaveChanges();                     
                }
                else
                {
                    MessageBox.Show("Istnieją zasoby powiązane z tą pozycją, nie możesz jej usunąć!", "Błąd");
                }
                
            }
            positionSaved(sender, cachedPositions);
        }

        private void btnSearchPosition_Click(object sender, EventArgs e)
        {       
            PositionForm searchPosition = new PositionForm(dbContext, true);
            searchPosition.positionSaved += new EventHandler<List<Position>>(positionSaved);
            searchPosition.ShowDialog();
        }

        void positionSaved(object sender, List<Position> positions)
        {
            lstViewPositions.Items.Clear();
            cachedPositions = positions;
            if(positions != null)
            {
                if (positions.Count > 0)
                {
                    if (positions.ElementAt(0) is BookEdition)
                        RefreshBookEditions(positions);
                    else if (positions.ElementAt(0) is Game)
                        RefreshGames(positions);
                    else if (positions.ElementAt(0) is MagazineNumber)
                        RefreshMagazineNumbers(positions);
                }
            }
        }
        
        private void RefreshBookEditions(List<Position> positions)
        {
            lstViewPositions.Columns.Clear();
            lstViewPositions.Columns.Add("Tytuł");
            lstViewPositions.Columns.Add("ISBN");
            positionTagSet.Clear();
            foreach (Position position in positions)
            {
                BookEdition be = (BookEdition)position;

                string[] row = { be.Book.Title, be.ISBN };
                ListViewItem item = new ListViewItem(row);
                item.Tag = position.GetHashCode();
                positionTagSet.Add(item.Tag.ToString(), position);
                lstViewPositions.Items.Add(item);
            }
        }

        private void RefreshGames(List<Position> positions)
        {
            lstViewPositions.Columns.Clear();
            lstViewPositions.Columns.Add("Nazwa");
            positionTagSet.Clear();
            foreach (Position position in positions)
            {
                Game g = (Game)position;

                string[] row = { g.Name };
                ListViewItem item = new ListViewItem(row);
                item.Tag = position.GetHashCode();
                positionTagSet.Add(item.Tag.ToString(), position);
                lstViewPositions.Items.Add(item);
            }
        }

        private void RefreshMagazineNumbers(List<Position> positions)
        {
            lstViewPositions.Columns.Clear();
            lstViewPositions.Columns.Add("Magazyn");
            lstViewPositions.Columns.Add("Data publikacji");
            positionTagSet.Clear();
            foreach (Position position in positions)
            {
                MagazineNumber mn = (MagazineNumber)position;

                string[] row = { mn.Magazine.Title, mn.PublicationDate.ToString() };
                ListViewItem item = new ListViewItem(row);
                item.Tag = position.GetHashCode();
                positionTagSet.Add(item.Tag.ToString(), position);
                lstViewPositions.Items.Add(item);
            }
        }

        // Resources


        private void btnAddResource_Click(object sender, EventArgs e)
        {
            ResourceForm addResource = new ResourceForm(dbContext, (Position)GuiUtils.GetSelected<Position>(lstViewPositions, positionTagSet));
            if(!addResource.IsDisposed)
                addResource.ShowDialog();
        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {
            Resource resource = (Resource)GuiUtils.GetSelected<Resource>(lstViewResources, resourceTagSet);

            if(resource != null)
            {
                ResourceForm editResource = new ResourceForm(dbContext, resource);
                editResource.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano autora!", "Błąd");
            }
        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
        {
            Resource selectedResource = GuiUtils.GetSelected<Resource>(lstViewResources, resourceTagSet);

            if (selectedResource != null)
            {
                List<Borrowing> borrowings = dbContext.Borrowings
                                                .Where(b => b.ResourceId == selectedResource.Id)
                                                .ToList();
                List<Reservation> reservations = dbContext.Reservations
                                                    .Where(r => r.ResourceId == selectedResource.Id)
                                                    .ToList();

                if (borrowings == null && reservations == null)
                {
                    dbContext.Resources.Remove(selectedResource);
                    cachedResources.Remove(selectedResource);
                    dbContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Dany zasób jest wypożyczony lub zarezerwowany, nie możesz go usunąć!", "Błąd");
                }
            }

            searchResourceClicked(sender, cachedResources);
        }

        private void btnSearchResource_Click_1(object sender, EventArgs e)
        {
            SearchResource sr = new SearchResource(dbContext, searchResourceClicked);
            sr.ShowDialog();
        }

        void searchResourceClicked(object sender, List<Resource> results)
        {
            lstViewResources.Items.Clear();
            cachedResources = results;
            if (results != null)
            {
                if (results.Count > 0)
                {
                    if (results.ElementAt(0).Position is BookEdition)
                        RefreshBookResources(results);
                    else if (results.ElementAt(0).Position is Game)
                        RefreshGameResources(results);
                    else if (results.ElementAt(0).Position is MagazineNumber)
                        RefreshMagazineNumberResources(results);
                }
            }            
        }

        private void RefreshBookResources(List<Resource> resources)
        {
            lstViewResources.Columns.Clear();
            lstViewResources.Columns.Add("Ilość");
            lstViewResources.Columns.Add("Tytuł");
            lstViewResources.Columns.Add("ISBN");
            resourceTagSet.Clear();
            foreach (Resource resource in resources)
            {
                BookEdition be = (BookEdition)resource.Position;

                string[] row = { resource.Amount.ToString(), be.Book.Title, be.ISBN };
                ListViewItem item = new ListViewItem(row);
                item.Tag = resource.GetHashCode();
                resourceTagSet.Add(item.Tag.ToString(), resource);
                lstViewResources.Items.Add(item);
            }
        }

        private void RefreshGameResources(List<Resource> resources)
        {
            lstViewResources.Columns.Clear();
            lstViewResources.Columns.Add("Ilość");
            lstViewResources.Columns.Add("Nazwa");
            resourceTagSet.Clear();
            foreach (Resource resource in resources)
            {
                Game g = (Game)resource.Position;

                string[] row = { resource.Amount.ToString(), g.Name };
                ListViewItem item = new ListViewItem(row);
                item.Tag = resource.GetHashCode();
                resourceTagSet.Add(item.Tag.ToString(), resource);
                lstViewResources.Items.Add(item);
            }
        }

        private void RefreshMagazineNumberResources(List<Resource> resources)
        {
            lstViewResources.Columns.Clear();
            lstViewResources.Columns.Add("Ilość");
            lstViewResources.Columns.Add("Magazyn");
            lstViewResources.Columns.Add("Data publikacji");
            resourceTagSet.Clear();
            foreach (Resource resource in resources)
            {
                MagazineNumber mn = (MagazineNumber)resource.Position;

                string[] row = { resource.Amount.ToString(), mn.Magazine.Title, mn.PublicationDate.ToString() };
                ListViewItem item = new ListViewItem(row);
                item.Tag = resource.GetHashCode();
                resourceTagSet.Add(item.Tag.ToString(), resource);
                lstViewResources.Items.Add(item);
            }
        }

        // Other 

        private void helpButton_Click(object sender, EventArgs e)
        {
            help = !help;
            if (!help)
            {
                helpButton.Text = "Pomoc";
                this.HelpButton = false;
                this.MaximizeBox = true;
                this.MinimizeBox = true;
            }
            else
            {
                helpButton.Text = "Wylacz Pomoc";
                this.HelpButton = true;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(dbContext);
            form.ShowDialog();
        }

        private void btnShowReaderApplications_Click(object sender, EventArgs e)
        {
            RefreshReaderApplications();
        }

        private void RefreshReaderApplications()
        {
            readerApplicationTagSet.Clear();
            lstViewActions.Items.Clear();
            lstViewActions.Columns.Clear();
            lstViewActions.Columns.Add("Login");
            lstViewActions.Columns.Add("Imię");
            lstViewActions.Columns.Add("Nazwisko");
            lstViewActions.Columns.Add("Status");

            List<ReaderApplication> applications = dbContext.ReaderApplications
                                            .Include("Reader")
                                            .Where(a => a.Status.Equals("N"))
                                            .ToList();

            foreach (ReaderApplication application in applications)
            {
                string[] row = {application.Reader.User.Login, application.Reader.User.Name, 
                                   application.Reader.User.Surname, application.Status };

                ListViewItem item = new ListViewItem(row);
                item.Tag = application.GetHashCode();
                readerApplicationTagSet.Add(item.Tag.ToString(), application);
                lstViewActions.Items.Add(item);
            }
        }

        private void btnHandleApplication_Click(object sender, EventArgs e)
        {
            ReaderApplication application = (ReaderApplication)GuiUtils.GetSelected<ReaderApplication>(lstViewActions, readerApplicationTagSet);

            if (application != null)
            {
                HandleReaderApplicationForm handleApplication = new HandleReaderApplicationForm(dbContext, application);
                handleApplication.ShowDialog();
                RefreshReaderApplications();
            }
            else
            {
                MessageBox.Show("Nie wybrano wniosku!", "Błąd");
            }
        }

   

      

        




    }
}
