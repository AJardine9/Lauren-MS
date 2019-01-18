using System;
using System.Collections.Generic;
using System.Text;
using ord = PizzaStore.Domain.Models.Order;
using lo = PizzaStore.Domain.Models.Location;

namespace PizzaStore.Domain.Models.User
{
    public class User
    {
        #region Field
        public int UserId { get; set; }
        public string Username { get; private set; }
        public string Password { get; set; }
        public List<ord.Order> Orders { get; private set; }
        public Address LastLocationOrdered { get; private set; }
        public DateTime LastTimeOrdered { get; private set; }
        public ord.Order CurrentOrder { get; private set; }
        #endregion
        #region Constructor
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Orders = new List<ord.Order>();
            LastLocationOrdered = null;
            LastTimeOrdered = new DateTime();
            CurrentOrder = null;
        }
        #endregion
        #region Methods
        //public void AddOrder()
        //{
        //    if (CurrentOrder != null)
        //    {
        //        Orders.Add(CurrentOrder);
        //        LastLocationOrdered = CurrentOrder.LocationAddress;
        //        LastTimeOrdered = CurrentOrder.PurchaseTime;
        //        CurrentOrder = null;
        //    }
        //}

        public void CreateOrder()
        {
            CurrentOrder = new ord.Order(Username);
        }

        public void CancelOrder()
        {
            CurrentOrder = null;
        }
        #endregion
    }
}
