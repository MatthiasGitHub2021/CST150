using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }
        
        //Listbox item selected
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Empties Radio Buttons, Checkboxes and LB_Details
            resetEverything();

            //Enable Radio Buttons and Checkboxes
            enableRadioButtonsandCheckboxes();

            //Time zones
            DateTime Wisconsin = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"));
            DateTime Hawaii = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Hawaiian Standard Time"));
            DateTime Cali = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"));
            DateTime Utah = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time"));
            DateTime NewYork = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
   
            //When item is selected from ListBox
            if (LB_Friends.SelectedItem.ToString() == "Chris/Darbie")
            {
                TB_TimeDisplay.Text = Wisconsin.ToString();
            } 
            else if (LB_Friends.SelectedItem.ToString() == "Dustin/Katey")
            {
                TB_TimeDisplay.Text = Hawaii.ToString();
            }
            else if (LB_Friends.SelectedItem.ToString() == "Aunt Sam")
            {
                TB_TimeDisplay.Text = Cali.ToString();
            }
            else if (LB_Friends.SelectedItem.ToString() == "Mark/Misty")
            {
                TB_TimeDisplay.Text = Utah.ToString();
            }
            else if (LB_Friends.SelectedItem.ToString() == "Dave")
            {
                TB_TimeDisplay.Text = NewYork.ToString();
            }
        }

        //Radio Button for military time
        private void RB_Yes_CheckedChanged(object sender, EventArgs e)
        {
            String s = TB_TimeDisplay.Text;
            DateTime dateTime = DateTime.Parse(s);

            //change TB format HH = miltary time
            TB_TimeDisplay.Text = dateTime.ToString("M/d/yyyy HH:mm:ss");
        }

        //Radio Button for military time
        private void RB_No_CheckedChanged(object sender, EventArgs e)
        {
            String s = TB_TimeDisplay.Text;
            DateTime dateTime = DateTime.Parse(s);

            //change TB format hh = standard time, tt = AM/PM
            TB_TimeDisplay.Text = dateTime.ToString("M/d/yyyy hh:mm:ss tt");
        }

        //When CB_State is changed
        private void CB_State_CheckedChanged(object sender, EventArgs e)
        {
            if (LB_Friends.SelectedItem.ToString() == "Chris/Darbie")
            {
                LB_Details.Items.Add("Wisconsin");
            }
            else if (LB_Friends.SelectedItem.ToString() == "Dustin/Katey")
            {
                LB_Details.Items.Add("Hawaii");
            }
            else if (LB_Friends.SelectedItem.ToString() == "Aunt Sam")
            {
                LB_Details.Items.Add("California");       
            }
            else if (LB_Friends.SelectedItem.ToString() == "Mark/Misty")
            {
                LB_Details.Items.Add("Utah");
            }
            else if (LB_Friends.SelectedItem.ToString() == "Dave")
            {
                LB_Details.Items.Add("New York");
            } 
        }

        //When CB_TZ is changed
        private void CB_TZ_Checked(object sender, EventArgs e)
        {
            if (LB_Friends.SelectedItem.ToString() == "Chris/Darbie")
            {
                LB_Details.Items.Add("Central Standard Time");
            }
            else if (LB_Friends.SelectedItem.ToString() == "Dustin/Katey")
            {
                LB_Details.Items.Add("Hawaiian Standard Time");
            }
            else if (LB_Friends.SelectedItem.ToString() == "Aunt Sam")
            {
                LB_Details.Items.Add("Pacific Standard Time");
            }
            else if (LB_Friends.SelectedItem.ToString() == "Mark/Misty")
            {
                LB_Details.Items.Add("Mountain Standard Time");
            }
            else if (LB_Friends.SelectedItem.ToString() == "Dave")
            {
                LB_Details.Items.Add("Eastern Standard Time");
            }
        }
        
        //Method to clear boxes every selection
        private void resetEverything()
        {
            //Make Radio buttons unselected for each selection
            RB_Yes.Checked = false;
            RB_No.Checked = false;

            //Uncheck checkboxes
            CB_State.Checked = false;
            CB_TZ.Checked = false;

            //Empties LB_Details
            LB_Details.Items.Clear();
        }
        
        //Enable radio buttons and checkboxes after user selects item from listbox
        private void enableRadioButtonsandCheckboxes()
        {
            //radio buttons
            RB_Yes.Enabled = true;
            RB_No.Enabled = true;

            //checkboxes
            CB_State.Enabled = true;
            CB_TZ.Enabled = true;
        }

        //Close application BTN
        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
