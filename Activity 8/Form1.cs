using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //when button is pushed
        private void bCalculate_Click(object sender, EventArgs e)
        {
            //try/catch for invalid entry
            try
            {
                //var for user entry
                double userInput = double.Parse(UserInput.Text);

                //execute these methods with parameter 'userInput'
                FatCalories(userInput);
                CarbCalories(userInput);

            }catch(Exception ex){MessageBox.Show(ex.Message);}
        }

        //accept parameter and change parameter with formula Calories from fat = Fat Grams * 9
        private double FatCalories(double userInput)
        {
            //takes param and applies formula
            userInput = userInput * 9;
            //set text box to results
            FatResults.Text = userInput.ToString();
            //return results after calculations
            return userInput;
        }

        //accept parameter and change parameter with formula Calories from carbs  = Fat Grams * 4
        private double CarbCalories(double userInput)
        {
            //takes param and applies formula
            userInput = userInput * 4;
            //set text box to results
            CarbResults.Text = userInput.ToString();
            //return results after calculations
            return userInput;
        }

        //clear boxes
        private void bClear_Click(object sender, EventArgs e)
        {
            UserInput.Clear();
            FatResults.Clear();
            CarbResults.Clear();
        }
    }
}
