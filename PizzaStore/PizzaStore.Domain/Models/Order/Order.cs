using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Order
{
    public class Order
    {
        #region Field
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
        public List<pi.Pizza> Pizzas { get; set; }
        public string LocationAddress { get; set; }
        public void AddToTotal(double value)
        {
            Total += value;
        }

        public void SubtractFromTotal(double value)
        {
            Total -= value;
        }
        #endregion
        #region Constructor
        public Order(string username, int lastordernumber = 0, string locationAddress = "")
        {
            Pizzas = new List<pi.Pizza>();
            Username = username;
            Total = 0;
            PurchaseTime = DateTime.Now;
            OrderNumber = lastordernumber;
            LocationAddress = locationAddress;
        }
        #endregion
        #region Methods
        public void PriceOfPizzas(List<pi.Pizza> pizzas)
        {
            foreach (pi.Pizza pizza in pizzas)
            {
                Total += pizza.GetPriceOfPizza(pizza);
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

        public void CreatePizza()
        {

        }

        public void AddToppingToPizza()
        {

        }

        public void RemoveToppingFromPizza()
        {

        }

        public void AdjustCrustOfPizza()
        {

        }

        public void AdjustSizeOfPizza()
        {

        }

        public void AddPizza()
        {

        }

        public void RemovePizza()
        {

        }

        /*public pi.Pizza GetPizza()
        {
            return
        }*/
        #endregion
    }
}
