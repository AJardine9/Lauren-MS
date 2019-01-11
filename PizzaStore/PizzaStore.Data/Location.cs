using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public int AccountId { get; set; }
        public int AddressId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
