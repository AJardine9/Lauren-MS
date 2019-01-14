using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class SizeInventory
    {
        public int SizeInventoryId { get; set; }
        public int LocationId { get; set; }
        public int SizeId { get; set; }
        public int Stock { get; set; }

        public virtual Location Location { get; set; }
        public virtual Size Size { get; set; }
    }
}
