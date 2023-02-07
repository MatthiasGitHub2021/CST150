using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On form load, fill in birth year box with 100 years
            for (int i = 2023; i >= 1923; i--)
            {
                CB_Year.Items.Add(i);
            }

            //On form load, fill in month box
            for (int i = 1; i <= 12; i++)
            {
                CB_Month.Items.Add(i);
            }
        }

        private void CB_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear CB_Day box when month is changed
            CB_Day.Text = "";

            //When month is selected, fill in CB_Day accordingly
            int month = int.Parse(CB_Month.Text);
            switch (month)
            {
                case 1:
                    thirtyOneDays();
                    break;
                case 2:
                    february();
                    break;
                case 3:
                    thirtyOneDays();
                    break;
                case 4:
                    thirtyDays();
                    break;
                case 5:
                    thirtyOneDays();
                    break;
                case 6:
                    thirtyDays();
                    break;
                case 7:
                    thirtyOneDays();
                    break;
                case 8:
                    thirtyOneDays();
                    break;
                case 9:
                    thirtyDays();
                    break;
                case 10:
                    thirtyOneDays();
                    break;
                case 11:
                    thirtyDays();
                    break;
                case 12:
                    thirtyOneDays();
                    break;
            }
        }

        private void thirtyOneDays()
        {
            //Clear CB_Day or appends each choice
            CB_Day.Items.Clear();
            //Loop to fill CB_Day with 31
            for (int i = 1; i <= 31; i++)
            {
                CB_Day.Items.Add(i);
            }
        }

        private void thirtyDays()
        {
            //Clear CB_Day or appends each choice
            CB_Day.Items.Clear();
            //Loop to fill CB_Day with 31
            for (int i = 1; i <= 30; i++)
            {
                CB_Day.Items.Add(i);
            }
        }

        private void february()
        {
            //Clear CB_Day else appends each choice
            CB_Day.Items.Clear();

            var year = DateTime.IsLeapYear(int.Parse(CB_Year.Text));
            if(year == true)
            {
                //if leap year add 29 to CD_Day
                for (int i = 1; i <= 29; i++)
                {
                    CB_Day.Items.Add(i);
                }
            }
            else
            {
                //if nonleap add 28 to CD_Day
                for (int i = 1; i <= 28; i++)
                {
                    CB_Day.Items.Add(i);
                }
            }
        }

        private void CB_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Month.Text = "";
            CB_Day.Text = "";
            //Clear CB_Day else appends each choice
            CB_Day.Items.Clear();
        }

        public void BTN_Lucky_Click(object sender, EventArgs e)
        {
            new Results().Show();
        }
    }
}
