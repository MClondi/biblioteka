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
    }
}
