using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.CliClient.ViewModels;

namespace PizzaStore.CliClient.Models
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
