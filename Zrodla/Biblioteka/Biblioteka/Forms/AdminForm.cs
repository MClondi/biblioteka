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
            foreach (User user in dbContext.Users)
            {
                ListViewItem item = new ListViewItem(user.Name + " " + user.Surname);
                item.Tag = user.GetHashCode();
                tagSet.Add(item.Tag.ToString(), user);
                lstViewAllUsers.Items.Add(item);
            }
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
                    int usrId = user.Id;
                    dbContext.Users.Remove(dbContext.Users.First(userSearch => userSearch.Id == usrId));
                    dbContext.SaveChanges();
                    // listview populate
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
                
            }
        }

    }
}
