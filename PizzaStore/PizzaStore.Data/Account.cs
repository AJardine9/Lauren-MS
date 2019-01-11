using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Account
    {
        public Account()
        {
            Location = new HashSet<Location>();
            User = new HashSet<User>();
        }

        public int AccountId { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
