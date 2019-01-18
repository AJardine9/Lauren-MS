using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pi = PizzaStore.Domain.Models.Pizza;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Client.Models
{
    public class Pizza
    {
        [Required]
        public string Crust { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public List<string> Toppings { get; set; }
    }
}
