using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.ClientV2.ViewModels;

namespace PizzaStore.ClientV2.Models
{
    public class OrderAdjustments
    {
        public void CrustOptionAvailable()
        {
            CrustViewModel.GetCrusts();
        }

        public void ToppingOptionAvailable()
        {
            ToppingViewModel.GetToppings();
        }

        public void SizeOptionAvailable()
        {
            SizeViewModel.GetSizes();
        }
    }
}
