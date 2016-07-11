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
    public partial class ReaderApplicationForm : Form
    {

        LibraryDBContainer dbContext;
        Reader user;
        Boolean help;

        public ReaderApplicationForm(Reader u, LibraryDBContainer dbContext)
        {
            InitializeComponent();
            this.user = u;
            this.dbContext = dbContext;
            textBoxName.Text = u.User.Name;
            textBoxSurname.Text = u.User.Surname;
            textBoxTel.Text = u.PhoneNumber;
            textBoxStreet.Text = u.Street;
            textBoxStrNum.Text = u.HouseNumber;
            textBoxApt.Text = u.ApartmentNumber;
            textBoxCity.Text = u.City;
            textBoxPostal.Text = u.PostalCode;
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Count() == 0 || textBoxSurname.Text.Count() == 0 || textBoxTel.Text.Count() == 0 || textBoxStreet.Text.Count() == 0 || textBoxStrNum.Text.Count() == 0 || textBoxCity.Text.Count() == 0 ||  textBoxPostal.Text.Count() == 0 )
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione");
                return;
            }
            if (!textBoxTel.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Telefon może zawierać tylko cyfry");
                return;
            }
            if (!textBoxPostal.Text.All(x => Char.IsDigit(x) || x == '-'))
            {
                MessageBox.Show("Nieprawidłowy kod pocztowy");
                return;
            }

            var applicationData = new ReaderApplicationData
            {
                Name =  textBoxName.Text,
                Surname = textBoxSurname.Text,
                PhoneNumber = textBoxTel.Text, 
                Street = textBoxStreet.Text,
                HouseNumber = textBoxStrNum.Text,
                ApartmentNumber = textBoxApt.Text,
                City = textBoxCity.Text,
                PostalCode = textBoxPostal.Text
            };

            var application = new ReaderApplication
            {
                ApplicationDate = DateTime.Now
            };

            application.ApplicationData.Add(applicationData);
            user.Application.Add(application);
            dbContext.SaveChanges();
            MessageBox.Show("Wysłano wniosek");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
