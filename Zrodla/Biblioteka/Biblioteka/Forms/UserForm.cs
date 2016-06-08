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
        User userContext;
        Dictionary<String, Position> tagSet = new Dictionary<string, Position>();

        public UserForm(Form parent, LibraryDBContainer dbContext, User userContext)
        {
            
            InitializeComponent();
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            this.userContext = userContext;
            refreshListView(dbContext.Positions.ToList());
        }

        private void btnCheckIfResourceAvailable_Click(object sender, EventArgs e)
        {
            if (lstViewBooksAndUsers.SelectedItems.Count > 0)
            {
                Position resource;
                if (tagSet.TryGetValue(lstViewBooksAndUsers.SelectedItems[0].Tag.ToString(), out resource))
                {

                    if (DbUtils.IsResourceBorrowed(dbContext, resource))
                    {

                        MessageBox.Show("Zasób niedostępny");
                    }
                    else
                    {

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
           
        }

        private void btnCheckBorrowedPositions_Click(object sender, EventArgs e)
        {
            BorrowedResources brform = new BorrowedResources();

            foreach( Borrowing bor in userContext.Borrowing)
            {
          
                if (bor.Resource.Position is Game)
                {
                   brform.addItem( ((Game)bor.Resource.Position).Name );
                }
                else if (bor.Resource.Position is MagazineNumber)
                {
                    brform.addItem( ((MagazineNumber)bor.Resource.Position).Magazine.Title );
                }
                else if (bor.Resource.Position is BookEdition)
                {
                    brform.addItem(((BookEdition)bor.Resource.Position).Book.Title);
                }
            }
            brform.initialize();
        }

        private void btnUpdateUserAccount_Click(object sender, EventArgs e)
        {
            ReaderApplicationForm raf = new ReaderApplicationForm(userContext ,dbContext);
            raf.Show();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void refreshListView(List<Position> positions)
        {
            tagSet.Clear();
            lstViewBooksAndUsers.Clear();

            foreach (Position pos in positions)
            {
                ListViewItem item = new ListViewItem();

                if (pos is BookEdition)
                {
                    item.Text = ((BookEdition)pos).Book.Title;
                }
                else if (pos is Game)
                {
                    item.Text = ((Game)pos).Name;
                }
                else if (pos is MagazineNumber)
                {
                    item.Text = ((MagazineNumber)pos).Magazine.Title;
                }

                item.Tag = pos.GetHashCode();
                tagSet.Add(item.Tag.ToString(), pos);
                lstViewBooksAndUsers.Items.Add(item);
            }
        }

        void searchClicked(object sender, List<Position> results)
        {
            refreshListView(results);
        }

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            SearchResource sr = new SearchResource(dbContext, searchClicked);
            sr.Show();
        }
    }
}
