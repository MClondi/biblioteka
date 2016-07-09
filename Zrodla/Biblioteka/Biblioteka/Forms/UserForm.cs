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
    public partial class UserForm : Form
    {
        LibraryDBContainer dbContext;
        Form parent;
        User userContext;
        Dictionary<String, Resource> tagSet = new Dictionary<string, Resource>();
        Boolean help;

        public UserForm(Form parent, LibraryDBContainer dbContext, User userContext)
        {
            
            InitializeComponent();
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            this.userContext = userContext;
            refreshListView(dbContext.Resources.ToList());
        }

        private void btnCheckIfResourceAvailable_Click(object sender, EventArgs e)
        {
            if (lstViewBooksAndUsers.SelectedItems.Count > 0)
            {
                Resource resource;
                if (tagSet.TryGetValue(lstViewBooksAndUsers.SelectedItems[0].Tag.ToString(), out resource))
                {

                    if (DbUtils.IsResourceBorrowed(dbContext, resource))
                    {
                        if(DbUtils.IsResourceReserved(dbContext, resource))
                            MessageBox.Show("Zasób wypożyczony i zarezerwowany");
                        else
                            MessageBox.Show("Zasób wypożyczony");
                    }
                    else
                    {
                        if (DbUtils.IsResourceReserved(dbContext, resource))
                            MessageBox.Show("Zasób zarezerwowany");
                        else
                            MessageBox.Show("Zasób dostępny");
                    }
                }
                else
                {

                    MessageBox.Show("Nastąpił błąd.");
                }

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void btnReserveResource_Click(object sender, EventArgs e)
        {
            if (lstViewBooksAndUsers.SelectedItems.Count > 0)
            {
                Resource resource;
                if (tagSet.TryGetValue(lstViewBooksAndUsers.SelectedItems[0].Tag.ToString(), out resource))
                {

                    if (!DbUtils.IsResourceReserved(dbContext, resource))
                    {
                        Reservation reservation = new Reservation();
                        reservation.Reader = userContext.Reader;
                        reservation.Resource = resource;

                        if (DbUtils.IsResourceBorrowed(dbContext, resource))
                        {
                            Borrowing bor = dbContext.Borrowings
                                            .Where(b => b.ReturnDate == null)
                                            .Where(b => b.ResourceId == resource.Id)
                                            .OrderBy(b => b.ReturnTerm)
                                            .ToList()
                                            .FirstOrDefault();
                            
                            reservation.RealizationDate = bor.ReturnTerm.AddMonths(1);
                        }
                        else
                        {
                            reservation.RealizationDate = DateTime.Now.AddMonths(1);
                        }

                        dbContext.Reservations.Add(reservation);
                        MessageBox.Show("Twoja rezerwacja trwa do " + reservation.RealizationDate.ToString(), "Informacja");
                    }
                    else
                    {
                        MessageBox.Show("Zasób jest zarezerwowany", "Błąd");
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano zasobu", "Błąd");
                }
            }

            dbContext.SaveChanges();
        }

        private void btnCheckBorrowedPositions_Click(object sender, EventArgs e)
        {
            BorrowedResources brform = new BorrowedResources();
            List<Borrowing> borrowings = dbContext.Borrowings
                                            .Where(b => b.ReaderId == userContext.Reader.Id)
                                            .Where(b => b.ReturnDate == null)
                                            .ToList();

            foreach (Borrowing bor in borrowings)
            {
          
                if (bor.Resource.Position is Game)
                {
                   brform.addItem( ((Game)bor.Resource.Position).Name + " do " + bor.ReturnTerm.ToString());
                }
                else if (bor.Resource.Position is MagazineNumber)
                {
                    brform.addItem(((MagazineNumber)bor.Resource.Position).Magazine.Title + " do " + bor.ReturnTerm.ToString());
                }
                else if (bor.Resource.Position is BookEdition)
                {
                    brform.addItem(((BookEdition)bor.Resource.Position).Book.Title + " do " + bor.ReturnTerm.ToString());
                }
            }
            brform.initialize();
        }

        private void btnUpdateUserAccount_Click(object sender, EventArgs e)
        {
            ReaderApplicationForm raf = new ReaderApplicationForm(userContext ,dbContext);
            raf.ShowDialog();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void refreshListView(List<Resource> resources)
        {
            tagSet.Clear();
            lstViewBooksAndUsers.Clear();

            foreach (Resource res in resources)
            {
                ListViewItem item = new ListViewItem();

                if (res.Position is BookEdition)
                {
                    item.Text = ((BookEdition)res.Position).Book.Title;
                }
                else if (res.Position is Game)
                {
                    item.Text = ((Game)res.Position).Name;
                }
                else if (res.Position is MagazineNumber)
                {
                    item.Text = ((MagazineNumber)res.Position).Magazine.Title;
                }

                item.Tag = res.GetHashCode();
                tagSet.Add(item.Tag.ToString(), res);
                lstViewBooksAndUsers.Items.Add(item);
            }
        }

        void searchClicked(object sender, List<Resource> results)
        {
            refreshListView(results);
        }

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            SearchResource sr = new SearchResource(dbContext, searchClicked);
            sr.ShowDialog();
            BookEdition eb = new BookEdition();            
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
