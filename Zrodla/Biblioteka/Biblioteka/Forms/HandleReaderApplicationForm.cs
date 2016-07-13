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
    public partial class HandleReaderApplicationForm : Form
    {
        private ReaderApplication readerApplication;
        private LibraryDBContainer dbContext;
        Boolean help = false;
        public HandleReaderApplicationForm(LibraryDBContainer dbContext, ReaderApplication readerApplication)
        {
            this.dbContext = dbContext;
            this.readerApplication = readerApplication;
            InitializeComponent();
            PopulateData();
        }

        private void PopulateData()
        {
            User oldUser = readerApplication.Reader.User; 
            oldName.Text = oldUser.Name;
            oldSurname.Text = oldUser.Surname;
            oldPhone.Text = oldUser.Reader.PhoneNumber;
            oldStreet.Text = oldUser.Reader.Street;
            oldStreetNumber.Text = oldUser.Reader.HouseNumber;
            oldApartament.Text = oldUser.Reader.ApartmentNumber;
            oldCity.Text = oldUser.Reader.City;
            oldPostal.Text = oldUser.Reader.PostalCode;

            newName.Text = readerApplication.ApplicationData.FirstOrDefault().Name;
            newSurname.Text = readerApplication.ApplicationData.FirstOrDefault().Surname;
            newPhone.Text = readerApplication.ApplicationData.FirstOrDefault().PhoneNumber;
            newStreet.Text = readerApplication.ApplicationData.FirstOrDefault().Street;
            newStreetNumber.Text = readerApplication.ApplicationData.FirstOrDefault().HouseNumber;
            newApartament.Text = readerApplication.ApplicationData.FirstOrDefault().ApartmentNumber;
            newCity.Text = readerApplication.ApplicationData.FirstOrDefault().City;
            newPostal.Text = readerApplication.ApplicationData.FirstOrDefault().PostalCode;    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            readerApplication.Status = "O";
            dbContext.SaveChanges();
            MessageBox.Show("Wniosek odrzucony", "Informacja");
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            readerApplication.Status = "A";
            User user = readerApplication.Reader.User;

            user.Name = readerApplication.ApplicationData.FirstOrDefault().Name;
            user.Surname = readerApplication.ApplicationData.FirstOrDefault().Surname;
            user.Reader.PhoneNumber = readerApplication.ApplicationData.FirstOrDefault().PhoneNumber;
            user.Reader.Street = readerApplication.ApplicationData.FirstOrDefault().Street;
            user.Reader.HouseNumber = readerApplication.ApplicationData.FirstOrDefault().HouseNumber;
            user.Reader.ApartmentNumber = readerApplication.ApplicationData.FirstOrDefault().ApartmentNumber;
            user.Reader.City = readerApplication.ApplicationData.FirstOrDefault().City;
            user.Reader.PostalCode = readerApplication.ApplicationData.FirstOrDefault().PostalCode;
            dbContext.SaveChanges();
            MessageBox.Show("Wniosek zaakceptowany", "Informacja");
            this.Close();
        }

        private void oldCity_TextChanged(object sender, EventArgs e)
        {

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
