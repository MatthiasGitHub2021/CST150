using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Milestone_4
{
    public class InventoryManagerClass
    {
        //List to hold inventoryItems
        List<InventoryItem> inventoryItemsList = new List<InventoryItem> ();

        public InventoryManagerClass()
        {
            inventoryItemsList.Add(new InventoryItem("one", "one", 1, 1));
            inventoryItemsList.Add(new InventoryItem("two", "two", 2, 2));
            inventoryItemsList.Add(new InventoryItem("three", "three", 3, 3));
        }
       
        //1.	Add a new item to the inventory manager.
        public void addItem(string name, string description, int quantity, double price)
        {
            inventoryItemsList.Add(new InventoryItem { Name = name, Description = description, Quantity = quantity, Price =price });    
        }

        //2.	Remove an item from the inventory.
        public void removeItem(int RemoveAt)
        {
            inventoryItemsList.RemoveAt(RemoveAt);
        }

        //3.	Restock an item in the inventory.
        public void restockItem(int index, int restockQty)
        {
            inventoryItemsList[index].Quantity = restockQty;
        }

        //4.	Display the items in the inventory.
        public void displayItem(int index)
        {
            Form form = new DisplayForm();
            form.Show(); 

            if(index == inventoryItemsList.Count)
            {
                /*string name = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[0].ToString();
                string price = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[1].ToString();
                string category = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[2].ToString();
                string description = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[3].ToString();
                string quantity = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[4].ToString(); */
            }
        }

        //5.	Search for an item/items in the inventory by a variety of criteria.
        public void searchItem(string name, string description)
        {
            for (int i = 0; i < inventoryItemsList.Count; i++)
            {
                if (inventoryItemsList[i].Name == name && inventoryItemsList[i].Description == description)
                {
                    Console.WriteLine("Item found:");
                    Console.WriteLine(
                        inventoryItemsList[i].Name,
                        inventoryItemsList[i].Description,
                        inventoryItemsList[i].Quantity,
                        inventoryItemsList[i].Price);

                    MessageBox.Show("Item found.");
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
            }
        }

        public void displayList()
        {
            for(int i = 0; i< inventoryItemsList.Count; i++)
            {
                Console.WriteLine(
                    inventoryItemsList[i].Name.ToString(),               
                    inventoryItemsList[i].Description.ToString(), 
                    inventoryItemsList[i].Quantity.ToString(),
                    inventoryItemsList[i].Price.ToString());
            }
        }

    }

    public class InventoryItem
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;

        public InventoryItem(string name, string description, int quantity, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;
        }

        public InventoryItem() { }

    }
}
