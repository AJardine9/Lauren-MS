using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Size (int sizeId, string name, double price)
        {
            SizeId = sizeId;
            Name = name;
            Price = price;
        }
    }
}
