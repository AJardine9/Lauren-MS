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
    public static class PizzaHelper
    {
        /*
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<pi.Pizza> GetPizzaByLocation(lo.Location location)
        {
            var dataLocation = _db.Location.Where(l => l.LocationId == location.LocationId).FirstOrDefault();

            if (dataLocation == null)
            {
                return null;
            }

            return GetPizzas(dataLocation.Order);
        }

        public static List<pi.Pizza> GetPizzaByOrder(ord.Order order)
        {
            var dataOrder = _db.Order.Where(o => o.OrderId == order.OrderId).FirstOrDefault();

            if (dataOrder == null)
            {
                return null;
            }

            return GetPizzas(new List<Order>() { dataOrder });
        }

        private static List<pi.Pizza> GetPizzas(ICollection<Order> orderCollection)
        {
            var pizzas = new List<pi.Pizza>();

            foreach (var item in orderCollection.ToList())
            {
                foreach (var stuff in item.Pizza.ToList())
                {
                    pizzas.Add(new pi.Pizza()
                    {
                        PizzaId = stuff.PizzaId
                    });
                }
            }

            return pizzas;
        }

        public static bool SetPizza(pi.Pizza pizza)
        {
            var dataPizza = new Pizza();
            {

            };

            _db.Pizza.Add(dataPizza);

            return address == null ? _db.SaveChanges() == 2 : _db.SaveChanges() == 1;
        }*/
    }
}
