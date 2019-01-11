using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public int OrderNumber { get; set; }
        public string Username { get; set; }
        public decimal Total { get; set; }
        public DateTime? PurchaseTime { get; set; }
        public string LocationAddress { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
