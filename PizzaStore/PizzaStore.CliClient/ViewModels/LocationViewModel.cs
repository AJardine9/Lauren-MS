using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using PizzaStore.Data.Helpers;

namespace PizzaStore.CliClient.ViewModels
{
    public static class LocationViewModel
    {
        public static List<lo.Location> GetLocations()
        {
            return LocationHelper.GetLocations();
        }
    }
}
