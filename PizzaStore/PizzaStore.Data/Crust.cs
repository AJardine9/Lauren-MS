﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Crust
    {
        public Crust()
        {
            Inventory = new HashSet<Inventory>();
            Pizza = new HashSet<Pizza>();
        }

        public int CrustId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
