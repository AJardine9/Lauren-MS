using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Location
{
    public class ToppingInventory
    {
        public int ToppingInventoryId { get; set; }
        public int ToppingId { get; set; }
        public int Stock { get; set; }

        public ToppingInventory(int toppingId, int stock)
        {
            ToppingId = toppingId;
            Stock = stock;
        }
    }
}
