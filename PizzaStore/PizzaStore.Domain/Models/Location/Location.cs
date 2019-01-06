using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using lo = PizzaStore.Domain.Models.Location;
using ord = PizzaStore.Domain.Models.Order;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Location
{
    public class Location
    {
        #region Field
        public int Id { get; set; }
        public string Address { get; set; }
        public List<us.User> Users { get; set; }
        public List<pi.EPizzaOptions> Inventory { get; set; }
        public List<ord.Order> Orders { get; set; }
        public int OrderNumber { get; set; }
        #endregion
        #region Constructor
        public Location(string address)
        {
            lo.Inventory inven = new lo.Inventory();
            Address = address;
            Users = new List<us.User>();
            Orders = new List<ord.Order>();
            Inventory = inven.Ingredients;
            OrderNumber = 0;
        }
        #endregion
    }
}
