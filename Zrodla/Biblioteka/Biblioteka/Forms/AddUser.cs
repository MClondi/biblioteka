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
        bool editingUser = false;

        public AddUser(bool hideTypeSpinner)
        {
            InitializeComponent();
            if (hideTypeSpinner)
            {
                typeSpinner.Hide();
                label11.Hide();
            }
            else
            {
                initSpinner();
                readerComponents(true);
            }
        }

        public AddUser(User u)
        {
            InitializeComponent();
            editingUser = true;
            initSpinner();
            switch (u.Type)
            {
                case "A":
                    typeSpinner.SelectedIndex = 2;
                    readerComponents(false);
                    initUser(u);
                    break;
                case "L":
                    typeSpinner.SelectedIndex = 1;
                    readerComponents(false);
                    initUser(u);
                    break;
                case "U":
                    typeSpinner.SelectedIndex = 0;
                    initUser(u);
                    textBoxTel.Text = u.Reader.PhoneNumber;
                    textBoxStreet.Text = u.Reader.Street;
                    textBoxStrNum.Text = u.Reader.HouseNumber;
                    textBoxApt.Text = u.Reader.ApartmentNumber;
                    textBoxCity.Text = u.Reader.City;
                    textBoxPostal.Text = u.Reader.PostalCode;
                    break;
            }

        }

        private void readerComponents(bool isShow)
        {
            textBoxLogin.Enabled = isShow;
            textBoxPassword.Enabled = isShow;
            textBoxPassword.PasswordChar = '*';
            textBoxMail.Enabled = isShow;
            textBoxName.Enabled = isShow;
            textBoxSurname.Enabled = isShow;
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
            textBoxPassword.Text = u.Password;
            textBoxMail.Text = u.E_Mail;
            textBoxName.Text = u.Name;
            textBoxSurname.Text = u.Surname;
        }

        private void typeSpinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeSpinner.SelectedIndex == 0)
            {
                readerComponents(true);
            }
            else
            {
                readerComponents(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool checkString(string toCheck)
        {
            return string.IsNullOrWhiteSpace(toCheck);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkString(textBoxLogin.Text) || checkString(textBoxPassword.Text) || checkString(textBoxMail.Text) || checkString(textBoxName.Text) ||
                checkString(textBoxSurname.Text))
            {
                MessageBox.Show("Pola: Login, Haslo, Email, Imie, Nazwisko nie moga byc puste!");
                return;
            }
            else

            {
                using (var db = new LibraryDBContainer())
                {
                    var query = from u in db.Users
                                where u.Login.Equals(textBoxLogin.Text)
                                select u;
                    if (query.ToList().Count > 0)
                    {
                        MessageBox.Show("Użytkownik o podanym loginie istnieje!");
                        return;
                    }
                    query = from u in db.Users
                                where u.E_Mail.Equals(textBoxMail.Text)
                                select u;
                    if (query.ToList().Count > 0)
                    {
                        MessageBox.Show("Użytkownik o podanym adresie email istnieje!");
                        return;
                    }
                    else
                    {
                        var newUser = new User
                        {
                            Login = textBoxLogin.Text,
                            Password = textBoxPassword.Text,
                            Name = textBoxName.Text,
                            Surname = textBoxSurname.Text,
                            Type = "U",
                            E_Mail = textBoxMail.Text
                        };
                        db.Users.Add(newUser);
                        var newReader = new Reader
                        {
                            PhoneNumber = textBoxTel.Text,
                            Street = textBoxStreet.Text,
                            HouseNumber = textBoxStrNum.Text,
                            ApartmentNumber = textBoxApt.Text,
                            City = textBoxCity.Text,
                            PostalCode = textBoxPostal.Text,
                            Debt = 0,
                            User = newUser
                        };
                        db.Readers.Add(newReader);
                        db.SaveChanges();
                        this.Hide();
                    }
                }
            }
        }
    }
}
