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
            refreshListView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lstViewAllUsers.SelectedItems.Count > 0)
            {

                User user;
                if (tagSet.TryGetValue(lstViewAllUsers.SelectedItems[0].Tag.ToString(), out user))
                {
                    dbContext.Users.Remove(dbContext.Users.First(userSearch => userSearch.Id == user.Id));
                    dbContext.SaveChanges();
                    refreshListView();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                
            }
        }

        private void refreshListView()
        {
            lstViewAllUsers.Clear();
            tagSet.Clear();
            foreach (User usr in dbContext.Users)
            {
                ListViewItem item = new ListViewItem(usr.Name + " " + usr.Surname);
                item.Tag = usr.GetHashCode();
                tagSet.Add(item.Tag.ToString(), usr);
                lstViewAllUsers.Items.Add(item);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser newUser = new AddUser(false);
            newUser.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (lstViewAllUsers.SelectedItems.Count > 0)
            {

                User user;
                if (tagSet.TryGetValue(lstViewAllUsers.SelectedItems[0].Tag.ToString(), out user))
                {
                    AddUser editUser = new AddUser(user);
                    editUser.Show();
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }

    }
}
