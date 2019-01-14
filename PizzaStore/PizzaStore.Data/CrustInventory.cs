using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class CrustInventory
    {
        public int CrustInventoryId { get; set; }
        public int LocationId { get; set; }
        public int CrustId { get; set; }
        public int Stock { get; set; }

        public virtual Crust Crust { get; set; }
        public virtual Location Location { get; set; }
    }
}
