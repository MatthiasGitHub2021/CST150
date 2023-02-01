using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_12
{
    internal static class Program
    {
        /// Given a text file, write a program that counts the number of words that end with the letter 't' or 'e'
        [STAThread]
        static void Main()
        {
            //Get text file and put in string
            var textFromFile = System.IO.File.ReadAllText(@"C:\Users\matth\WorkspaceCST-150 C Sharp\Activity 12\text.txt");

            //Put string in array, utilize split
            String[] wordsArray = textFromFile.Split(' ');

            //Counter for return count of words
            int counter = 0;

            //Count words that end with a t or e
            foreach (var word in wordsArray)
            {
                if (word.EndsWith("e") || word.EndsWith("t"))
                {
                    counter++;
                }       
            }

            //Display results
            Console.WriteLine("There were " + counter + " words that ended with an 'e' or 't'.");
        }
    }
}
