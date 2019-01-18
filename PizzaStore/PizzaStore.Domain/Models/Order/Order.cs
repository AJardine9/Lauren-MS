using System;
using System.Collections.Generic;
using System.Text;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;
using lo = PizzaStore.Domain.Models.Location;

namespace PizzaStore.Domain.Models.Order
{
    public class Order
    {
        #region Field
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public string Username { get; set; }
        public double Total { get; set; }
        public DateTime PurchaseTime { get; set; }
        public List<pi.Pizza> Pizzas { get; set; }
        public string LocationAddress { get; set; }
        public pi.Pizza CurrPizza { get; set; }

        #endregion
        #region Constructor
        public Order(string username)
        {
            Pizzas = new List<pi.Pizza>();
            Username = username;
            Total = 0;
            PurchaseTime = DateTime.Now;
            OrderNumber = 0;
            LocationAddress = "";
            CurrPizza = null;
        }
        #endregion
        #region Methods
        ///*
        //public void PriceOfPizzas(List<pi.Pizza> pizzas)
        //{
        //    foreach (pi.Pizza pizza in pizzas)
        //    {
        //        Total += pizza.GetPriceOfPizza(pizza);
        //    }
        //}
        //*/
        //public string AddressOfMostRecentOrder(List<pi.Pizza> pizzas)
        //{
        //    string location = "";
        //    foreach (pi.Pizza pizza in pizzas)
        //    {

        //    }

        //    return location;
        //}

        //public void AddToTotal(double value)
        //{
        //    Total += value;
        //}

        //public void SubtractFromTotal(double value)
        //{
        //    Total -= value;
        //}


        public void CreatePizza()
        {
            CurrPizza = new pi.Pizza();
        }

        //public bool AddToppingToPizza(pi.Toppings option)
        //{
        //    if (CurrPizza.Toppings.Count < 5)
        //    {
        //        CurrPizza.Toppings.Add(option);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool RemoveToppingFromPizza(pi.Toppings option)
        //{
        //    if (CurrPizza.Toppings.Contains(option))
        //    {
        //        CurrPizza.Toppings.Remove(option);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool AdjustCrustOfPizza(pi.Crust option)
        //{
        //    CurrPizza.Crust = option;
        //    return true;
        //}

        //public bool AdjustSizeOfPizza(pi.Size option)
        //{
        //    CurrPizza.Size = option;
        //    return true;
        //}

        //public void AddPizza()
        //{
        //    if (CurrPizza != null)
        //    {
        //        Pizzas.Add(CurrPizza);
        //        CurrPizza = null;
        //    }
        //}

        //public void RemovePizzaFromPizzas(pi.Pizza pizza)
        //{
        //    if (Pizzas.Contains(pizza))
        //    {
        //        Pizzas.Remove(pizza);
        //    }
        //}

        //public pi.Pizza GetPizzaFromPizzas(pi.Pizza pizza)
        //{
        //    if (pizza != null
        //        && Pizzas.Count > 0
        //        && Pizzas.Contains(pizza))
        //    {
        //        CurrPizza = pizza;
        //    }

        //    return CurrPizza;
        //}
        #endregion
    }
}
