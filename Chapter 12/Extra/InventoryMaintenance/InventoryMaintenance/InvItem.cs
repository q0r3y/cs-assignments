using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public InvItem()
        {
            ItemNo = 0;
            Description = "Flux Capacitor";
            Price = 88;
        }

        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public string GetDisplayText =>
            ItemNo + " " + Description + " (" + Price.ToString("c") + ")";
    }
}
