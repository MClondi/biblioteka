﻿using Biblioteka.DB;
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
        public event EventHandler<List<Resource>> searchClicked;
        Boolean help = false;

        public SearchResource(LibraryDBContainer dbContext, EventHandler<List<Resource>> search)
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
            List<Resource> results = new List<Resource>();
            switch (comboBoxType.SelectedIndex)
            {
                case ((int)ResourceTypes.Book):
                    results = dbContext.Resources
                        .Where(r => r.Position is BookEdition)
                        .Where(r => textBoxTitle.Text.Trim().Equals(string.Empty) ? true : (r.Position as BookEdition).Book.Title.Contains(textBoxTitle.Text))
                        .Where(r => textBoxAuthorName.Text.Trim().Equals(string.Empty) ? true : (r.Position as BookEdition).Book.Authorship.FirstOrDefault().Author.Name.Contains(textBoxAuthorName.Text))
                        .Where(r => textBoxAuthorSurname.Text.Trim().Equals(string.Empty) ? true : (r.Position as BookEdition).Book.Authorship.FirstOrDefault().Author.Surname.Contains(textBoxAuthorSurname.Text))
                        .Where(r => textBoxPublisher.Text.Trim().Equals(string.Empty) ? true : (r.Position as BookEdition).Publisher.Name.Contains(textBoxPublisher.Text))
                        .ToList();
                    break;
                case ((int)ResourceTypes.Game):
                    results = dbContext.Resources
                        .Where(r => r.Position is Game)
                        .Where(r => textBoxTitle.Text.Trim().Equals(string.Empty) ? true : (r.Position as Game).Name.Contains(textBoxTitle.Text))
                        .Where(r => textBoxPublisher.Text.Trim().Equals(string.Empty) ? true : (r.Position as Game).Producer.Contains(textBoxPublisher.Text))
                        .ToList();
                    break;
                case ((int)ResourceTypes.Magazine):
                    results = dbContext.Resources
                        .Where(r => r.Position is MagazineNumber)
                        .Where(r => textBoxTitle.Text.Trim().Equals(string.Empty) ? true : (r.Position as MagazineNumber).Magazine.Title.Contains(textBoxTitle.Text))
                        .Where(r => textBoxPublisher.Text.Trim().Equals(string.Empty) ? true : (r.Position as MagazineNumber).Magazine.Publisher.Name.Contains(textBoxPublisher.Text))
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
            comboBoxType.Items.Add("Książka");
            comboBoxType.Items.Add("Gra");
            comboBoxType.Items.Add("Numer magazynu");
            comboBoxType.SelectedIndex = (int)ResourceTypes.Book;
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
