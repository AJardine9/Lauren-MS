using System;
using System.Collections.Generic;
using System.Text;
using pdm = PizzaStore.Domain.Models;
using ord = PizzaStore.Domain.Models.Order;
using pi = PizzaStore.Domain.Models.Pizza;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Data.Helpers
{
    public static class UserHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        /*
        public static List<ord.Order> GetOrderByUser(us.User user)
        {
            var dataUser = _db.User.Where(u => u.UserId == user.UserId).FirstOrDefault();

            if (dataUser == null)
            {
                return null;
            }

            return OrderHelper.GetOrders(dataUser.Order);
        }
        */

        public static us.User GetUser(us.User user)
        {
            var dataUser = _db.User.Where(u => u.Username == user.Username).FirstOrDefault();
            
            if (dataUser == null
                || dataUser.Password != user.Password)
            {
                return null;
            }

            return user;
        }

        public static List<us.User> GetUsers()
        {
            var du = new List<us.User>();

            foreach (var item in _db.User.ToList())
            {
                du.Add(new us.User(item.Username, item.Password));
            }

            return du;
        }

        public static bool SetUser(us.User user)
        {
            var dataUser = new User()
            {
                Username = user.Username,
                Password = user.Password,
                LastLocationOrdered = user.LastLocationOrdered.ToString(),
                LastTimeOrdered = user.LastTimeOrdered
            };

            _db.User.Add(dataUser);

            return _db.SaveChanges() == 1;
        }
    }
}
