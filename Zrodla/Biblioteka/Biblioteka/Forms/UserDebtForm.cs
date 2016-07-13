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
    public partial class UserDebtForm : Form
    {
        private LibraryDBContainer dbContext;
        private Reader reader;
        Boolean help = false;

        public UserDebtForm(LibraryDBContainer dbContext, Reader reader)
        {
            this.dbContext = dbContext;
            this.reader = reader;
            InitializeComponent();
            txtBoxDebt.Text = ((double) reader.Debt / 100).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            reader.Debt = 0;
            dbContext.SaveChanges();
            MessageBox.Show("Wpłacono karę", "Informacja");
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
