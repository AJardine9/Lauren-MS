﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Order
    {
        public Order()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public string Username { get; set; }
        public decimal Total { get; set; }
        public DateTime? PurchaseTime { get; set; }
        public string LocationAddress { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
        public int? OrderNumber { get; set; }

        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
