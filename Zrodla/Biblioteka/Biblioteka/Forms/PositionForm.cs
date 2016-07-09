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
    public partial class PositionForm : Form
    {
        private delegate void AddPosition();
        private delegate void EditPosition(Position positionToEdit);
        private delegate void SearchPosition(out List<Position> positions);

        private AddPosition addPosition;
        private EditPosition editPosition;
        private SearchPosition searchPosition;

        private Book selectedBook = null;
        private Dictionary<String, Book> searchBookTagSet = new Dictionary<string, Book>();
        private Dictionary<String, Book> selectedBookTagSet = new Dictionary<string, Book>();
        FormAction formAction;
        LibraryDBContainer dbContext;
        public event EventHandler<List<Position>> positionSaved;
        Position editedPosition = null;

        public PositionForm(LibraryDBContainer dbContext, Position editedPosition)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.editedPosition = editedPosition;
            this.formAction = FormAction.Edit;
            InitSpinner();
            InitControls(editedPosition);
            SetControls(typeSpinner.SelectedIndex);
         //   genreSpinner.Text = editedBook.Genre.Name;
        }

     public PositionForm(LibraryDBContainer dbContext, bool searchPosition = false)
        {
            InitializeComponent();
            if (searchPosition)
            {
                buttonSave.Text = "Wyszukaj";
                publisherSpinner.Items.Add("Dowolny");
                genreSpinner.Items.Add("Dowolny");
                datePicker.ShowCheckBox = true;
                datePicker.Checked = false;  
            }
            this.dbContext = dbContext;
            this.formAction = searchPosition ? FormAction.Search : FormAction.Add;
            InitSpinner();
        }

        private void InitSpinner()
        {
            foreach (Publisher publisher in dbContext.Publishers)
            {
                publisherSpinner.Items.Add(publisher.Name);
            }
            if (publisherSpinner.Items.Count > 0)
                publisherSpinner.SelectedIndex = 0;

            foreach (Genre genre in dbContext.Genres)
            {
                genreSpinner.Items.Add(genre.Name);
            }
            if (genreSpinner.Items.Count > 0)
                genreSpinner.SelectedIndex = 0;

            foreach (Magazine magazine in dbContext.Magazines)
            {
                magazineSpinner.Items.Add(magazine.Title);
            }
            if (magazineSpinner.Items.Count > 0)
                magazineSpinner.SelectedIndex = 0;

            typeSpinner.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Position> positions = null;

            switch (formAction)
            {
                case FormAction.Add:
                    if (validate())
                    { 
                        addPosition();
                        MessageBox.Show("Dodano pozycję", "Informacja");
                    }
                    break;
                case FormAction.Edit:
                    if (validate())
                    {
                        editPosition(editedPosition);
                        MessageBox.Show("Edytowano pozycję", "Informacja");
                    }
                    break;
                case FormAction.Search:
                    searchPosition(out positions);
                    break;
            }

            dbContext.SaveChanges();
            if(positionSaved != null)
                positionSaved(this, positions);
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookForm searchBook = new BookForm(dbContext, true);
            searchBook.bookSaved += new EventHandler<List<Book>>(bookSaved);
            searchBook.ShowDialog();
        }

        void bookSaved(object sender, List<Book> books)
        {
            RefreshSearchBookListView(books);
        }

        private void RefreshSearchBookListView(List<Book> books = null)
        {
            GuiUtils.RefreshBookListView(dbContext, ref lstViewSearchBook, ref searchBookTagSet, books);
        }

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            Book bookToAdd = (Book)GuiUtils.GetSelected<Book>(lstViewSearchBook, searchBookTagSet);
            if (selectedBook != null)
            {
                MessageBox.Show("Wybrano już książkę!", "Błąd");
            }
            else
            {
                selectedBook = bookToAdd;
                RefreshSelectedBookListView();
            } 
        }

        private void RefreshSelectedBookListView()
        {
            List<Book> books = new List<Book>();
            if(selectedBook != null)
                books.Add(selectedBook);
            GuiUtils.RefreshBookListView(dbContext, ref lstViewSelectedBook, ref selectedBookTagSet, books);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedBook = null;
            RefreshSelectedBookListView();
        }

        private void AddBook()
        {
            BookEdition book = new BookEdition();
            EditBook(book);
            dbContext.Positions.Add(book);
        }

        private void EditBook(Position position)
        {
            BookEdition editedBook = (BookEdition) position; 

            editedBook.ISBN = txbBoxIsbn.Text;
            editedBook.PublicationDate = datePicker.Value;
            editedBook.Number = 1;
            editedBook.Publisher = dbContext.Publishers.Where(p => p.Name == publisherSpinner.Text).FirstOrDefault();
            editedBook.Book = selectedBook;
        }

        private void SearchBook(out List<Position> positions)
        {
            List<BookEdition> searchedPositions = new List<BookEdition>();

            searchedPositions = dbContext.Positions.Include("Book").Include("Publisher").OfType<BookEdition>()
                .Where(b => txbBoxIsbn.Text.Trim() == String.Empty ? true : b.ISBN == txbBoxIsbn.Text)
                .Where(b => !datePicker.Checked ? true : b.PublicationDate.Value.Year == datePicker.Value.Year &&
                                                             b.PublicationDate.Value.Month == datePicker.Value.Month &&
                                                             b.PublicationDate.Value.Day == datePicker.Value.Day)
                .Where(b => publisherSpinner.SelectedIndex == 0 ? true : b.Publisher.Name == publisherSpinner.Text)
                .Where(b => selectedBook == null ? true : b.Book.Equals(selectedBook))
                .ToList();

            positions = new List<Position>();
            positions.AddRange(searchedPositions);
        }

        private void AddGame()
        {
            Game game = new Game();
            EditGame(game);
            dbContext.Positions.Add(game);
        }

        private void EditGame(Position position)
        {
            Game editedGame = (Game)position;

            editedGame.Name = txtBoxName.Text;
            editedGame.Producer = txtBoxProducer.Text;
            editedGame.Edition = txtBoxEdition.Text;
            editedGame.Genre = dbContext.Genres.Where(g => g.Name == genreSpinner.Text).FirstOrDefault();
        }

        private void SearchGame(out List<Position> positions)
        {
            List<Game> searchedPositions = new List<Game>();

            searchedPositions = dbContext.Positions.Include("Genre").OfType<Game>()
                .Where(g => txtBoxName.Text.Trim() == String.Empty ? true : g.Name == txtBoxName.Text)
                .Where(g => txtBoxProducer.Text.Trim() == String.Empty ? true : g.Producer == txtBoxProducer.Text)
                .Where(g => txtBoxEdition.Text.Trim() == String.Empty ? true : g.Edition == txtBoxEdition.Text)
                .Where(b => genreSpinner.SelectedIndex == 0 ? true : b.Genre.Name == genreSpinner.Text)
                .ToList();

            positions = new List<Position>();
            positions.AddRange(searchedPositions);            
        }

        private void AddMagazineNumber()
        {
            MagazineNumber magazineNumber = new MagazineNumber();
            EditMagazineNumber(magazineNumber);
            dbContext.Positions.Add(magazineNumber);
        }

        private void EditMagazineNumber(Position position)
        {
            MagazineNumber editedMagazineNumber = (MagazineNumber)position;
            editedMagazineNumber.PublicationDate = datePicker.Value;
            editedMagazineNumber.Magazine = dbContext.Magazines.Where(m => m.Title == magazineSpinner.Text).FirstOrDefault();
            editedMagazineNumber.Number = 1;
        }

        private void SearchMagazineNumber(out List<Position> positions)
        {
            List<MagazineNumber> searchedPositions = new List<MagazineNumber>();

            searchedPositions = dbContext.Positions.Include("Magazine").OfType<MagazineNumber>()
                .Where(m => !datePicker.Checked ? true : m.PublicationDate.Value.Year == datePicker.Value.Year &&
                                                             m.PublicationDate.Value.Month == datePicker.Value.Month &&
                                                             m.PublicationDate.Value.Day == datePicker.Value.Day)
                .Where(m => magazineSpinner.SelectedIndex == 0 ? true : m.Magazine.Title == magazineSpinner.Text)
                .ToList();

            positions = new List<Position>();
            positions.AddRange(searchedPositions);
        }

        private void SetControls(int index)
        {
            EnableAllControls();
            switch(index)
            {
                case 0:
                    SetBookView();
                    addPosition = AddBook;
                    editPosition = EditBook;
                    searchPosition = SearchBook;
                    break;
                case 1:
                    SetGameView();
                    addPosition = AddGame;
                    editPosition = EditGame;
                    searchPosition = SearchGame;
                    break; 
                case 2:
                    SetMagazineView();
                    addPosition = AddMagazineNumber;
                    editPosition = EditMagazineNumber;
                    searchPosition = SearchMagazineNumber;
                    break;
            }
        }

        private void SetBookView()
        {
            txtBoxName.Enabled = false;
            txtBoxProducer.Enabled = false;
            txtBoxEdition.Enabled = false;
            magazineSpinner.Enabled = false;
        }

        private void SetGameView()
        {
            txbBoxIsbn.Enabled = false;
            datePicker.Enabled = false;
            publisherSpinner.Enabled = false;
            magazineSpinner.Enabled = false;
            lstViewSearchBook.Enabled = false;
            lstViewSelectedBook.Enabled = false;
            btnSelectBook.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private void SetMagazineView()
        {
            txtBoxName.Enabled = false;
            txtBoxProducer.Enabled = false;
            txtBoxEdition.Enabled = false;
            txbBoxIsbn.Enabled = false;            
            publisherSpinner.Enabled = false;
            genreSpinner.Enabled = false;
            lstViewSearchBook.Enabled = false;
            lstViewSelectedBook.Enabled = false;
            btnSelectBook.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private void EnableAllControls()
        {
            txtBoxName.Enabled = true;
            txtBoxProducer.Enabled = true;
            txtBoxEdition.Enabled = true;
            txbBoxIsbn.Enabled = true;
            datePicker.Enabled = true;
            publisherSpinner.Enabled = true;
            magazineSpinner.Enabled = true;
            lstViewSearchBook.Enabled = true;
            lstViewSelectedBook.Enabled = true;
            btnSelectBook.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void typeSpinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControls(typeSpinner.SelectedIndex);
        }

        private void InitControls(Position position)
        {
            if(position is BookEdition)
            {
                typeSpinner.SelectedIndex = 0;
                InitBookControls(position);
            }
            else if (position is Game)
            {
                typeSpinner.SelectedIndex = 1;
                InitGameControls(position);
            }
            else if (position is MagazineNumber)
            {
                typeSpinner.SelectedIndex = 2;
                InitMagazineNumberControls(position);
            }

            typeSpinner.Enabled = false;
        }

        private void InitBookControls(Position position)
        {
            BookEdition book = (BookEdition)position;

            txbBoxIsbn.Text = book.ISBN;
            datePicker.Value = (DateTime) book.PublicationDate;
            selectedBook = book.Book;
            RefreshSelectedBookListView();

        }

        private void InitGameControls(Position position)
        {
            Game game = (Game)position;

            txtBoxName.Text = game.Name;
            txtBoxProducer.Text = game.Producer;
            txtBoxEdition.Text = game.Edition;
            genreSpinner.Text = game.Genre.Name;
        }

        private void InitMagazineNumberControls(Position position)
        {
            MagazineNumber magazineNumber = (MagazineNumber)position;

            magazineSpinner.Text = magazineNumber.Magazine.Title;
        }

        private bool validate()
        {
            if (txtBoxName.Text.Count() == 0 || txtBoxEdition.Text.Count() == 0 || txtBoxProducer.Text.Count() == 0 || txbBoxIsbn.Text.Count() == 0)
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione");
                return false;
            }
            if (datePicker.Value > DateTime.Today)
            {
                MessageBox.Show("Data publikacji jest błędna");
                return false;
            }
            if (lstViewSelectedBook.Items.Count == 0)
            {
                MessageBox.Show("Wybierz książkę/i");
                return false;
            }
            if (!txbBoxIsbn.Text.All(x => Char.IsDigit(x) || x == '-'))
            {
                MessageBox.Show("Nieprawidłowy ISBN");
                return false;
            }

            return true;
        }
    }
}
