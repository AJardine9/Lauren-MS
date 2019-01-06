using System.Collections.Generic;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Pizza
{
    public class Pizza
    {
        #region Field
        public int Id { get; set; }
        public string Crust { get; set; }
        public int Size { get; set; }
        public List<string> Toppings { get; set; }
        public double Price { get; set; }
        #endregion
        #region Constructor
        public Pizza(string crust = "Regular", int size = 12, double price = (double)5.00)
        {
            Crust = crust;
            Size = size;
            Toppings = new List<string>();
            Price = price;
        }
        #endregion
        #region Methods
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

        public void GetPriceOfPizza(Pizza pizza)
        {
            var options = new pi.PizzaOptions();
            foreach (string topping in pizza.Toppings)
            {
                // every additional topping is $1.50
                Price += options.toppingPrice;
            }
        }
        #endregion
    }
}
