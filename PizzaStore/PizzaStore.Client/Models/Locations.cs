using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaStore.Domain.Models;
using us = PizzaStore.Domain.Models.User;
using ord = PizzaStore.Domain.Models.Order;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Client.Models
{
    public class Locations
    {
        [Required]
        public Address Address { get; set; }

        public List<us.User> Users { get; set; }
        //public List<pi.Crust> Inventory { get; set; }

        public List<ord.Order> Orders { get; set; }

        public int OrderNumber { get; set; }
    }
}
