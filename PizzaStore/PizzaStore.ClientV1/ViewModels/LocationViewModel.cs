using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lo = PizzaStore.Domain.Models.Location;
using PizzaStore.Data.Helpers;
using pdm = PizzaStore.Domain.Models;


namespace PizzaStore.ClientV1.ViewModels
{
    public class LocationViewModel
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
