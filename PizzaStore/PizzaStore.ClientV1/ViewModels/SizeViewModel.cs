using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pi = PizzaStore.Domain.Models.Pizza;
using PizzaStore.Data.Helpers;

namespace PizzaStore.ClientV1.ViewModels
{
    public class SizeViewModel
    {
        public static List<pi.Size> GetSizes()
        {
            return SizeHelper.GetSizes();
        }
    }
}
