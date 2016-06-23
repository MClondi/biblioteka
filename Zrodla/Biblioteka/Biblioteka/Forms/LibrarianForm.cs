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
        private Dictionary<String, Author> authorTagSet = new Dictionary<string, Author>();
        private Dictionary<String, Publisher> publisherTagSet = new Dictionary<string, Publisher>();

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

       

        private void btnAddPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {

        }



        private void btnEditPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
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
        void refresh(object sender, List<Author> users)
        {
            // todo refresh the listview after add/edit/delete action
        }

        private void btnSearchResource_Click_1(object sender, EventArgs e)
        {
            SearchResource sr = new SearchResource(dbContext, searchResourceClicked);
            sr.Show();
        }



        //Authors

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm addAuthor = new AuthorForm(dbContext);
            addAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            addAuthor.Show();
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm editAuthor = new AuthorForm(dbContext, (Author) GuiUtils.GetSelected<Author>(lstViewAuthors, authorTagSet));
            editAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            editAuthor.Show();
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = GuiUtils.GetSelected<Author>(lstViewAuthors, authorTagSet);

            if (selectedAuthor != null)
            {
                int authorToDeleteId = selectedAuthor.Id;
                var authorToDelete = dbContext.Authors.Include("Authorship")
                               .Where(author => author.Id == authorToDeleteId).FirstOrDefault();
                dbContext.Authors.Remove(authorToDelete);
                dbContext.SaveChanges();
                RefreshAuthorListView();
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm searchAuthor = new AuthorForm(dbContext, true);
            searchAuthor.authorSaved += new EventHandler<List<Author>>(authorSaved);
            searchAuthor.Show();
        }

        void authorSaved(object sender, List<Author> authors)
        {
            RefreshAuthorListView(authors);
        }

        private void RefreshAuthorListView(List<Author> authors = null)
        {
            if (authors == null)
            {
                authors = dbContext.Authors.ToList();
            }

            lstViewAuthors.Items.Clear();
            authorTagSet.Clear();
            foreach (Author author in authors)
            {
                string[] row = { author.Name, author.Surname };
                ListViewItem item = new ListViewItem(row);
                item.Tag = author.GetHashCode();
                authorTagSet.Add(item.Tag.ToString(), author);
                lstViewAuthors.Items.Add(item);
            }
        }

        //Publishers

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm addPublisher = new PublisherForm(dbContext);
            addPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
            addPublisher.Show();
        }

        private void btnEditPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm editPublisher = new PublisherForm(dbContext, (Publisher)GuiUtils.GetSelected<Publisher>(lstViewPublishers, publisherTagSet));
            editPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
            editPublisher.Show();
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            Publisher selectedPublisher = GuiUtils.GetSelected<Publisher>(lstViewPublishers, publisherTagSet);

            if (selectedPublisher != null)
            {
                int publisherToDeleteId = selectedPublisher.Id;
                var publisherToDelete = dbContext.Publishers
                               .Where(publisher => publisher.Id == publisherToDeleteId).FirstOrDefault();
                dbContext.Publishers.Remove(publisherToDelete);
                dbContext.SaveChanges();
                RefreshPublisherListView();
            }
        }

        private void btnSearchPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm searchPublisher = new PublisherForm(dbContext, true);
            searchPublisher.publisherSaved += new EventHandler<List<Publisher>>(publisherSaved);
            searchPublisher.Show();
        }

        void publisherSaved(object sender, List<Publisher> publishers)
        {
            RefreshPublisherListView(publishers);
        }

        private void RefreshPublisherListView(List<Publisher> publishers = null)
        {
            if (publishers == null)
            {
                publishers = dbContext.Publishers.ToList();
            }

            lstViewPublishers.Items.Clear();
            publisherTagSet.Clear();
            foreach (Publisher publisher in publishers)
            {
                string[] row = { publisher.Name };
                ListViewItem item = new ListViewItem(row);
                item.Tag = publisher.GetHashCode();
                publisherTagSet.Add(item.Tag.ToString(), publisher);
                lstViewPublishers.Items.Add(item);
            }
        }

    }
}
