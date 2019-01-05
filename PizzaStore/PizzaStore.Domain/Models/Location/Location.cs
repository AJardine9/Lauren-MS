using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using lo = PizzaStore.Domain.Models.Location;
using ord = PizzaStore.Domain.Models.Order;

namespace PizzaStore.Domain.Models.Location
{
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<us.User> Users { get; set; }
        //public List<Pizza> Inventory { get; set; }
        public List<ord.Order> Orders { get; set; }
        public int OrderNumber { get; set; }
    }
}
