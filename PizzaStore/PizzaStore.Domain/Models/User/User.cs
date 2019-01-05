using System;
using System.Collections.Generic;
using System.Text;
using ord = PizzaStore.Domain.Models.Order;

namespace PizzaStore.Domain.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<ord.Order> Orders { get; set; }
    }
}
