using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    // Modify class declaration to implement IDisplayable
    public class InvItem : IDisplayable
    {
            public InvItem() { }

            public InvItem(int itemNo, string description, decimal price)
            {
                ItemNo = itemNo;
                Description = description;
                Price = price;
            }

            public int ItemNo { get; set; }
            public string Description { get; set; }
        public decimal Price { get; set; }


        // Uncomment and ensure the method signature is virtual string GetDisplayText()
        public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
        }
    }
