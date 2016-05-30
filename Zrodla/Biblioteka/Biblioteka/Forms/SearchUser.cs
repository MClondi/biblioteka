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
            String type = null;
            switch (typeSpinner.SelectedIndex)
            {
                case 0:
                    type = "U";
                    break;
                case 1:
                    type = "L";
                    break;
                case 2:
                    type = "A";
                    break;
            }

            // SOME HARD LOGIC BELOW, BUT WORKS
            resultList = dbContext.Users
                .Where(u => u.Type == type)
                .Where(u => textBoxLogin.Text.Trim() == String.Empty ? true : u.Login == textBoxLogin.Text)
                .Where(u => textBoxMail.Text.Trim() == String.Empty ? true : u.E_Mail == textBoxMail.Text)
                .Where(u => textBoxName.Text.Trim() == String.Empty ? true : u.Name == textBoxName.Text)
                .Where(u => textBoxSurname.Text.Trim() == String.Empty ? true : u.Surname == textBoxSurname.Text)
                .Where(u => textBoxTel.Text.Trim() == String.Empty || !type.Equals("U") ? true : u.Reader.PhoneNumber == textBoxTel.Text)
                .Where(u => textBoxStreet.Text.Trim() == String.Empty || !type.Equals("U") ? true : u.Reader.Street == textBoxStreet.Text)
                .Where(u => textBoxStrNum.Text.Trim() == String.Empty || !type.Equals("U") ? true : u.Reader.HouseNumber == textBoxStrNum.Text)
                .Where(u => textBoxApt.Text.Trim() == String.Empty || !type.Equals("U") ? true : u.Reader.ApartmentNumber == textBoxApt.Text)
                .Where(u => textBoxCity.Text.Trim() == String.Empty || !type.Equals("U") ? true : u.Reader.City == textBoxCity.Text)
                .Where(u => textBoxPostal.Text.Trim() == String.Empty || !type.Equals("U") ? true : u.Reader.PostalCode == textBoxPostal.Text)
                .ToList();
                
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
