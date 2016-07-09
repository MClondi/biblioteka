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
    public partial class GuestForm : Form
    {
        LibraryDBContainer dbContext;
        Form parent;
        Boolean help;
        Dictionary<String, Resource> tagSet = new Dictionary<string, Resource>();

        public GuestForm(Form parent, LibraryDBContainer dbContext)
        {
            InitializeComponent();
            parent.Hide();
            this.parent = parent;
            this.dbContext = dbContext;
            refreshListView(dbContext.Resources.ToList());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
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

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            SearchResource sr = new SearchResource(dbContext, searchClicked);
            sr.ShowDialog();
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

        private void GuestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            parent.Show();
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
