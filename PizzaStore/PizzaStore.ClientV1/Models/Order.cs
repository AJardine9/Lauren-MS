using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pi = PizzaStore.Domain.Models.Pizza;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.ClientV1.Models
{
    public class Order
    {
        [Required]
        public int OrderNumber { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string Username { get; set; }

        [Required]
        public double Total { get; set; }

        [Required]
        public DateTime PurchaseTime { get; set; }

        [Required]
        public List<pi.Pizza> Pizzas { get; set; }

        [Required]
        public string LocationAddress { get; set; }
    }
}
