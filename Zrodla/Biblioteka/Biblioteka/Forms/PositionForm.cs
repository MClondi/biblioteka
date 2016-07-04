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
        private AddPosition addPosition;
        private EditPosition editPosition;

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
                typeSpinner.Items.Add("Dowolny");
                publisherSpinner.Items.Add("Dowolny");
                genreSpinner.Items.Add("Dowolny");
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
            switch (formAction)
            {
                case FormAction.Add:
                    addPosition();
                    MessageBox.Show("Dodano pozycję", "Informacja");
                    break;
                case FormAction.Edit:
                    editPosition(editedPosition);
                    MessageBox.Show("Edytowano pozycję", "Informacja");
                    break;
                case FormAction.Search:
                    break;
            }

            dbContext.SaveChanges();
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
            searchBook.Show();
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
            editedMagazineNumber.Number = Int32.Parse(txtBoxNumber.Text);
            editedMagazineNumber.Magazine = dbContext.Magazines.Where(m => m.Title == magazineSpinner.Text).FirstOrDefault();
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
                    break;
                case 1:
                    SetGameView();
                    addPosition = AddGame;
                    editPosition = EditGame;
                    break; 
                case 2:
                    SetMagazineView();
                    addPosition = AddMagazineNumber;
                    editPosition = EditMagazineNumber;
                    break;
            }
        }

        private void SetBookView()
        {
            txtBoxName.Enabled = false;
            txtBoxProducer.Enabled = false;
            txtBoxEdition.Enabled = false;
            magazineSpinner.Enabled = false;
            txtBoxNumber.Enabled = false;
        }

        private void SetGameView()
        {
            txbBoxIsbn.Enabled = false;
            datePicker.Enabled = false;
            publisherSpinner.Enabled = false;
            txtBoxNumber.Enabled = false;
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
            txtBoxNumber.Enabled = true;
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
            txtBoxNumber.Text = "1";

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

            txtBoxNumber.Text = magazineNumber.Number.ToString();
            magazineSpinner.Text = magazineNumber.Magazine.Title;
        }
    }
}
