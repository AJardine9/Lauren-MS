using System;
using System.Collections.Generic;
using System.Text;
using ord = PizzaStore.Domain.Models.Order;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;
using PizzaStore.CliClient.ViewModels;

namespace PizzaStore.CliClient.Models
{
    public class Menus
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome! \n Please login to order.");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register User");
            var input = Console.ReadLine();
            int choice;
            bool validOption = Int32.TryParse(input, out choice);

            if (validOption)
            {
                switch(choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Register();
                        break;
                    default:
                        Console.WriteLine("Please enter valid option.");
                        MainMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid option.");
                MainMenu();
            }
        }

        public void Login()
        {
            Console.WriteLine("Enter your username");
            var username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            var password = Console.ReadLine();

            var user = UserViewModel.GetUser(username, password);

            if (user == null)
            {
                Console.WriteLine("Try Again");
                Login();
            }
            else
            {
                LoggedMenu(user);
            }

            LoggedMenu(user);
        }

        public void Register()
        {
            Console.WriteLine("Choose a username");
            var username = Console.ReadLine();
            Console.WriteLine("Choose a password");
            var password = Console.ReadLine();
            Console.WriteLine("Confirm your password");
            var password2 = Console.ReadLine();

            if (password != password2)
            {
                Console.WriteLine("Passwords didn't match.");
                Register();
            }

            var user = UserViewModel.GetUser(username, password);

            if (user != null)
            {
                Console.WriteLine("User already exists");
                Register();
            }
            else
            {
                user = new us.User(username, password);
                UserViewModel.SetUser(user);
                LoggedMenu(user);
            }
        }

        public void LoggedMenu(us.User user)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Order a Pizza");
            Console.WriteLine("2. View Account and Order History");
            Console.WriteLine("3. View Available Locations");
            var input = Console.ReadLine();
            int choice;
            bool validOption = Int32.TryParse(input, out choice);

            if (validOption)
            {
                switch (choice)
                {
                    case 1:
                        //OrderPizzaMenu();
                        break;
                    case 2:
                        UserAccountMenu(user);
                        break;
                    case 3:
                        LocationMenu();
                        break;
                    default:
                        Console.WriteLine("Please enter valid option.");
                        LoggedMenu(user);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid option.");
                LoggedMenu(user);
            }
        }
        
        public void OrderPizzaMenu(string user)
        {
            
            Console.WriteLine("Which Location would you like to order from?");
            //var location = GetLocation();

            //var order = new ord.Order(user, );
            Console.WriteLine("What type of crust would you like for your pizza?");


        //public List<pi.Pizza> Pizzas { get; set; }
        //public pi.Pizza CurrPizza { get; set; }

        }

        public void UserAccountMenu(us.User user)
        {
            Console.WriteLine("Username: " + user.Username);
            Console.WriteLine("Last Location Ordered: " + user.LastLocationOrdered);
            Console.WriteLine("Last Time Ordered: " + user.LastTimeOrdered);

            // TODO: Display Order History
            Console.WriteLine("Order History not currently available.");

            Console.WriteLine("Press enter to return.");
            Console.ReadLine();
            LoggedMenu(user);
            }

        public void LocationMenu()
        {

        }

        /*
        public lo.Location GetLocation()
        {
            //TODO Check location options
            return location;
        }*/
    }
}
