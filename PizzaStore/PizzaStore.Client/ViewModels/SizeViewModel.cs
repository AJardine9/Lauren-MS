using System;
using System.Collections.Generic;
using System.Text;
using pi = PizzaStore.Domain.Models.Pizza;
using PizzaStore.Data.Helpers;

namespace PizzaStore.Client.ViewModels
{
    public static class SizeViewModel
    {
        public static List<pi.Size> GetSizes()
        {
            return SizeHelper.GetSizes();
        }
    }
}
