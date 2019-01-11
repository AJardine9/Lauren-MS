using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Location
    {
        public Location()
        {
            Order = new HashSet<Order>();
            User = new HashSet<User>();
        }

        public int LocationId { get; set; }
        public int AccountId { get; set; }
        public int AddressId { get; set; }
        public int InventoryId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual Account Account { get; set; }
        public virtual Address Address { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
