using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using pdm = PizzaStore.Domain.Models;
using pi = PizzaStore.Domain.Models.Pizza;
using ord = PizzaStore.Domain.Models.Order;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;

namespace PizzaStore.Data.Helpers
{
    public static class OrderHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        //public static List<ord.Order> GetOrderByLocation(lo.Location location)
        //{
        //    var dataLocation = _db.Location.Where(l => l.LocationId == location.LocationId).FirstOrDefault();

        //    if (dataLocation == null)
        //    {
        //        return null;
        //    }
        //    else


        //    return GetOrders(dataLocation.Order);
        //}

        //public static List<ord.Order> GetOrderByUser(us.User user)
        //{
        //    var dataUser = _db.User.Where(u => u.UserId == user.UserId).FirstOrDefault();

        //    if (dataUser == null)
        //    {
        //        return null;
        //    }

        //    return GetOrders(dataUser.Order);
        //}

        public static List<ord.Order> GetOrders()
        {
            var orders = new List<ord.Order>();

            foreach (var item in _db.Order.ToList())
            {
                orders.Add(new ord.Order(item.Username)
                {
                    OrderId = item.OrderId
                });
            }

            return orders;
        }

        //public static bool SetOrder()
        //{

        //}

        //public static ord.Order GetOrder()
        //{
            
        //}
    }
}
