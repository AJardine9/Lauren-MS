using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using System.Linq;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Data.Helpers
{
    public static class ToppingInventoryHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<lo.ToppingInventory> GetToppingInventory(pi.Toppings topping, int stock)
        {
            var du = new List<lo.ToppingInventory>();

            foreach (var toppingInventory in _db.ToppingInventory.ToList())
            {
                du.Add(new lo.ToppingInventory(topping.ToppingId, stock));
            }

            return du;
        }
    }
}
