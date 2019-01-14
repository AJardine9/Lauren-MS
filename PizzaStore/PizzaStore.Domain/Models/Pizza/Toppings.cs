using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Toppings
    {
        public int ToppingId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Toppings(int toppingId, string name, double price)
        {
            ToppingId = toppingId;
            Name = name;
            Price = price;
        }
    }
}
