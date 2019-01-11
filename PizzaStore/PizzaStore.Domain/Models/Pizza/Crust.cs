using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Crust
    {
        public int CrustId { get; set; }
        public string Name { get; set; }

        public Crust()
        {
            Name = "Default Crust";
        }
    }
}
