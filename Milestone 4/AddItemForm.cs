using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4
{
    public partial class AddItemForm : Form
    {
        
        public AddItemForm(List<InventoryItem> inventoryItems )
        {
            InitializeComponent();
        }

        //method to get data from AddItemForm.cs[Design] for new object
        private void getInventoryData(InventoryItem inventoryItem)
        {
            inventoryItem.Name = TB_Name.Text.ToString();
            inventoryItem.Price = double.Parse(TB_Price.Text);
            inventoryItem.Description = TB_Description.Text.ToString();
            inventoryItem.Quantity = int.Parse(TB_Qty.Text);
        }

        //Used for editing, set TB's as values
        public void LoadEditData(string name, string price, string description, string quantity)
        {
            TB_Name.Text = name;
            TB_Price.Text = price;
            TB_Description.Text = description;
            TB_Qty.Text = quantity;
        }
    }
}
