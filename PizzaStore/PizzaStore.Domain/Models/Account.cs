using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;

namespace PizzaStore.Domain.Models
{
    public class Account
    {
        #region Field
        private static List<us.User> Accounts { get;  set; }
        public static List<lo.Location> Locations { get; private set; }
        #endregion
        #region Constructor
        public Account()
        {
            
        }
        #endregion
        #region Methods
        public void CreateAccount()
        {

        }

        public void RegisterAccount()
        {

        }

        public void 

        public us.User GetAccount()
        {
            return user;
        }

        public void OrderMadeAtLocation()
        {

        }

        public void OpenNewLocation()
        {

        }

        public void CloseLocation()
        {

        }

        public lo.Location GetLocation()
        {
            return location;
        }
        #endregion
    }
}
