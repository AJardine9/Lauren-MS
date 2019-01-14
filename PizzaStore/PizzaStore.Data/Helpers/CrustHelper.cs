using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pi = PizzaStore.Domain.Models.Pizza;
using lo = PizzaStore.Domain.Models.Location;

namespace PizzaStore.Data.Helpers
{
    public static class CrustHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<pi.Crust> GetCrusts()
        {
            var du = new List<pi.Crust>();
 
            foreach (var crust in _db.Crust.ToList())
            {
                du.Add(new pi.Crust(crust.CrustId, crust.Name, (double)crust.Price));
            }

            return du;
        }
    }
}
