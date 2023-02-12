using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Milestone_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Bind datagridview1 to inventoryItemsList step 2
            bs.DataSource = inventoryItemsList;
            RB_Off.Checked = true;
            //fillList();
        }

        //InvMan class init
        InventoryManagerClass inventoryManagerClass = new InventoryManagerClass();

        //List for items
        List<InventoryItem> inventoryItemsList = new List<InventoryItem>(); 


        //Bind datagridview1 to inventoryItemsList step 1
        BindingSource bs = new BindingSource();

        //Add
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            /*AddItemForm form = new AddItemForm(inventoryItemsList);
            form.Show(); */
            
            /*inventoryManagerClass.addItem(
                TB_Name.Text,
                TB_Description.Text,
                int.Parse(TB_Qty.Text),
                double.Parse(TB_Price.Text)); */
            
            inventoryItemsList.Add(new InventoryItem(
                TB_Name.Text, 
                TB_Description.Text, 
                int.Parse(TB_Qty.Text), 
                double.Parse(TB_Price.Text)));

            //Bind datagridview1 to inventoryItemsList last step
            dataGridView1.DataSource = bs;
            bs.ResetBindings(false);
            clearText();

        }

        //Delete button
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

        }

        //Autfill button for easy testing
        private void BTN_Autofill_Click(object sender, EventArgs e)
        {
            TB_Name.Text = "Mike";
            TB_Description.Text = "and Ike";
            TB_Qty.Text = "2";
            TB_Price.Text = "14.99";
        }

        //For editing item
        private void RB_Off_CheckedChanged(object sender, EventArgs e)
        {
            if(RB_On.Checked == true)
            {
                dataGridView1.Enabled= true;
            }
            else
            {
                dataGridView1.Enabled= false;
            }
        }
    
        //add some items to list
        private void fillList()
        {
            inventoryItemsList.Add(new InventoryItem("one", "one", 1, 1));
            inventoryItemsList.Add(new InventoryItem("two", "two", 2, 2));
            inventoryItemsList.Add(new InventoryItem("three", "three", 3, 3));
        }

        //Clear textboxes after clicking add button
        public void clearText()
        {
            TB_Name.Text = "";
            TB_Description.Text = "";
            TB_Qty.Text = ""; 
            TB_Price.Text = "";
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            Form form = new DisplayForm();
            form.Show();
        }

        private void BTN_Display_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                MessageBox.Show(item.SetValues().ToString());
               
            }
        }
    }
}