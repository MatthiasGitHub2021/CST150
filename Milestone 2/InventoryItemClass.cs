using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthias Peterson, my own work
namespace Milestone_2
{
    internal class InventoryItemClass
    {
        //constructor
        public InventoryItemClass() {
        }

        //getters/setters
        public string name { get; set; }
        public double price { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }

    }
}
