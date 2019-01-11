using System.Collections.Generic;
using System.Linq;
using pdm = PizzaStore.Domain.Models;
using pi = PizzaStore.Domain.Models.Pizza;
using ord = PizzaStore.Domain.Models.Order;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;

namespace PizzaStore.Data.Helpers
{
    public static class LocationHelper
    {
        
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();
        
        public static List<lo.Location> GetLocations()
        {
            var du = new List<lo.Location>();

            foreach (var location in _db.Location.ToList())
            {
                var dataAddress = _db.Address.Where(a => a.AddressId == location.AddressId).FirstOrDefault();
                var address = new pdm.Address(dataAddress.Street, dataAddress.City, dataAddress.State);

                du.Add(new lo.Location(address));
            }

            return du;
        }
        /*
        public static double GetLocationSales(lo.Location location)
        {
            var orders = OrderHelper.GetOrderByLocation(location);
            var sum = 0D;

            foreach (var item in orders)
            {
                sum += item.Total;
            }

            return sum;
        }

        public static List<us.User> GetLocationUsers(lo.Location location)
        {
            var dataLocation = _db.Location.Where(l => l.LocationId == location.LocationId).FirstOrDefault();
            var users = new List<us.User>();

            foreach (var item in dataLocation.Order.ToList())
            {
                users.Add(new us.User()
                {
                    UserId = item.User.UserId
                });
            }

            return users;
        }
        */
    }
}