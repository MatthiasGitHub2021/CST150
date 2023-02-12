using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        InventoryManagerClass inventoryManagerClass = new InventoryManagerClass();

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            string one = TB_NameSearch.Text;
            string two = TB_DescriptionSearch.Text;

            inventoryManagerClass.searchItem(one, two);
        }
    }
}
