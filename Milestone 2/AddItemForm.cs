using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Matthias Peterson, my own work
namespace Milestone_2
{
    public partial class AddItemForm : Form
    {
        //link to DataTable Form1.cs
        DataTable dataTable;

        public AddItemForm(DataTable dataTable)
        {
            InitializeComponent();
            this.dataTable = dataTable;
        }

        //method to get data from AddItemForm.cs[Design] for new object
        private void getInventoryData(InventoryItemClass inventoryItem)
        {
                inventoryItem.name = TB_Name.Text.ToString();
                inventoryItem.price = double.Parse(TB_Price.Text);
                inventoryItem.category = TB_Category.Text.ToString();
                inventoryItem.description = TB_Description.Text.ToString();
                inventoryItem.quantity = int.Parse(TB_Quantity.Text);
        }

        public void BTN_Save_Click(object sender, EventArgs e)
        {
            //create new class object
            InventoryItemClass newItem = new InventoryItemClass();

            try
            {
                //data retrieved from AddForm.cs for new object
                getInventoryData(newItem);

                //Add row to dataTable and then add class
                DataRow dr = dataTable.NewRow();
                dr["Name"] = newItem.name;
                dr["Price"] = newItem.price;
                dr["Description"] = newItem.description;
                dr["Category"] = newItem.category;
                dr["Quantity"] = newItem.quantity;

                dataTable.Rows.Add(dr);

                //close the form
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        //autofill form
        private void BTN_Autofill_Click(object sender, EventArgs e)
        {
            TB_Name.Text = "John Doe";
            TB_Price.Text= "4.50";
            TB_Category.Text = "Food";
            TB_Description.Text = "Tacos";
            TB_Quantity.Text = "12";
        }

        //Used for editing, set TB's as values
        public void LoadEditData(string name, string price, string category, string description, string quantity)
        {
            TB_Name.Text = name;
            TB_Price.Text = price;
            TB_Category.Text = category;
            TB_Description.Text = description;
            TB_Quantity.Text = quantity;
        }
    }
}
