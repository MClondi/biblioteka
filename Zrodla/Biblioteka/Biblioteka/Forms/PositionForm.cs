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
    public partial class PositionForm : Form
    {
        LibraryDBContainer dbContext;
        public event EventHandler<List<Position>> searchClicked;
        Boolean help = false;

        public PositionForm(LibraryDBContainer dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            InitSpinner();
        }

        private void InitSpinner()
        {
            typeSpinner.Items.Add("Książka");
            typeSpinner.Items.Add("Gra");
            typeSpinner.Items.Add("Magazyn");
            typeSpinner.SelectedIndex = 0;
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
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
