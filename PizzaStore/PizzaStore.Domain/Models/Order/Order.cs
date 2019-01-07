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
        public int OrderNumber { get; set; } // fix in a minute
        public string Username { get; set; }
        public double Total { get; set; }
        public DateTime PurchaseTime { get; set; }
        public List<pi.Pizza> Pizzas { get; set; }
        public string LocationAddress { get; set; }
        public pi.Pizza CurrPizza { get; set; }

        #endregion
        #region Constructor
        public Order(string username, int lastordernumber, string locationAddress)
        {
            Pizzas = new List<pi.Pizza>();
            Username = username;
            Total = 0;
            PurchaseTime = DateTime.Now;
            OrderNumber = lastordernumber;
            LocationAddress = locationAddress;
            CurrPizza = null;
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

        public void AddToTotal(double value)
        {
            Total += value;
        }

        public void SubtractFromTotal(double value)
        {
            Total -= value;
        }

        public void CreatePizza()
        {
            // default pizza is cheese with tomato sauce
            CurrPizza = new pi.Pizza(pi.EPizzaOptions.crustRegular, pi.EPizzaOptions.sizeMedium);
            CurrPizza.Toppings.Add(pi.EPizzaOptions.cheeseCheddar);
            CurrPizza.Toppings.Add(pi.EPizzaOptions.sauceTomato);

        }

        public bool AddToppingToPizza(pi.EPizzaOptions option)
        {
            if (CurrPizza.Toppings.Count < 5)
            {
                CurrPizza.Toppings.Add(option);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveToppingFromPizza(pi.EPizzaOptions option)
        {
            if (CurrPizza.Toppings.Contains(option))
            {
                CurrPizza.Toppings.Remove(option);
                return true;
            }
            else
            {
                return false;
            }
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
