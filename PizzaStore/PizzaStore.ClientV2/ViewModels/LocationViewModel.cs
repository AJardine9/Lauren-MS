using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using PizzaStore.Data.Helpers;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.ClientV2.ViewModels
{
    public static class LocationViewModel
    {
        public static List<lo.Location> GetLocations()
        {
            return LocationHelper.GetLocations();
        }

        public static bool SetLocation(lo.Location location, pdm.Address address)
        {
            return LocationHelper.SetLocation(location, address);
        }
    }
}
