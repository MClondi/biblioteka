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
            if (DbUtils.IsResourceBorrowed(dbContext, resource) && !DbUtils.IsResourceReserved(dbContext, resource))
            {
                ReserveResource();
            }
            else
            {
                MessageBox.Show("Rezerwacja nieudana (zasób jest już zarezerwowany lub dostępny do wypożyczenia)!", "Błąd");
                return;
            }

            MessageBox.Show("Zarezerwowano zasób!", "Informacja");
            this.Close();
        }

        private void ReserveResource()
        {
            Reservation reservation = new Reservation();

            reservation.Reader = reader;
            reservation.Resource = resource; 
            reservation.RealizationDate = datePicker.Value;

            dbContext.Reservations.Add(reservation);
            dbContext.SaveChanges();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
