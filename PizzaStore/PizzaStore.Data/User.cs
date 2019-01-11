using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class User
    {
        public int UserId { get; set; }
        public int AccountId { get; set; }
        public int? LocationId { get; set; }
        public int AddressId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LastLocationOrdered { get; set; }
        public DateTime? LastTimeOrdered { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
