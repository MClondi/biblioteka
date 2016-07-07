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
    public partial class MagazineForm : Form
    {
        FormAction formAction;
        LibraryDBContainer dbContext;
        public event EventHandler<List<Magazine>> magazineSaved;
        Magazine editedMagazine = null;
        Boolean help;

        public MagazineForm(LibraryDBContainer dbContext, Magazine editedMagazine)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.editedMagazine = editedMagazine;
            this.txtBoxName.Text = editedMagazine.Title;
            InitSpinners();
            this.publisherSpinner.Text = editedMagazine.Publisher.Name;
            this.genreSpinner.Text = editedMagazine.Genre.Name;
            this.formAction = FormAction.Edit;
        }

        public MagazineForm(LibraryDBContainer dbContext, bool searchMagazine = false)
        {
            InitializeComponent();
            if (searchMagazine)
            {
                buttonSave.Text = "Wyszukaj";
                genreSpinner.Items.Add("Dowolny");
                publisherSpinner.Items.Add("Dowolny");
            }
            this.dbContext = dbContext;
            InitSpinners();
            this.formAction = searchMagazine ? FormAction.Search : FormAction.Add;          
        }

        private void InitSpinners()
        {
            foreach (Genre genre in dbContext.Genres)
            {
                genreSpinner.Items.Add(genre.Name);
            }
            if (genreSpinner.Items.Count > 0)
                genreSpinner.SelectedIndex = 0;

            foreach (Publisher publisher in dbContext.Publishers)
            {
                publisherSpinner.Items.Add(publisher.Name);
            }
            if (publisherSpinner.Items.Count > 0)
                publisherSpinner.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Magazine> magazines = null;

            switch (formAction)
            {
                case FormAction.Add:
                    if (!AddMagazine())
                        return;
                    break;
                case FormAction.Edit:
                    if (!EditMagazine(editedMagazine))
                        return;
                    break;
                case FormAction.Search:
                    SearchMagazine(out magazines);
                    break;
            }

            dbContext.SaveChanges();
            magazineSaved(this, magazines);
            this.Close();
        }

        private bool AddMagazine()
        {
            Magazine magazine = new Magazine();
            if (!EditMagazine(magazine))
                return false;
            dbContext.Magazines.Add(magazine);
            return true;
        }

        private bool EditMagazine(Magazine editedMagazine)
        {
            if (txtBoxName.Text.Count() == 0)
            {
                MessageBox.Show("Nazwa nie może być pusta");
                return false;
            }
            editedMagazine.Title = txtBoxName.Text;
            editedMagazine.Genre = dbContext.Genres.Where(g => g.Name == genreSpinner.Text).FirstOrDefault();
            editedMagazine.Publisher = dbContext.Publishers.Where(p => p.Name == publisherSpinner.Text).FirstOrDefault();
            return true;
        }

        private void SearchMagazine(out List<Magazine> magazines)
        {
            magazines = new List<Magazine>();

            magazines = dbContext.Magazines.Include("Genre").Include("Publisher")
                .Where(m => txtBoxName.Text.Trim() == String.Empty ? true : m.Title == txtBoxName.Text)
                .Where(m => genreSpinner.SelectedIndex == 0 ? true : m.Genre.Name == genreSpinner.Text)
                .Where(m => publisherSpinner.SelectedIndex == 0 ? true : m.Publisher.Name == publisherSpinner.Text)
                .ToList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
