﻿using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using lo = PizzaStore.Domain.Models.Location;
using ord = PizzaStore.Domain.Models.Order;
using pi = PizzaStore.Domain.Models.Pizza;
using ac = PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Models.Location
{
    public class Location
    {
        #region Field
        public int LocationId { get; set; }
        public Address Address { get; set; }
        public List<us.User> Users { get; set; }
        //public List<pi.Crust> Inventory { get; set; }
        public List<ord.Order> Orders { get; set; }
        public int OrderNumber { get; set; }
        #endregion
        #region Constructor
        public Location(Address address)
        {
            Address = address;
            Users = new List<us.User>();
            Orders = new List<ord.Order>();
            //Inventory = inven.Ingredients;
            OrderNumber = 0;
        }
        #endregion
        //#region Methods
        //public void OrderMadeAtLocation(ord.Order order)
        //{
        //    if(Users.Find(user => user.Username == order.Username) == null)
        //    {

        //    }
        //}

        //public void DisplayAvailableCrusts()
        //{

        //}

        //public void DisplayAvailableSizes()
        //{

        //}
        //#endregion
    }
}
