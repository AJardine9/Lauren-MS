using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Location
{
    public class CrustInventory
    {
        public int CrustInventoryId { get; set; }
        public int LocationId { get; set; }
        public int CrustId { get; set; }
        public int Stock { get; set; }

        public CrustInventory(int crustId, int stock)
        {
            CrustId = crustId;
            Stock = stock;
        }
    }
}
