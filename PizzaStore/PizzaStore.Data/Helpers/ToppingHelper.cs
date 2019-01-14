using System;
using System.Collections.Generic;
using System.Text;
using pi = PizzaStore.Domain.Models.Pizza;
using System.Linq;

namespace PizzaStore.Data.Helpers
{
    public static class ToppingHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<pi.Toppings> GetToppings()
        {
            var du = new List<pi.Toppings>();

            foreach (var topping in _db.Topping.ToList())
            {
                du.Add(new pi.Toppings(topping.ToppingId, topping.Name, (double)topping.Price));
            }

            return du;
        }
    }
}
