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
    public partial class UserForm : Form
    {
        LibraryDBContainer dbContext;
        Form parent;
        public UserForm(Form parent, LibraryDBContainer dbContext)
        {
            
            InitializeComponent();
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            foreach (Book book in dbContext.Books)
            {
                lstViewBooksAndUsers.Items.Add(new ListItemBook(book));
            }

            //test
            lstViewBooksAndUsers.Items.Add("test");
        }

        private void btnCheckIfResourceAvailable_Click(object sender, EventArgs e)
        {
            if (lstViewBooksAndUsers.SelectedItems.Count > 0)
            {
                int pos = ((ListItemBook)lstViewBooksAndUsers.SelectedItems[0]).getBook().Id;

                var resources = from r in dbContext.Resources
                                where r.PositionId == pos
                                select r;

                foreach (Resource res in resources)
                {
                    var bor = from b in dbContext.Borrowings
                              where b.ResourceId == res.Id
                              select b;

                    foreach (Borrowing b in bor)
                    {
                        if (b.ReturnDate > DateTime.Now)
                        {
                            MessageBox.Show("Ksiazka niedostępna");
                            return;
                        }
                    }
                }

                MessageBox.Show("Książka dostępna");

            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }
    }
}
