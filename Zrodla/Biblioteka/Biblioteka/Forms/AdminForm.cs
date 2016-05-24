using Biblioteka.Adapters;
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

        public AdminForm(Form parent, LibraryDBContainer dbContext)
        {
            InitializeComponent();
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            foreach (User user in dbContext.Users)
            {
                lstViewAllUsers.Items.Add(new ListItemUser(user));
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
                int usrId = ((ListItemUser)lstViewAllUsers.SelectedItems[0]).getUser().Id;
                dbContext.Users.Remove(dbContext.Users.First(user => user.Id == usrId));
                dbContext.SaveChanges();
            }
        }
    }
}
