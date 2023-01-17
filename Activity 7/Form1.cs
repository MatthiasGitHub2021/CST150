using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //  4-4/3+4/5-4/7+4/9   numer = 4, -, +, -, + denom = 1,+2,+2,+2
                double numerator = 4; //using division, use double not int 
                double denominator = 1;
                double result = 0; //should = pi 3.14172561463161
                //get # from input
                int numberOfTerms = int.Parse(tBInput.Text);

                //loop number of terms inputted
                for (int i = 0; i < numberOfTerms; i++)
                {
                    // divide num by den and set to result 
                    result += numerator / denominator;

                    // - + - + (switches sign each loop)
                    numerator = -numerator;

                    //add 2 to den each loop 
                    denominator = denominator + 2;
                }

                resultMessage.Text = "Approximate value of pi after " + numberOfTerms + " terms = " + result.ToString();
            
            }catch(Exception)
            {
                MessageBox.Show("Invalid entry");
            }
        }
    }
}
