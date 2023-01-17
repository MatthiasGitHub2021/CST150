using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class Form1 : Form
    {
        //open dialog control
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //filter for text docs only
            openFileDialog.Filter = ("Text Document (.txt) |*.txt");

            //write to text file
            using (StreamWriter writer = File.AppendText("Activity 5 results.txt"))
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //array to store words from file
                    var filelocation = System.IO.File.ReadAllLines(openFileDialog.FileName);

                    //array for lines
                    List<string> lines = new List<string>(filelocation);

                    //Lowercase message
                    tBResponse.AppendText("Lower-case:\r\n");

                    for (int i = 0; i < lines.Count; i++)
                    {
                        //lowercase response
                        tBResponse.AppendText(lines[i].ToString().ToLower() + "\r\n");
                        //append lower case to file
                        writer.WriteLine(lines[i].ToString());
                    }

                    //Sort array and grab top
                    lines.Sort();
                    tBResponse.AppendText("\r\nFirst Word Alphabetically:\r\n" + lines[0].ToString());

                    //append first to file
                    writer.WriteLine(lines[0].ToString());

                    //Grab last
                    tBResponse.AppendText("\r\nLast Word Alphabetically:\r\n" + lines.Last().ToString());

                    //append last to file
                    writer.WriteLine(lines.Last().ToString());

                    //Sort descending, grab top
                    string longest = lines.OrderByDescending(l => l.Length).First();
                    tBResponse.AppendText("\r\nLongest Word Alphabetically:\r\n" + longest);

                    //append longest to file
                    writer.WriteLine(longest);

                    //counter var for most vowels
                    int vowelCount = 0;

                    //string var for result
                    string mostVowels = "";

                    //loops lines array
                    for (int i = 0; i < lines.Count; i++)
                    {
                        //count for vowels
                        int vowels = 0;

                        //loops letters as j, j = a vowel word with a count
                        for (int j = 0; j < lines[i].Length; j++)
                        {
                            if (lines[i][j] == 'a' ||
                                lines[i][j] == 'e' ||
                                lines[i][j] == 'i' ||
                                lines[i][j] == 'o' ||
                                lines[i][j] == 'u')
                            {
                                //each time vowel is found, ++
                                vowels++;
                            }
                        }
                        if (vowels > vowelCount)
                        {
                            vowelCount = vowels;
                            //i that has the most vowels, sets = to mostVowels
                            mostVowels = lines[i];
                        }
                    }
                    //Most vowels response
                    tBResponse.AppendText("\r\nMost Vowels Word:\r\n" + mostVowels);

                    //append to file
                    writer.WriteLine(mostVowels);
                }
            }
            
        }

    }
}
