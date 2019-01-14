using System.Collections.Generic;
using pi = PizzaStore.Domain.Models.Pizza;
using lo = PizzaStore.Domain.Models.Location;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Pizza
    {
        #region Field
        public int PizzaId { get; set; }
        public string Crust { get; set; }
        public string Size { get; set; }
        public List<string> Toppings { get; set; }
        #endregion
        #region Constructor
        public Pizza()
        {
            Crust = "Regular";
            Size = "Medium";
            Toppings = new List<string>();
            Toppings.Add("cheeseCheddar");
            Toppings.Add("sauceTomato");
        }
        #endregion
        #region Methods


        //// Add a topping to the current list
        //public bool AddTopping(Toppings topping)
        //{
        //    if (Toppings.Count < 5)
        //    {
        //        Toppings.Add(topping);
        //        return true; // Was able to add topping
        //    }
        //    else
        //    {
        //        return false; // Was unable to add topping
        //    }
        //}

        //// Allow for user changing their mind on a topping
        //public void RemoveTopping(Toppings topping)
        //{
        //    Toppings.Remove(topping);
        //}

        //// Allow for radio options
        //public void ReplaceTopping(Toppings newTopping, Toppings oldTopping)
        //{
        //    Toppings.Remove(oldTopping);
        //    Toppings.Add(newTopping);
        //}

        ///*
        //public double GetPriceOfPizza(Pizza pizza)
        //{
        //    //var options = new lo.Inventory();
        //    double price = 0;
        //    foreach (Toppings topping in pizza.Toppings)
        //    {
        //        // every additional topping is $1.50
        //        price += options.GetPrice(topping);
        //    }

        //    return price;
        //}
        //*/
        #endregion
    }
}
