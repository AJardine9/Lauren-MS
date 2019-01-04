using System.Collections.Generic;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Pizza : APizza
    {
        public Pizza(string crust = "defaultCrust", int size = 0, List<string> toppings = null, double price = (double)0.0)
        {
            Crust = crust;
            Size = size;
            Toppings = toppings;
            Price = price;
        }

        #region Crust
        // allow for checking current crust
        public string GetCrust()
        {
            return Crust;
        }

        // allow for setting what type of crust it is
        public void SetCrust(string crust)
        {
            Crust = crust;
        }
        #endregion
        #region Size
        // Get current size of pizza
        public int GetSize()
        {
            return Size;
        }

        // Allow for size option
        public void SetSize(int size)
        {
            Size = size;
        }
        #endregion
        #region Toppings
        // For use in displaying the current list of toppings
        public List<string> GetToppings()
        {
            return Toppings;
        }

        // Add a topping to the current list
        public bool AddTopping(string topping)
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
        public void RemoveTopping(string topping)
        {
            Toppings.Remove(topping);
        }

        // Allow for radio options
        public void ReplaceTopping(string newTopping, string oldTopping)
        {
            Toppings.Remove(oldTopping);
            Toppings.Add(newTopping);
        }
        #endregion

        public void GetPriceOfPizza(Pizza pizza)
        {
            var options = new pi.PizzaOptions();
            foreach (string topping in pizza.Toppings)
            {
                // every additional topping is $1.50
                Price += options.toppingPrice;
            }
        }
    }
}
