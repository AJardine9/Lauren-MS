using System.Collections.Generic;
using pi = PizzaStore.Domain.Models.Pizza;
using lo = PizzaStore.Domain.Models.Location;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Pizza
    {
        #region Field
        public int Id { get; set; }
        public EPizzaOptions Crust { get; set; }
        public EPizzaOptions Size { get; set; }
        public List<EPizzaOptions> Toppings { get; set; }
        #endregion
        #region Constructor
        public Pizza(EPizzaOptions crust, EPizzaOptions size)
        {
            Crust = crust;
            Size = size;
            Toppings = new List<EPizzaOptions>();
        }
        #endregion
        #region Methods
        // Add a topping to the current list
        public bool AddTopping(EPizzaOptions topping)
        {
            if (Toppings.Count < 5)
            {
                Toppings.Add(topping);
                return true; // Was able to add topping
            }
            else
            {
                return false; // Was unable to add topping
            }
        }

        // Allow for user changing their mind on a topping
        public void RemoveTopping(EPizzaOptions topping)
        {
            Toppings.Remove(topping);
        }

        // Allow for radio options
        public void ReplaceTopping(EPizzaOptions newTopping, EPizzaOptions oldTopping)
        {
            Toppings.Remove(oldTopping);
            Toppings.Add(newTopping);
        }

        public double GetPriceOfPizza(Pizza pizza)
        {
            var options = new lo.Inventory();
            double price = 0;
            foreach (EPizzaOptions topping in pizza.Toppings)
            {
                // every additional topping is $1.50
                price += options.GetPrice(topping);
            }

            return price;
        }
        #endregion
    }
}
