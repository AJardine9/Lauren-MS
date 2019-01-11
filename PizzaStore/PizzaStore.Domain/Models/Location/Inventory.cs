using System;
using System.Collections.Generic;
using System.Text;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Location
{
    public class Inventory
    {
        public pi.Crust crust { get; set; }
        public pi.Size size { get; set; }
        public pi.Toppings toppings { get; set; }
    }
}
