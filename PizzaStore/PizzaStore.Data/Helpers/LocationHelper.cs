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

        public static bool SetLocation(lo.Location location, pdm.Address address)
        {
            var dataAddress = new Address()
            {
                Street = address.Street,
                City = address.City,
                State = address.State
            };
            
            _db.Address.Add(dataAddress);

            var dataLocation = new Location()
            {
                AddressId = dataAddress.AddressId,
                OrderNumber = location.OrderNumber
            };

            _db.Location.Add(dataLocation);

            var newLocation = _db.Location.Where(a => a.AddressId == dataLocation.AddressId).FirstOrDefault();

            InitLocationInventory(newLocation.LocationId);

            return _db.SaveChanges() == 3;
        }

        public static void InitLocationInventory(int locationId)
        {
            var crusts = GetCrusts();
            var sizes = GetSizes();
            var toppings = GetToppings();
            var defaultStock = 10;
        
            foreach(var crust in crusts)
            {
                var dataCrust = new CrustInventory()
                {
                    CrustId = crust.CrustId,
                    LocationId = locationId,
                    Stock = defaultStock
                };

                _db.CrustInventory.Add(dataCrust);
            }

            foreach(var size in sizes)
            {
                var dataSize = new SizeInventory()
                {
                    SizeId = size.SizeId,
                    LocationId = locationId,
                    Stock = defaultStock
                };

                _db.SizeInventory.Add(dataSize);
            }

            foreach(var topping in toppings)
            {
                var dataTopping = new ToppingInventory()
                {
                    ToppingId = topping.ToppingId,
                    LocationId = locationId,
                    Stock = defaultStock
                };

                _db.ToppingInventory.Add(dataTopping);
            }
        }

        public static List<pi.Crust> GetCrusts()
        {
            var du = new List<pi.Crust>();

            foreach (var crust in _db.Crust.ToList())
            {
                du.Add(new pi.Crust(crust.CrustId, crust.Name, (double)crust.Price));
            }

            return du;
        }

        public static List<pi.Size> GetSizes()
        {
            var du = new List<pi.Size>();

            foreach (var size in _db.Size.ToList())
            {
                du.Add(new pi.Size(size.SizeId, size.Name, (double)size.Price));
            }

            return du;
        }

        public static List<pi.Toppings> GetToppings()
        {
            var du = new List<pi.Toppings>();

            foreach (var topping in _db.Topping.ToList())
            {
                du.Add(new pi.Toppings(topping.ToppingId, topping.Name, (double)topping.Price));
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