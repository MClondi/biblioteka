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
                    textBoxReport.Text = "ID\tData wypożyczenia\Data zwrotu\tId zasobu\tCzytelnik\tID\n";
                    generateReturns();
                    break;
                case 1:
                    textBoxReport.Text = "ID\tData wypożyczenia\tTermin\tId zasobu\tCzytelnik\tID\n";
                    dbContext.Borrowings
                        .Where(x => x.ReturnDate == null).ToList()
                        .ForEach(x => textBoxReport.Text += (x.Id + "\t" + x.BorrowingDate + "\t" + x.ReturnTerm + "\t" + x.ResourceId + "\t" + x.User.Name + x.User.Surname + "\t" + x.User.Id + "\n"));
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
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Write(Encoding.ASCII.GetBytes(textBoxReport.Text), 0, Encoding.ASCII.GetBytes(textBoxReport.Text).Length);
                    myStream.Close();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            generateReturns();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
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
                .ForEach(x => textBoxReport.Text += (x.Id + "\t" + x.BorrowingDate + "\t" + x.ReturnDate + "\t" + x.ResourceId + "\t" + x.User.Name + x.User.Surname + "\t" + x.User.Id + "\n"));
                   
        }
    }
}