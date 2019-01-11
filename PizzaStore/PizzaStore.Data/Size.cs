using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Size
    {
        public int SizeId { get; set; }
        public string Name { get; set; }
        public int PizzaId { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
