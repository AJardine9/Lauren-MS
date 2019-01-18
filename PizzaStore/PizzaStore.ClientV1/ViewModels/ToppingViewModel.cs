using System;
using System.Collections.Generic;
using System.Text;
using pi = PizzaStore.Domain.Models.Pizza;
using PizzaStore.Data.Helpers;

namespace PizzaStore.ClientV1.ViewModels
{
    public static class ToppingViewModel
    {
        public static List<pi.Toppings> GetToppings()
        {
            return ToppingHelper.GetToppings();
        }
    }
}
