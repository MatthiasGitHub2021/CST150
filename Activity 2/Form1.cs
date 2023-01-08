using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //set fahr to farBox value as text
            string fahrenheit = fahrbox.Text;

            //set f as double from fahr string
            double f = double.Parse(fahrenheit);

            //set celsius = f with conversion calculations
            double celsius = (f - 32) * 5 / 9;

            //set celBox = celsius
            celBox.Text = celsius.ToString();
        }

        //clears boxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            fahrbox.Clear();
            celBox.Clear();
        }
    }
}
