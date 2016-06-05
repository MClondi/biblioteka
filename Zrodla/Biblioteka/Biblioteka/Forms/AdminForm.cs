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
            parent.Show();
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(getSelectedUser() != null)
            {
                dbContext.Users.Remove(dbContext.Users.First(userSearch => userSearch.Id == getSelectedUser().Id));
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
            lstViewAllUsers.Clear();
            tagSet.Clear();
            foreach (User usr in users)
            {
                ListViewItem item = new ListViewItem(usr.Name + " " + usr.Surname);
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
                    MessageBox.Show("Error");
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

    }
}
