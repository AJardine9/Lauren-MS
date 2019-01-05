using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Order
{
    public class Order
    {
        public int Id { get; set; }
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
        public string Username { get; set; }
        public double Total { get; set; }
        public DateTime PurchaseTime { get; set; }
        public bool CanCancel { get; set; }
        public List<pi.Pizza> Pizzas { get; set; }
        public string LocationAddress { get; set; }

        public Order(string username = "", int lastordernumber = 0, string locationAddress = "")
        {
            Pizzas = new List<pi.Pizza>();
            Username = username;
            Total = (double)0.0;
            PurchaseTime = DateTime.Now;
            CanCancel = true;
            OrderNumber = lastordernumber;
            LocationAddress = locationAddress;
        }

        #region Totals
        public void AddToTotal(double value)
        {
            Total += value;
        }

        public void SubtractFromTotal(double value)
        {
            Total -= value;
        }
        #endregion

        public void PriceOfPizzas(List<pi.Pizza> pizzas)
        {
            foreach (pi.Pizza pizza in pizzas)
            {
                pi.Pizza temp = new pi.Pizza();
                temp.GetPriceOfPizza(pizza);
            }
        }

        public string AddressOfMostRecentOrder(List<pi.Pizza> pizzas)
        {
            string location = "";
            foreach (pi.Pizza pizza in pizzas)
            {
                
            }

            return location;
        }
    }
}
