using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //set numbers textbox to variable
            string userEntry = tbUserInput.Text;

            //set userEntry as numerical
            int.TryParse(userEntry, out int entry);

            //seconds converter to minutes, hours, days
            if (entry < 60)
            {
                MessageBox.Show(entry + " seconds is " + entry + " seconds.");
            }
            else if (entry >= 60 && entry <= 3599)
            {
                MessageBox.Show(entry + " seconds is " + entry / 60 + " minutes.");
            }
            else if (entry >= 3600 && entry <= 85399)
            {
                MessageBox.Show(entry + " seconds is " + entry / 3600 + " hours.");
            }
            else if (entry >= 86400)
            {
                MessageBox.Show(entry + " seconds is " + entry / 86400 + " days.");
            }
        }
    }
}
