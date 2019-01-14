using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Topping
    {
        public Topping()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
            ToppingInventory = new HashSet<ToppingInventory>();
        }

        public int ToppingId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DateModified { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
        public virtual ICollection<ToppingInventory> ToppingInventory { get; set; }
    }
}
