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
        Form parent;
        LibraryDBContainer dbContext;
        Boolean help;
        private Dictionary<String, Author> authorTagSet = new Dictionary<string, Author>();
        private Dictionary<String, Publisher> publisherTagSet = new Dictionary<string, Publisher>();
        private Dictionary<String, Genre> genreTagSet = new Dictionary<string, Genre>();
        private Dictionary<String, Book> bookTagSet = new Dictionary<string, Book>();
        private Dictionary<String, Magazine> magazineTagSet = new Dictionary<string, Magazine>();

        public LibrarianForm(Form parent, LibraryDBContainer dbContext)
        {
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
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
            searchUserForm.Show();
        }

        private void btnReserveResource_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrowResource_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnNoteReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {

        }

       

        private void btnAddPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {

        }



        private void btnEditPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
        {

        }


        private void btnDeletePosition_Click(object sender, EventArgs e)
        {

        }

        void searchUserClicked(object sender, List<User> searchResults)
        {
            lstViewBooksAndUsers.Items.Clear();
            foreach (User usr in searchResults)
            {
                string[] row = { usr.Name, usr.Surname };
                ListViewItem item = new ListViewItem(row);
                lstViewBooksAndUsers.Items.Add(item);
            }
        }
        void searchResourceClicked(object sender, List<Position> results)
        {
            // todo populate the list of resources
        }
        void refresh(object sender, List<Author> users)
        {
            // todo refresh the listview after add/edit/delete action
        }

        private void btnSearchResource_Click_1(object sender, EventArgs e)
        {
            SearchResource sr = new SearchResource(dbContext, searchResourceClicked);
            sr.Show();
        }



        //Authors

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm addAuthor = new AuthorForm(dbContext);
            addAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            addAuthor.Show();
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm editAuthor = new AuthorForm(dbContext, (Author) GuiUtils.GetSelected<Author>(lstViewAuthors, authorTagSet));
            editAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            editAuthor.Show();
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = GuiUtils.GetSelected<Author>(lstViewAuthors, authorTagSet);

            if (selectedAuthor != null)
            {
                dbContext.Authors.Remove(selectedAuthor);
                dbContext.SaveChanges();
                RefreshAuthorListView();
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm searchAuthor = new AuthorForm(dbContext, true);
            searchAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            searchAuthor.Show();
        }

        void authorSaved(object sender, List<Author> authors)
        {
            RefreshAuthorListView(authors);
        }

        private void RefreshAuthorListView(List<Author> authors = null)
        {
            //if (authors == null)
            //{
            //    authors = dbContext.Authors.ToList();
            //}

            //lstViewAuthors.Items.Clear();
            //authorTagSet.Clear();
            //foreach (Author author in authors)
            //{
            //    string[] row = { author.Name, author.Surname };
            //    ListViewItem item = new ListViewItem(row);
            //    item.Tag = author.GetHashCode();
            //    authorTagSet.Add(item.Tag.ToString(), author);
            //    lstViewAuthors.Items.Add(item);

            //}


            GuiUtils.RefreshAuthorListView(dbContext, ref lstViewAuthors, ref authorTagSet, authors);
        }

        //Publishers

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm addPublisher = new PublisherForm(dbContext);
            addPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
            addPublisher.Show();
        }

        private void btnEditPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm editPublisher = new PublisherForm(dbContext, (Publisher)GuiUtils.GetSelected<Publisher>(lstViewPublishers, publisherTagSet));
            editPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
            editPublisher.Show();
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
            searchPublisher.Show();
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
            addGenre.Show();
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            GenreForm editGenre = new GenreForm(dbContext, (Genre)GuiUtils.GetSelected<Genre>(lstViewGenres, genreTagSet));
            editGenre.genreSaved += new EventHandler<List<Genre>>(genreSaved);
            editGenre.Show();
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
            searchGenre.Show();
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
            addBook.Show();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            BookForm editBook = new BookForm(dbContext, (Book)GuiUtils.GetSelected<Book>(lstViewBooks, bookTagSet));
            editBook.bookSaved += new EventHandler<List<Book>>(bookSaved);
            editBook.Show();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            Book selectedBook = GuiUtils.GetSelected<Book>(lstViewBooks, bookTagSet);
            dbContext.Authorships.RemoveRange(selectedBook.Authorship);

            if (selectedBook != null)
            {
                dbContext.Books.Remove(selectedBook);
                dbContext.SaveChanges();
                RefreshBooksListView();
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            BookForm searchBook = new BookForm(dbContext, true);
            searchBook.bookSaved += new EventHandler<List<Book>>(bookSaved);
            searchBook.Show();
        }

        void bookSaved(object sender, List<Book> books)
        {
            RefreshBooksListView(books);
        }

        private void RefreshBooksListView(List<Book> books = null)
        {
            if (books == null)
            {
                books = dbContext.Books.ToList();
            }

            lstViewBooks.Items.Clear();
            bookTagSet.Clear();
            foreach (Book book in books)
            {
                string[] row = { book.Title };
                ListViewItem item = new ListViewItem(row);
                item.Tag = book.GetHashCode();
                bookTagSet.Add(item.Tag.ToString(), book);
                lstViewBooks.Items.Add(item);
            }
        }

        // Magazines

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {
            MagazineForm addMagazine = new MagazineForm(dbContext);
            addMagazine.magazineSaved += new EventHandler<List<Magazine>>(magazineSaved);
            addMagazine.Show();
        }

        private void btnEditMagazine_Click(object sender, EventArgs e)
        {
            MagazineForm editMagazine = new MagazineForm(dbContext, (Magazine)GuiUtils.GetSelected<Magazine>(lstViewMagazines, magazineTagSet));
            editMagazine.magazineSaved += new EventHandler<List<Magazine>>(magazineSaved);
            editMagazine.Show();
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
            searchMagazine.Show();
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

    }
}
