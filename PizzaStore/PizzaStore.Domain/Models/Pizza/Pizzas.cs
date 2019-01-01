using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Pizzas<T> where T : APizza
    {
        public List<T> Pizzasa { get; set; }

        public Pizzas()
        {
            Pizzasa = new List<T>();
        }
    }
}
