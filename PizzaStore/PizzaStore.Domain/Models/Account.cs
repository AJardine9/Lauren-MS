using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;
//using PizzaStore.CliClient.ViewModels;

namespace PizzaStore.Domain.Models
{
    public static class Account
    {
        #region Field
        private static List<us.User> Accounts { get; set; }
        public static List<lo.Location> Locations { get; private set; }
        public static int AccountId { get; set; }
        #endregion

        //#region Methods
        //public static void CreateUser(string username, string password)
        //{
        //    var user = new us.User(username, password);
        //    RegisterAccount(user);
        //}

        //public static void RegisterAccount(us.User user)
        //{
        //    UserViewModel.SetUser(user);
        //}

        //public static us.User GetUser(string username, string password)
        //{
        //    var user = UserViewModel.GetUser(username, password);
        //    return user;
        //}

        //////public void OrderMadeAtLocation()
        //////{

        //////}

        //public static void OpenNewLocation(string street, string city, string state)
        //{
        //    var address = new Address(street, city, state);
        //    var location = new lo.Location(address);

        //    LocationViewModel.SetLocation(location, address);
        //}

        ////public void CloseLocation()
        ////{

        ////}

        ////public lo.Location GetLocation()
        ////{
        ////    return location;
        ////}

        //public static List<lo.Location> DisplayLocations()
        //{
        //    var locations = LocationViewModel.GetLocations();
        //    return locations;
        //}
        //#endregion
    }
}
