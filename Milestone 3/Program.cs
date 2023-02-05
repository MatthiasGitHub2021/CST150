using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Matthias Peterson
//My own work.
namespace Milestone_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Init class
            InventoryManagerClass inventoryManagerClass = new InventoryManagerClass();
            
            //Display starting inventory array
            Console.WriteLine("Current inventory list: ");
            inventoryManagerClass.displayList();

            //Add item and print array again
            inventoryManagerClass.addNewItem("Four", "Green item", 7, 8.50);
            Console.WriteLine("After Item added:");
            inventoryManagerClass.displayList();

            //Remove item at index and print
            inventoryManagerClass.removeItem(2);
            Console.WriteLine("Removing object at index 2: ");
            inventoryManagerClass.displayList();

            //Restock an item (add to count)
            inventoryManagerClass.restockItem(0,200);
            Console.WriteLine("Added 200 items to index 0:");
            inventoryManagerClass.displayList();

            //Search for item with 2 parameters
            Console.WriteLine("Searching for 'Four' and 'Green item': ");
            inventoryManagerClass.searchCriteraTwo("Four", "Green item");

        }
    }
}
