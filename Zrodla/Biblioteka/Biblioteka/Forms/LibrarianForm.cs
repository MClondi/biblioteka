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
    public partial class LibrarianForm : Form
    {
        Form parent;
        LibraryDBContainer dbContext;
        Boolean help;

        public LibrarianForm(Form parent, LibraryDBContainer dbContext)
        {
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            InitializeComponent();
        }

        

        private void LibrarianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SearchUser searchUserForm = new SearchUser(dbContext, searchUserClicked);
            searchUserForm.Show();
        }
        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            SearchResource sr = new SearchResource(dbContext, searchResourceClicked);
            sr.Show();
        }
        private void btnReserveResource_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrowResource_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnNoteReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm addAuthor = new AuthorForm(dbContext, refresh);
            addAuthor.Show();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {

        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {

        }

        void searchUserClicked(object sender, List<User> searchResults)
        {
            lstViewBooksAndUsers.Items.Clear();
            foreach (User usr in searchResults)
            {
                string[] row = { usr.Name, usr.Surname };
                ListViewItem item = new ListViewItem(row);
                lstViewBooksAndUsers.Items.Add(item);
            }
        }
        void searchResourceClicked(object sender, List<Position> results)
        {
            // todo populate the list of resources
        }
        void refresh(object sender, EventArgs e)
        {
            // todo refresh the listview after add/edit/delete action
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
