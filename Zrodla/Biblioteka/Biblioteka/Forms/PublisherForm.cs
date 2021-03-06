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
    public partial class PublisherForm : Form
    {
        FormAction formAction;
        LibraryDBContainer dbContext;
        public event EventHandler<List<Publisher>> publisherSaved;
        Publisher editedPublisher = null;
        Boolean help;

        public PublisherForm(LibraryDBContainer dbContext, Publisher editedPublisher)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.editedPublisher = editedPublisher;
            this.textBoxName.Text = editedPublisher.Name;
            this.formAction = FormAction.Edit;
        }

        public PublisherForm(LibraryDBContainer dbContext, bool searchPublisher = false)
        {
            InitializeComponent();
            if (searchPublisher)
            {
                buttonSave.Text = "Wyszukaj";
            }
            this.dbContext = dbContext;
            this.formAction = searchPublisher ? FormAction.Search : FormAction.Add; 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Publisher> publishers = null;

            switch (formAction)
            {
                case FormAction.Add:
                    if (!AddPublisher())
                        return;
                    break;
                case FormAction.Edit:
                    if (!EditPublisher())
                        return;
                    break;
                case FormAction.Search:
                    SearchPublisher(out publishers);
                    break;
            }

            dbContext.SaveChanges();
            publisherSaved(this, publishers);
            this.Close();
        }

        private bool AddPublisher()
        {
            if (textBoxName.Text.Count() == 0)
            {
                MessageBox.Show("Nazwa nie może być pusta");
                return false;
            }
            Publisher result = new Publisher();
            result.Name = textBoxName.Text;
            dbContext.Publishers.Add(result);
            return true;
        }

        private bool EditPublisher()
        {
            if (textBoxName.Text.Count() == 0)
            {
                MessageBox.Show("Nazwa nie może być pusta");
                return false;
            }
            editedPublisher.Name = textBoxName.Text;
            return true;
        }

        private void SearchPublisher(out List<Publisher> publishers)
        {
            publishers = new List<Publisher>();
            publishers = dbContext.Publishers
                .Where(p => textBoxName.Text.Trim() == String.Empty ? true : p.Name == textBoxName.Text)
                .ToList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
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
