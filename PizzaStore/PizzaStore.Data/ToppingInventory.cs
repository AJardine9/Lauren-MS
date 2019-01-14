using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class ToppingInventory
    {
        public int ToppingInventoryId { get; set; }
        public int LocationId { get; set; }
        public int ToppingId { get; set; }
        public int Stock { get; set; }

        public virtual Location Location { get; set; }
        public virtual Topping Topping { get; set; }
    }
}
