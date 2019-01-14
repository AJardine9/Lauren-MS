using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Size
    {
        public Size()
        {
            Pizza = new HashSet<Pizza>();
            SizeInventory = new HashSet<SizeInventory>();
        }

        public int SizeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DateModified { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
        public virtual ICollection<SizeInventory> SizeInventory { get; set; }
    }
}
