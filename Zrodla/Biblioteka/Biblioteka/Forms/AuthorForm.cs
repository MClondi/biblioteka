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

        LibraryDBContainer dbContext;
        public event EventHandler authorSaved;
        Author editedAuthor = null;
        Boolean help;

        public AuthorForm(LibraryDBContainer dbContext, EventHandler onAuthorSave, Author editedAuthor) : this(dbContext, onAuthorSave)
        {
            this.editedAuthor = editedAuthor;
            this.textBoxName.Text = editedAuthor.Name;
            this.textBoxSurname.Text = editedAuthor.Surname;
            this.dateTimePicker1.Value = (DateTime)editedAuthor.BirthDate;
        }

        public AuthorForm(LibraryDBContainer dbContext, EventHandler onAuthorSave)
        {
            this.dbContext = dbContext;
            this.authorSaved += onAuthorSave;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (editedAuthor != null)
            {
                editedAuthor.Name = textBoxName.Text;
                editedAuthor.Surname = textBoxSurname.Text;
                editedAuthor.BirthDate = dateTimePicker1.Value;
            }
            else
            {
                Author result = new Author();
                result.Name = textBoxName.Text;
                result.Surname = textBoxSurname.Text;
                result.BirthDate = dateTimePicker1.Value;
                dbContext.Authors.Add(result);
            }
            dbContext.SaveChanges();
            authorSaved(this, e);
            this.Close();
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
