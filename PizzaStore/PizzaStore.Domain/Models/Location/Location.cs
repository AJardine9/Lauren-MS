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
        public string Address { get; set; }
        public List<us.User> Users { get; set; }
        public List<Inventory> Inventories { get; set; }
        public List<ord.Order> Orders { get; set; }
    }

    #region Address
    #endregion
    #region Users
    #endregion
    #region Inventories
    #endregion
    #region Orders
    #endregion
}
