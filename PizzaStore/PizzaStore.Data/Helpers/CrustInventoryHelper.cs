using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using System.Linq;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Data.Helpers
{
    public static class CrustInventoryHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static bool SetCrustInventory(List<pi.Crust> crusts, int locationId, int stock)
        {
            foreach (var crust in crusts)
            {
                var dataCrust = new CrustInventory()
                {
                    CrustId = crust.CrustId,
                    LocationId = locationId,
                    Stock = stock
                };

                _db.CrustInventory.Add(dataCrust);
            }

            return _db.SaveChanges() == 4;
        }

        public static List<lo.CrustInventory> GetCrustInventoryByLocation (List<pi.Crust> crusts, int locationId)
        {
            var du = new List<lo.CrustInventory>();

            foreach (var item in _db.CrustInventory.ToList())
            {
                pi.Crust crust = crusts.Where(c => c.CrustId == item.CrustId).FirstOrDefault();
            }

            return du;
        }

        public static List<lo.CrustInventory> GetCrustInventory()
        {
            var du = new List<lo.CrustInventory>();

            foreach (var item in _db.CrustInventory.ToList())
            {
                du.Add(new us.User(item.Username, item.Password));
            }

            return du;
        }
    }
}
