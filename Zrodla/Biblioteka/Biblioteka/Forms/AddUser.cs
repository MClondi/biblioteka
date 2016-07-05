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
    public partial class AddUser : Form
    {

        LibraryDBContainer dbContext;
        User editedUser = null;
        public event EventHandler userSaved;
        Boolean help = false;

        public AddUser(bool hideTypeSpinner, LibraryDBContainer dbContext)
        {

            this.dbContext = dbContext;
            
            InitializeComponent();
            this.Text = "Dodaj użytkownika";
            textBoxPassword.PasswordChar = '*';
            initSpinner();
            typeSpinner.SelectedIndex = 0;
            if (hideTypeSpinner)
            {
                typeSpinner.Hide();
                label11.Hide();
            }
        }

        public AddUser(User u, LibraryDBContainer dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            this.Text = "Edytuj użytkownika";
            editedUser = u;
            initSpinner();
            typeSpinner.Hide();
            label11.Hide();
            initUser(u);
            textBoxPassword.PasswordChar = '*';
            textBoxLogin.Enabled = false;
            switch (u.Type)
            {       
                case "U":
                    typeSpinner.SelectedIndex = 0;
                    textBoxTel.Text = u.Reader.PhoneNumber;
                    textBoxStreet.Text = u.Reader.Street;
                    textBoxStrNum.Text = u.Reader.HouseNumber;
                    textBoxApt.Text = u.Reader.ApartmentNumber;
                    textBoxCity.Text = u.Reader.City;
                    textBoxPostal.Text = u.Reader.PostalCode;
                    break;
                case "L":
                    typeSpinner.SelectedIndex = 1;
                    readerComponents(false);
                    break;
                case "A":
                    typeSpinner.SelectedIndex = 2;
                    readerComponents(false);
                    break;
            }

        }

        private void typeSpinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            readerComponents(typeSpinner.SelectedIndex == 0) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (editedUser != null)
            {
                editedUser.Password = textBoxPassword.Text;
                editedUser.E_Mail = textBoxMail.Text;
                editedUser.Name = textBoxName.Text;
                editedUser.Surname = textBoxSurname.Text;
                
                if (editedUser.Type.Equals("U"))
                {
                    editedUser.Reader.PhoneNumber = textBoxTel.Text;
                    editedUser.Reader.Street = textBoxStreet.Text;
                    editedUser.Reader.HouseNumber = textBoxStrNum.Text;
                    editedUser.Reader.ApartmentNumber = textBoxApt.Text;
                    editedUser.Reader.City = textBoxCity.Text;
                    editedUser.Reader.PostalCode = textBoxPostal.Text;
                }

                dbContext.SaveChanges();

            }
            else
            {
                switch (typeSpinner.SelectedIndex)
                {
                    case 0:
                        editedUser = DbUtils.AddReader(dbContext, textBoxLogin.Text, textBoxPassword.Text, 
                            textBoxName.Text, textBoxSurname.Text, textBoxMail.Text, textBoxTel.Text, textBoxStreet.Text, 
                            textBoxStrNum.Text, textBoxApt.Text, textBoxCity.Text, textBoxPostal.Text);
                        break;
                    case 1:
                        editedUser = DbUtils.AddUser("L", dbContext, textBoxLogin.Text, textBoxPassword.Text,
                            textBoxName.Text, textBoxSurname.Text, textBoxMail.Text);
                        break;
                    case 2:
                        editedUser = DbUtils.AddUser("A", dbContext, textBoxLogin.Text, textBoxPassword.Text, 
                            textBoxName.Text, textBoxSurname.Text, textBoxMail.Text);
                        break;
                }
               
            }

            if(userSaved != null)
            {
                userSaved(this, e);
            }

            if(editedUser != null)
            {
                this.Close();
            }
            
        }

        private void readerComponents(bool isShow)
        {
            textBoxTel.Enabled = isShow;
            textBoxStreet.Enabled = isShow;
            textBoxStrNum.Enabled = isShow;
            textBoxApt.Enabled = isShow;
            textBoxCity.Enabled = isShow;
            textBoxPostal.Enabled = isShow;
        }

        private void initSpinner()
        {
            typeSpinner.Items.Add("User");
            typeSpinner.Items.Add("Librarian");
            typeSpinner.Items.Add("Admin");
        }

        private void initUser(User u)
        {
            textBoxLogin.Text = u.Login;
            textBoxPassword.Text = u.Password.Trim();
            textBoxMail.Text = u.E_Mail;
            textBoxName.Text = u.Name;
            textBoxSurname.Text = u.Surname;
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
