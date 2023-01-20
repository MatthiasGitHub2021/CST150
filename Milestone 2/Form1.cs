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
    public partial class InventoryListForm : Form
    {
        //Link GV_InventoryList to DataTable for DataSources
        public DataTable inventoryList = new DataTable();
       
        public InventoryListForm()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            //Open AddItemForm.cs
            AddItemForm addItemForm = new AddItemForm(inventoryList);
            addItemForm.Show();
        }
      
        public void InventoryListForm_Load(object sender, EventArgs e)
        {
            //Load column headers on start up
            inventoryList.Columns.Add("Name");
            inventoryList.Columns.Add("Price");
            inventoryList.Columns.Add("Category");
            inventoryList.Columns.Add("Description");
            inventoryList.Columns.Add("Quantity");

            //Cannot add directly to GV, have to use DataSource
            GV_InventoryList.DataSource = inventoryList;
        }

        public void BTN_Edit_Click(object sender, EventArgs e)
        {
            //Open AddItemForm.cs
            AddItemForm addItemForm = new AddItemForm(inventoryList);
            addItemForm.Show();
            
            //Strings for values
            string name = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[0].ToString();
            string price = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[1].ToString();
            string category = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[2].ToString();
            string description = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[3].ToString();
            string quantity = inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].ItemArray[4].ToString();

            //Send to function in AddItemForm.cs
            addItemForm.LoadEditData(name, price, category, description, quantity);

            //Deletes user highlighted row
            inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].Delete();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
                //Deletes user highlighted row
                inventoryList.Rows[GV_InventoryList.CurrentCell.RowIndex].Delete();
        }
    }
}
