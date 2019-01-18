using PizzaStore.Data.Helpers;
using PizzaStore.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.ClientV2.ViewModels
{
    public static class UserViewModel
    {
        public static List<User> GetUsers() //mvc pattern
        {
            return UserHelper.GetUsers();
        }

        public static bool SetUser(User user)
        {
            return UserHelper.SetUser(user);
        }

        public static User GetUser(string username, string password)
        {
            User user = new User(username, password);
            return UserHelper.GetUser(user);
        }
    }
}
