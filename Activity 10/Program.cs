using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Corrected by Matthias Peterson

//A set is a collection of like elements that does not contain any duplicates.
//The union of two sets is the set that contains all the elements in both sets. 
//Example: A = {1,2,3,4,5} and B = {2,4,6,8}, then A union B = {1,2,3,4,5,6,8} (notice, no duplicates!)

namespace Activity_10
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();
            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            //display each set and the union
            Console.WriteLine("Before union operation:");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));
            //display original sets (should be unchanged)
            Console.WriteLine("After union operation:");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}

class Set
{
    private List<int> elements;

    //Set = List w no dups
    public Set()
    {
        elements = new List<int>();
    }

    public bool addElement(int val)
    {
        //List has Contains method already
        //if (containsElement(val)) 
        if (elements.Contains(val))
            return false;
        else
        {
            elements.Add(val);
            return true;
        }
    }

    private bool containsElement(int val)
    {
        for (int i = 0; i < elements.Count; i++)
        {
            if (val == elements[i])
                return true;
            else
                return false;
        }
        return false;
    }
    public override string ToString()
    {
        string str = "";
        foreach (int i in elements)
        {
            str += i + " ";
        }
        return str;
    }
    public void clearSet()
    {
        elements.Clear();
    }
    
    //A.union(B) B = rhs A = elements 
    public Set union(Set rhs)
    {
        //New set to return results
        Set resultsOfUnion= new Set();

        //Move elements (A) to resultsOfUnion using addElement (modified)
        foreach (int i in elements)
        {
            resultsOfUnion.addElement(i);
        }

        for (int i = 0; i < rhs.elements.Count; i++)
        {
            //Move rhs (B) to resultsOfUnion using addElement (modified)
            //this.addElement(rhs.elements[i]);
            resultsOfUnion.addElement(rhs.elements[i]);
        } 
 
        //Need to return new Set
        //return rhs;
        return resultsOfUnion;
    }
}