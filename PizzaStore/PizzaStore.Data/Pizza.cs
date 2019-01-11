﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Pizza
    {
        public int PizzaId { get; set; }
        public int OrderId { get; set; }
        public int CrustId { get; set; }
        public int SizeId { get; set; }
        public int ToppingId { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual Crust Crust { get; set; }
        public virtual Order Order { get; set; }
        public virtual Size Size { get; set; }
        public virtual Topping Topping { get; set; }
    }
}
