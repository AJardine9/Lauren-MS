using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Location
    {
        public Location()
        {
            CrustInventory = new HashSet<CrustInventory>();
            Order = new HashSet<Order>();
            SizeInventory = new HashSet<SizeInventory>();
            ToppingInventory = new HashSet<ToppingInventory>();
        }

        public int LocationId { get; set; }
        public int AddressId { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
        public int? OrderNumber { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<CrustInventory> CrustInventory { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<SizeInventory> SizeInventory { get; set; }
        public virtual ICollection<ToppingInventory> ToppingInventory { get; set; }
    }
}
