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
    public partial class SearchUser : Form
    {

        LibraryDBContainer dbContext;
        public event EventHandler<List<User>> searchClicked;

        public SearchUser(LibraryDBContainer dbContext, EventHandler<List<User>> search)
        {
            this.dbContext = dbContext;
            this.searchClicked += search;
            InitializeComponent();
            initSpinner();
            typeSpinner.SelectedIndex = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<User> resultList = new List<User>();
            //todo search in dbContext
            searchClicked(this, resultList);
            this.Close();
        }

        private void initSpinner()
        {
            typeSpinner.Items.Add("User");
            typeSpinner.Items.Add("Librarian");
            typeSpinner.Items.Add("Admin");
        }
    }
}
