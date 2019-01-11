using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
