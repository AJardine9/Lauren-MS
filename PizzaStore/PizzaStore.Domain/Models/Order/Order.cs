using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Order
{
    public class Order
    {
        public int OrderNumber
        {
            get
            {
                return OrderNumber;
            }
            set
            {
                OrderNumber = value + 1;
            }
        }
        public us.User Customer { get; set; }
        public double Total { get; set; }
        public DateTime PurchaseTime { get; set; }
        public bool CanCancel { get; set; }


        public static readonly pi.Pizzas<pi.Pizza> PizzaOrders = new pi.Pizzas<pi.Pizza>();

        public Order()
        {
            //PizzaOrders.Pizzasa.Add(new pi.Pizza(typeof(T).Name));
        }

        #region Total
        public void AddToTotal(double value)
        {
            Total += value;
        }

        public void SubtractFromTotal(double value)
        {
            Total -= value;
        }
        #endregion
    }
}
