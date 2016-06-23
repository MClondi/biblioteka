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
    public partial class AuthorForm : Form
    {
        FormAction formAction;
        LibraryDBContainer dbContext;
        public event EventHandler<List<Author>> authorSaved;
        Author editedAuthor = null;
        Boolean help;

        public AuthorForm(LibraryDBContainer dbContext, Author editedAuthor)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.editedAuthor = editedAuthor;
            this.textBoxName.Text = editedAuthor.Name;
            this.textBoxSurname.Text = editedAuthor.Surname;
            this.dateTimePicker1.Value = (DateTime)editedAuthor.BirthDate;
            this.formAction = FormAction.Edit;
        }

        public AuthorForm(LibraryDBContainer dbContext, bool searchAuthor = false)
        {
            InitializeComponent();
            if(searchAuthor)
            {
                buttonSave.Text = "Wyszukaj";
                dateTimePicker1.ShowCheckBox = true;
                dateTimePicker1.Checked = false;  
            }
            this.dbContext = dbContext;
            this.formAction = searchAuthor ? FormAction.Search : FormAction.Add;          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Author> authors = null;

            switch(formAction)
            {
                case FormAction.Add:
                    AddAuthor();
                    break;
                case FormAction.Edit:
                    EditAuthor();
                    break;
                case FormAction.Search:
                    SearchAuthor(out authors);
                    break;
            }
                       
            dbContext.SaveChanges();
            authorSaved(this, authors);
            this.Close();
        }

        private void AddAuthor()
        {
            Author result = new Author();
            result.Name = textBoxName.Text;
            result.Surname = textBoxSurname.Text;
            result.BirthDate = dateTimePicker1.Value;
            dbContext.Authors.Add(result);
        }

        private void EditAuthor()
        {
            editedAuthor.Name = textBoxName.Text;
            editedAuthor.Surname = textBoxSurname.Text;
            editedAuthor.BirthDate = dateTimePicker1.Value;
        }

        private void SearchAuthor(out List<Author> authors)
        {
            authors = new List<Author>();           
            authors = dbContext.Authors
                .Where(a => textBoxName.Text.Trim() == String.Empty ? true : a.Name == textBoxName.Text)
                .Where(a => textBoxSurname.Text.Trim() == String.Empty ? true : a.Surname == textBoxSurname.Text)
                .Where(a => !dateTimePicker1.Checked ? true: a.BirthDate.Value.Year == dateTimePicker1.Value.Year &&
                                                             a.BirthDate.Value.Month == dateTimePicker1.Value.Month &&
                                                             a.BirthDate.Value.Day == dateTimePicker1.Value.Day)
                .ToList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
