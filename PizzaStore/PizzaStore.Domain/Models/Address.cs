using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Address
    {
        #region Field
        public int AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        #endregion

        #region Constructor
        public Address(string street, string city, string state)
        {
            City = city;
            State = state;
            Street = street;
        }
        #endregion
    }
}
