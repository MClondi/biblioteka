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
    public partial class ResourceOrUserForm : Form
    {
        public bool Choice { get; set; }
        Boolean help = false;
        public ResourceOrUserForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Choice = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choice = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
