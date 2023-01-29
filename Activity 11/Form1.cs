using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Activity_11.Form1;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        public class Dice
        {
            //private field 
            private int numberOfSides;
            public int[] valuesOfSides;

            //public field
            public int faceValue;
            
            //Random init
            Random random= new Random();

            //Constructor that creates dice with number of sides
            public Dice(int NumberOfSides)
            {
                //check if die sides is in range
                if(NumberOfSides < 4 || NumberOfSides > 20)
                {
                    MessageBox.Show("Dice range is from 4-20.");
                }

                //returns private field numberOfSides
                this.numberOfSides = NumberOfSides;
                Console.WriteLine("Each die has " + NumberOfSides + " sides.");

                //make an array to represent sides of dice
                valuesOfSides = new int[NumberOfSides];

                //for loop to fill in values
                for(int i = 0; i < valuesOfSides.Length; i++)
                {
                    valuesOfSides[i] = random.Next(1, NumberOfSides);
                }
            }

            //to set dice 2 = to dice 1 sides
            public int SetNumberOfSides(Dice dice)
            {
                return dice.numberOfSides;
            }

            //Method to select random side (side = array position) to act as face value
            public int rollDie(Dice dice)
            {
                
                //int faceValue = random.Next(dice.numberOfSides);
                int faceValue = random.Next(dice.numberOfSides);
                Console.WriteLine("faceValue = " + faceValue);
                dice.faceValue = faceValue;
                return faceValue;
            } 

        }
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Dice leftDice = new Dice(4);
            Dice rightDice = new Dice(leftDice.SetNumberOfSides(leftDice));

            int counter = 0;

            do
            {
                leftDice.rollDie(leftDice);
                rightDice.rollDie(rightDice);

                Console.WriteLine("Dice 1 face value: " + leftDice.faceValue + "\nDice 2 face value: " + rightDice.faceValue);
                counter++;
            } while(leftDice.faceValue != 1 && rightDice.faceValue != 1);
            
            Console.WriteLine("You got Snake Eyes! It took " + counter);
        }

    }
}
