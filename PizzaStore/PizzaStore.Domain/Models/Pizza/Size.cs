using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Name { get; set; }

        public Size ()
        {
            Name = "Default Size";
        }
    }
}
