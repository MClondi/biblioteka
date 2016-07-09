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
    public partial class BookForm : Form
    {
        private List<Author> addedAuthors = new List<Author>();
        private Dictionary<String, Author> searchAuthorTagSet = new Dictionary<string, Author>();
        private Dictionary<String, Author> addedAuthorTagSet = new Dictionary<string, Author>();
        FormAction formAction;
        LibraryDBContainer dbContext;
        public event EventHandler<List<Book>> bookSaved;
        Book editedBook = null;
        Boolean help;

        public BookForm(LibraryDBContainer dbContext, Book editedBook)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.editedBook = editedBook;
            textBoxTitle.Text = editedBook.Title;
            this.formAction = FormAction.Edit;
            InitSpinner();
            genreSpinner.Text = editedBook.Genre.Name;
            addedAuthors = editedBook.Authorship.Select(a => a.Author).ToList();
            RefreshAddedAuthorListView();
        }

        public BookForm(LibraryDBContainer dbContext, bool searchBook = false)
        {
            InitializeComponent();
            if (searchBook)
            {
                buttonSave.Text = "Wyszukaj";
                genreSpinner.Items.Add("Dowolny");
            }
            this.dbContext = dbContext;
            this.formAction = searchBook ? FormAction.Search : FormAction.Add;
            InitSpinner();
        }

        private void InitSpinner()
        {
            foreach(Genre genre in dbContext.Genres)
            {
                genreSpinner.Items.Add(genre.Name);
            }
            if(genreSpinner.Items.Count > 0)
                genreSpinner.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Book> books = null;

            switch (formAction)
            {
                case FormAction.Add:
                    if (!AddBook())
                        return;
                    break;
                case FormAction.Edit:
                    if (!EditBook(editedBook))
                        return;
                    break;
                case FormAction.Search:
                    SearchBook(out books);
                    break;
            }

            dbContext.SaveChanges();
            bookSaved(this, books);
            this.Close();
        }

        private bool AddBook()
        {
          
            Book book = new Book();
            if (!EditBook(book))
            {
                return false;
            }
            dbContext.Books.Add(book);
            return true;
        }

        private bool EditBook(Book editedBook)
        {
            if (textBoxTitle.Text.Count() == 0)
            {
                MessageBox.Show("Nazwa nie może być pusta");
                return false;
            }
            if (lstViewAddedAuthors.Items.Count == 0)
            {
                MessageBox.Show("Lista autorów nie może być pusta");
                return false;
            }
            editedBook.Title = textBoxTitle.Text;
            editedBook.GenreId = dbContext.Genres.Where(g => g.Name == genreSpinner.Text).FirstOrDefault().Id;
            editedBook.Genre = dbContext.Genres.Where(g => g.Name == genreSpinner.Text).FirstOrDefault();
            List<Authorship> authorships = new List<Authorship>();

            dbContext.Authorships.RemoveRange(editedBook.Authorship);

            foreach (Author author in addedAuthors)
            {
                Authorship authorship = new Authorship();
                authorship.Book = editedBook;
                authorship.Author = author;
                dbContext.Authorships.Add(authorship);
            }
            return true;
        }

        private void SearchBook(out List<Book> books)
        {
            List<int> authorships = new List<int>();
            foreach (Author author in addedAuthors)
            {                
                authorships.Add(author.Id);
            }

            books = new List<Book>();
            List<Book> tempBooks = new List<Book>();
            tempBooks = dbContext.Books.Include("Authorship")
                .Where(b => textBoxTitle.Text.Trim() == String.Empty ? true : b.Title == textBoxTitle.Text)
                .Where(b => genreSpinner.SelectedIndex == 0 ? true : b.Genre.Name == genreSpinner.Text) 
                .ToList();                       

            if (authorships.Count() > 0)
            {
                foreach (Book tempBook in tempBooks)
                {
                    if (ComapreLists(tempBook.Authorship.Select(a => a.AuthorId).ToList(), authorships))
                    {
                        books.Add(tempBook);
                    }
                }
            }
            else
            {
                books = tempBooks;
            }
        }

        private static bool ComapreLists(List<int> arr2, List<int> arr3)
        {
            bool _areEqual = false;
            if (arr3.Count() == arr2.Count())
            {
                var filteredSequence = arr3.Where(x => arr2.Contains(x));
                if (filteredSequence.Count() == arr3.Count())
                {
                    _areEqual = true;
                }
            }
            return _areEqual;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AuthorForm searchAuthor = new AuthorForm(dbContext, true);
            searchAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            searchAuthor.ShowDialog();
        }

        void authorSaved(object sender, List<Author> authors)
        {
            RefreshSearchAuthorListView(authors);
        }

        private void RefreshSearchAuthorListView(List<Author> authors = null)
        {
            GuiUtils.RefreshAuthorListView(dbContext, ref lstViewSearchAuthor, ref searchAuthorTagSet, authors);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Author authorToAdd = (Author) GuiUtils.GetSelected<Author>(lstViewSearchAuthor, searchAuthorTagSet);
            if(addedAuthors.Where(a => a.Id == authorToAdd.Id ).FirstOrDefault() != null)
            {
                MessageBox.Show("Już dodałeś tego autora!", "Błąd");
            }
            else
            {
                addedAuthors.Add(authorToAdd);
                RefreshAddedAuthorListView();
            }            
        }

        private void RefreshAddedAuthorListView()
        {
            GuiUtils.RefreshAuthorListView(dbContext, ref lstViewAddedAuthors, ref addedAuthorTagSet, addedAuthors);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author authorToDelete = (Author) GuiUtils.GetSelected<Author>(lstViewAddedAuthors, addedAuthorTagSet);
            addedAuthors.Remove(authorToDelete);
            RefreshAddedAuthorListView();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
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
        }
    }
}
