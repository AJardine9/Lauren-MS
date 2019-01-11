using System;
using System.Collections.Generic;
using System.Linq;
using d = PizzaStore.Domain.Models;

namespace PizzaStore.Data
{
    public class EntityHelper
    {
        //private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        //public List<d.Address> GetAddresses()
        //{
        //    var da = new List<d.Address>();

        //    foreach (var item in _db.Address.ToList())
        //    {
        //        da.Add(new d.Address()
        //        {
        //            AddressId = item.AddressId
        //        });
        //    }

        //    return da;
        //}

        //public List<d.Location> GetLocations()
        //{
        //    var dl = new List<d.Location>();

        //    foreach (var item in _db.Location.ToList())
        //    {
        //        dl.Add(new d.Location()
        //        {
        //            LocationId = item.LocationId
        //        });
        //    }

        //    return dl;
        //}

        //public List<d.Order> GetOrders()
        //{
        //    var dr = new List<d.Order>();

        //    foreach (var item in _db.Order.ToList())
        //    {
        //        dr.Add(new d.Order()
        //        {
        //            OrderId = item.OrderId
        //        });
        //    }

        //    return dr;
        //}

        //public List<d.Pizza> GetPizzas()
        //{
        //    var dp = new List<d.Pizza>();

        //    foreach (var item in _db.Pizza.ToList())
        //    {
        //        dp.Add(new d.Pizza()
        //        {
        //            PizzaId = item.PizzaId
        //        });
        //    }

        //    return dp;
        //}

        //public bool SetUser(d.User u)
        //{
        //    var du = new User();

        //    du.AddressId = 5;
        //    du.DateModified = DateTime.Now.AddHours(6);
        //    du.Name = u.Name;

        //    _db.User.Add(du);
        //    return _db.SaveChanges() == 1;
        //}
    }
}
