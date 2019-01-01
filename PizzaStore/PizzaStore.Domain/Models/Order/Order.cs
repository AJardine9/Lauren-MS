using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Order
{
    public class Order<T>
    {
        public int OrderNumber { get; set; }
        public us.User Customer { get; set; }
        public double Total { get; set; }
        public DateTime PurchaseTime { get; set; }

        public static readonly pi.Pizzas<pi.Pizza> PizzaOrders = new pi.Pizzas<pi.Pizza>();

        public Order()
        {
            PizzaOrders.Pizzasa.Add(new pi.Pizza(typeof(T).Name));
        }
    }
}
