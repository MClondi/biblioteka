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
    public partial class GenreForm : Form
    {
        FormAction formAction;
        LibraryDBContainer dbContext;
        public event EventHandler<List<Genre>> genreSaved;
        Genre editedGenre = null;
        Boolean help;

        public GenreForm(LibraryDBContainer dbContext, Genre editedGenre)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.editedGenre = editedGenre;
            this.textBoxName.Text = editedGenre.Name;
            this.formAction = FormAction.Edit;
        }

        public GenreForm(LibraryDBContainer dbContext, bool searchGenre = false)
        {
            InitializeComponent();
            if (searchGenre)
            {
                buttonSave.Text = "Wyszukaj";
            }
            this.dbContext = dbContext;
            this.formAction = searchGenre ? FormAction.Search : FormAction.Add;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Genre> genres = null;

            switch (formAction)
            {
                case FormAction.Add:
                    AddGenre();
                    break;
                case FormAction.Edit:
                    EditGenre();
                    break;
                case FormAction.Search:
                    SearchGenre(out genres);
                    break;
            }

            dbContext.SaveChanges();
            genreSaved(this, genres);
            this.Close();
        }

        private void AddGenre()
        {
            Genre result = new Genre();
            result.Name = textBoxName.Text;
            dbContext.Genres.Add(result);
        }

        private void EditGenre()
        {
            editedGenre.Name = textBoxName.Text;
        }

        private void SearchGenre(out List<Genre> publishers)
        {
            publishers = new List<Genre>();
            publishers = dbContext.Genres
                .Where(p => textBoxName.Text.Trim() == String.Empty ? true : p.Name == textBoxName.Text)
                .ToList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
