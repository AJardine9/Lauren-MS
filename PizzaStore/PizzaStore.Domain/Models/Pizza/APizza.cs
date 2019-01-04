using System.Collections.Generic;

namespace PizzaStore.Domain.Models.Pizza
{
    public class APizza
    {
        public string Crust { get; set; }
        public int Size { get; set; }
        public List<string> Toppings { get; set; }
        public double Price { get; set; }
    }
}
