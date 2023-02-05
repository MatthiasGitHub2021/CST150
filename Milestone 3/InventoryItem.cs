using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Milestone_3
{
    internal class InventoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public InventoryItem(string name, string description, int count, double price) 
        {
            Name = name;
            Description = description;
            Count = count;
            Price = price;
        }
    }
}
