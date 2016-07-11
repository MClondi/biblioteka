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
    public partial class ReservationForm : Form
    {
        private Resource resource;
        private Reader reader;
        private User librarian;
        private LibraryDBContainer dbContext;

        public ReservationForm(LibraryDBContainer dbContext, Resource resource, Reader reader, User librarian)
        {
            this.resource = resource;
            this.reader = reader;
            this.librarian = librarian;
            this.dbContext = dbContext;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool reservationOk = false; 

            if (datePicker.Value < DateTime.Today)
            {
                MessageBox.Show("Data oddania powinna być późniejsza");
                return;
            }
            if (!DbUtils.IsResourceAvailable(dbContext, resource))
            {
                reservationOk = ReserveResource();
            }
            else
            {
                MessageBox.Show("Rezerwacja nieudana - zasób jest dostępny do wypożyczenia!", "Błąd");
                this.Close();
                return;
            }

            if (reservationOk)
                MessageBox.Show("Zarezerwowano zasób!", "Informacja");
            this.Close();
        }

        private bool ReserveResource()
        {
            if (!DbUtils.HasUserAlreadyReservedResource(dbContext, resource, reader) &&
                !DbUtils.HasUserAlreadyBorrowedResource(dbContext, resource, reader))
            {
                Reservation reservation = new Reservation();

                reservation.Reader = reader;
                reservation.Resource = resource;
                reservation.RealizationDate = datePicker.Value;
                reservation.ReservationDate = DateTime.Now;

                dbContext.Reservations.Add(reservation);
                dbContext.SaveChanges();
            }
            else if(DbUtils.HasUserAlreadyBorrowedResource(dbContext, resource, reader))
            {
                MessageBox.Show("Użytkownik już wypożyczył ten zasób!", "Błąd");
                return false;
            }
            else
            {
                MessageBox.Show("Użytkownik już zarezerwował ten zasób!", "Błąd");
                return false;
            }

            return true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
