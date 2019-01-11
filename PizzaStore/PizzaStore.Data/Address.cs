using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
