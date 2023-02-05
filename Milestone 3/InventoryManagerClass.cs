using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Milestone_3
{
    internal class InventoryManagerClass
    {
        //Array to hold items
        InventoryItem[] inventoryArray = new InventoryItem[10];

        //Int var to stop loops. Stop at this not array.length/size
        int ArrayStopIndex = 0;

        //start array with some items
        public InventoryManagerClass() 
        {
            inventoryArray[0] = new InventoryItem("One", "Red item", 3, 1.50);
            inventoryArray[1] = new InventoryItem("Two", "Blue item", 4, 10.50);
            inventoryArray[2] = new InventoryItem("Three", "White item", 6, 19.50);

            //Index for NPEs
            ArrayStopIndex = 3;
        }

        //1.	Add a new item to the inventory manager.
        public void addNewItem(string name, string description, int count, double price)
        {
            inventoryArray[ArrayStopIndex] = new InventoryItem(name, description, count, price);
            //marker for displayList() NPE
            ArrayStopIndex++;
        }

        //2.	Remove an item from the inventory manager.
        public InventoryItem[] removeItem(int RemoveAt)
        {
            //Make return array = to old array
            InventoryItem[] newArray = inventoryArray;

            int i = 0;
            int j = 0;

            while (i < ArrayStopIndex)
            {
                //While not at index to be removed, copy into new array
                if(i != RemoveAt)
                {
                    newArray[j] = inventoryArray[i];
                    j++;
                }
                i++;
            }
            
            //Change marker
            ArrayStopIndex--;
            return newArray;
        }

        //3.	Re-stock an item in the inventory manager.
        public void restockItem(int itemIndex, int quantity)
        {
            //Get count += quantity
            inventoryArray[itemIndex].Count += quantity;
        }

        //4.	Display the items in the inventory manager.
        public void displayList()
        {

             for(int i =0; i < ArrayStopIndex; i++)
             {
                Console.WriteLine(
                    inventoryArray[i].Name + ", " + 
                    inventoryArray[i].Description + ", " + 
                    inventoryArray[i].Count + ", " +
                    inventoryArray[i].Price + "");
             }
             Console.WriteLine("\n");
        }

        //5.	Search for an item in the inventory manager by at least two criteria(name, price, quantity, etc.).
        public void searchCriteraTwo(string name, string description)
        {

            for (int i = 0; i < ArrayStopIndex; i++)
            {
                if (inventoryArray[i].Name == name && inventoryArray[i].Description == description)
                {
                    Console.WriteLine("Item found:");
                    Console.WriteLine(
                        inventoryArray[i].Name + ", " +
                        inventoryArray[i].Description + ", " +
                        inventoryArray[i].Count + ", " +
                        inventoryArray[i].Price + "");
                }
            }
        }

    }
}
