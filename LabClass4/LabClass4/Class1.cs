using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClass4
{
    internal class item
    {
        public int number { get; set; }
        public String date { get; set; }
        public int inventoryNumber { get; set; }
        public String itemName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public void Save(item item1)
        {
            Console.WriteLine("Date Saved!");
        }
    }
}
