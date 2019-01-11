using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int LocationId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Name { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
