using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Crust
    {
        public Crust()
        {
            CrustInventory = new HashSet<CrustInventory>();
            Pizza = new HashSet<Pizza>();
        }

        public int CrustId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DateModified { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<CrustInventory> CrustInventory { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
