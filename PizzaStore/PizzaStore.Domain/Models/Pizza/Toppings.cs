using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Toppings
    {
        public int ToppingId { get; set; }
        public string Name { get; set; }

        public Toppings()
        {
            Name = "Default Topping";
        }
    }
}
