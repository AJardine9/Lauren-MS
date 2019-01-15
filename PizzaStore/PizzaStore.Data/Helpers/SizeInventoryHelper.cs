using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using System.Linq;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Data.Helpers
{
    public static class SizeInventoryHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static bool SetSizeInventory(List<pi.Size> sizes, int locationId, int stock)
        {
            foreach (var size in sizes)
            {
                var dataSize = new SizeInventory()
                {
                    SizeId = size.SizeId,
                    LocationId = locationId,
                    Stock = stock
                };

                _db.SizeInventory.Add(dataSize);
            }

            return _db.SaveChanges() == 4;
        }
    }
}
