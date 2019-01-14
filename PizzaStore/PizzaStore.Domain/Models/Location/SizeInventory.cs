using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Location
{
    public class SizeInventory
    {
        public int SizeInventoryId { get; set; }
        public int SizeId { get; set; }
        public int Stock { get; set; }

        public SizeInventory(int sizeId, int stock)
        {
            SizeId = sizeId;
            Stock = stock;
        }
    }
}
