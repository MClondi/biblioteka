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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // add or edit user
        }



    }
}
