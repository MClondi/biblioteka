﻿using Biblioteka.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.Forms
{
    public partial class ReportForm : Form
    {
        LibraryDBContainer dbContext;
        Boolean help = false;
        public ReportForm(LibraryDBContainer dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            comboBoxReports.Items.Add("Zwroty"); // zwroty z ostatnich 30 dni
            comboBoxReports.Items.Add("Wypożyczone książki"); // all borrowed books
            comboBoxReports.Items.Add("Użytkownicy biblioteki"); //all normal users listed
            textBoxReport.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
        }

        private void comboBoxReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxReports.SelectedIndex)
            {
                case 0:
                    textBoxReport.Text = "ID\tData wypożyczenia\t\tData zwrotu\t\tId zasobu\t\tCzytelnik\t\tID\n";
                    generateReturns();
                    break;
                case 1:
                    textBoxReport.Text = "ID\tData wypożyczenia\t\tTermin\t\t\tId zasobu\t\tCzytelnik\t\tID\n";
                    dbContext.Borrowings
                        .Where(x => x.ReturnDate == null).ToList()
                        .ForEach(x => textBoxReport.Text += (x.Id + "\t" + x.BorrowingDate + "\t" + x.ReturnTerm + "\t" + x.ResourceId + "\t\t" + x.User.Name + x.User.Surname + "\t\t" + x.User.Id + "\n"));
                    break;
                case 2:
                    textBoxReport.Text = "Imie\tNazwisko\tMiasto\tDom\tWypożyczenia\tRezerwacje\tDług\n";
                    dbContext.Readers.ToList()
                        .ForEach(x => textBoxReport.Text += (x.User.Name + "\t" + x.User.Surname + "\t" + x.City + "\t" + x.HouseNumber + "/" + x.ApartmentNumber + "\t" + x.Borrowing.Count + "\t" + x.Reservation.Count + "\t" +  x.Debt + "\n"));
                    break;
            }
            if (comboBoxReports.SelectedIndex == 0)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.FileName = "Raport-" + DateTime.Now.ToShortDateString();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, textBoxReport.Text.Split('\n'));
                  
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Błędny zakres dat");
                return;
            }
            if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Nie istnieją rekordy dla dat w przyszłości");
                return;
            }
            textBoxReport.Text = "ID\tData wypożyczenia\t\tData zwrotu\t\tId zasobu\t\tCzytelnik\t\tID\nfds";
            generateReturns();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Błędny zakres dat");
                return;
            }
            if (dateTimePicker2.Value > DateTime.Today)
            {
                MessageBox.Show("Nie istnieją rekordy dla dat w przyszłości");
                return;
            }
            textBoxReport.Text = "ID\tData wypożyczenia\t\tData zwrotu\t\tId zasobu\t\tCzytelnik\t\tID\n";
            generateReturns();
        }

        private void generateReturns()
        {
            var from = dateTimePicker1.Value;
            var to = dateTimePicker2.Value;
            dbContext.Borrowings
                .Where(x => x.ReturnDate != null)
                .Where(x => x.ReturnDate > from)
                .Where(x => x.ReturnDate < to).ToList()
                .ForEach(x => textBoxReport.Text += (x.Id + "\t" + x.BorrowingDate + "\t" + x.ReturnDate + "\t" + x.ResourceId + "\t\t" + x.User.Name + x.User.Surname + "\t\t" + x.User.Id + "\n"));
                   
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
