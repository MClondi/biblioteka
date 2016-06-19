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
    public partial class BorrowedResources : Form
    {
        private List<String> initList = new List<string>();
        Boolean help;

        public BorrowedResources()
        {
            InitializeComponent();
        }

        public void addItem(String s)
        {
            initList.Add(s);
        }

        public void initialize()
        {
            if (initList.Count == 0)
            {
                listView1.Items.Add("Brak wypożyczonych rzeczy.");
            }
            else
            {
                foreach (String s in initList)
                {
                    listView1.Items.Add(s);
                }
            }
           
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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
