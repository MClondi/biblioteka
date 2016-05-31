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

    public partial class SearchResource : Form
    {

        LibraryDBContainer dbContext;
        public event EventHandler<List<Position>> searchClicked;

        public SearchResource(LibraryDBContainer dbContext, EventHandler<List<Position>> search)
        {
            this.dbContext = dbContext;
            this.searchClicked += search;
            InitializeComponent();
            initSpinner();
        }


        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == (int)ResourceTypes.Book)
            {
                textBoxAuthorName.Enabled = true;
                textBoxAuthorSurname.Enabled = true;
            }
            else
            {
                textBoxAuthorName.Enabled = false;
                textBoxAuthorSurname.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Position> results = new List<Position>();
            switch (comboBoxType.SelectedIndex)
            {
                case ((int)ResourceTypes.Book):
                    results = dbContext.Positions
                        .Where(position => position is BookEdition)
                        .Where(book => textBoxTitle.Text.Trim().Equals(string.Empty) ? true : ((BookEdition)book).Book.Title.Contains(textBoxTitle.Text))
                        .Where(book => textBoxAuthorName.Text.Trim().Equals(string.Empty) ? true : ((BookEdition)book).Book.Authorship.First().Author.Name.Contains(textBoxAuthorName.Text))
                        .Where(book => textBoxAuthorSurname.Text.Trim().Equals(string.Empty) ? true : ((BookEdition)book).Book.Authorship.First().Author.Surname.Contains(textBoxAuthorSurname.Text))
                        .Where(book => textBoxPublisher.Text.Trim().Equals(string.Empty) ? true : ((BookEdition)book).Publisher.Name.Contains(textBoxPublisher.Text))
                        .ToList();
                    break;
                case ((int)ResourceTypes.Game):
                    results = dbContext.Positions
                        .Where(position => position is Game)
                        .Where(game => textBoxTitle.Text.Trim().Equals(string.Empty) ? true : ((Game)game).Name.Contains(textBoxTitle.Text))
                        .Where(game => textBoxPublisher.Text.Trim().Equals(string.Empty) ? true : ((Game)game).Producer.Contains(textBoxPublisher.Text))
                        .ToList();
                    break;
                case ((int)ResourceTypes.Magazine):
                    results = dbContext.Positions
                        .Where(position => position is MagazineNumber)
                        .Where(magazine => textBoxTitle.Text.Trim().Equals(string.Empty) ? true : ((MagazineNumber)magazine).Magazine.Title.Contains(textBoxTitle.Text))
                        .Where(magazine => textBoxPublisher.Text.Trim().Equals(string.Empty) ? true : ((MagazineNumber)magazine).Magazine.Publisher.Name.Contains(textBoxPublisher.Text))
                        .ToList();
                    break;
            }
            searchClicked(this, results);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initSpinner()
        {
            comboBoxType.Items.Add("Book");
            comboBoxType.Items.Add("Game");
            comboBoxType.Items.Add("Magazine");
            comboBoxType.SelectedIndex = (int)ResourceTypes.Book;
        }

    }
}
