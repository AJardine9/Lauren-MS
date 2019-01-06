using System;
using System.Collections.Generic;
using System.Text;
using ord = PizzaStore.Domain.Models.Order;

namespace PizzaStore.Domain.Models.User
{
    public class User
    {
        #region Field
        public int Id { get; set; }
        public string Username { get; private set; }
        private string Password { get; set; }

        public List<ord.Order> Orders { get; private set; }
        public string LastLocationOrdered { get; private set; }
        public DateTime LastTimeOrdered { get; private set; }
        public ord.Order CurrentOrder { get; private set; }
        #endregion
        #region Constructor
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Orders = new List<ord.Order>();
            LastLocationOrdered = "No Previous Orders";
            LastTimeOrdered = new DateTime();
            CurrentOrder = null;
        }
        #endregion
        #region Methods
        public void AddOrder()
        {
            if (CurrentOrder != null)
            {
                ord.Order order = DeepCopy();
                Orders.Add(order);
                LastLocationOrdered = CurrentOrder.LocationAddress;
                LastTimeOrdered = CurrentOrder.PurchaseTime;
            }
            CurrentOrder = null;
        }

        public void CreateOrder(int orderNumber, string address)
        {
            CurrentOrder = new ord.Order(Username, orderNumber, address);
        }

        public void CancelOrder()
        {
            CurrentOrder = null;
        }

        public ord.Order DeepCopy()
        {
            ord.Order orderCopy = (ord.Order)this.MemberwiseClone();
            orderCopy.Id = CurrentOrder.Id;
            orderCopy.OrderNumber = CurrentOrder.OrderNumber;
            orderCopy.Username = CurrentOrder.Username;
            orderCopy.Total = CurrentOrder.Total;
            orderCopy.PurchaseTime = CurrentOrder.PurchaseTime;
            orderCopy.Pizzas = CurrentOrder.Pizzas;
            orderCopy.LocationAddress = CurrentOrder.LocationAddress;

            return orderCopy;
        }
        #endregion
    }
}
