using System;
using System.Collections.Generic;
using System.Text;
using pi = PizzaStore.Domain.Models.Pizza;
using System.Linq;

namespace PizzaStore.Data.Helpers
{
    public static class SizeHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<pi.Size> GetSizes()
        {
            var du = new List<pi.Size>();

            foreach (var size in _db.Size.ToList())
            {
                du.Add(new pi.Size(size.SizeId, size.Name, (double)size.Price));
            }

            return du;
        }
    }
}
