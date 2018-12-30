using System.Collections.Generic;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Pizza : APizza
    {
        public Pizza(string crust = "defaultCrust", int size = 0, List<string> toppings = null)
        {
            Crust = crust;
            Size = size;
            Toppings = toppings;
        }
    }
}
