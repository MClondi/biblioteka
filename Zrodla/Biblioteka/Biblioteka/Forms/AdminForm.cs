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
    public partial class AdminForm : Form
    {
        Form parent;
        LibraryDBContainer dbContext;
        Dictionary<String, User> tagSet = new Dictionary<string, User>();
        Boolean help = false;
        public AdminForm(Form parent, LibraryDBContainer dbContext)
        {
            InitializeComponent();
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            refreshListView(dbContext.Users.ToList());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(getSelectedUser() != null)
            {
                int userToDeleteId = getSelectedUser().Id;
                dbContext.Users.Remove(dbContext.Users.First(userSearch => userSearch.Id == userToDeleteId));
                dbContext.SaveChanges();
                refreshListView(dbContext.Users.ToList());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser newUser = new AddUser(false, dbContext);
            newUser.userSaved += new EventHandler(userSaved);
            newUser.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (getSelectedUser() != null)
            {
                AddUser editUser = new AddUser(getSelectedUser(), dbContext);
                editUser.userSaved += new EventHandler(userSaved);
                editUser.Show();
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SearchUser searchUserForm = new SearchUser(dbContext, searchClicked);
            searchUserForm.Show();
        }

        private void refreshListView(List<User> users)
        {
            lstViewAllUsers.Items.Clear();
            tagSet.Clear();
            foreach (User usr in users)
            {
                string[] row = { usr.Name, usr.Surname };
                ListViewItem item = new ListViewItem(row);
                item.Tag = usr.GetHashCode();
                tagSet.Add(item.Tag.ToString(), usr);
                lstViewAllUsers.Items.Add(item);
            }
        }

        private User getSelectedUser()
        {
            User user = null;
            if (lstViewAllUsers.SelectedItems.Count > 0)
            {
                if ( ! tagSet.TryGetValue(lstViewAllUsers.SelectedItems[0].Tag.ToString(), out user))
                {
                    MessageBox.Show("Błąd");
                }                
            }

            return user;
        }

        void userSaved(object sender, EventArgs e)
        {
            refreshListView(dbContext.Users.ToList());
        }
        
        void searchClicked(object sender, List<User> searchResults)
        {
            refreshListView(searchResults);
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLogout_Click(sender, e);
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
