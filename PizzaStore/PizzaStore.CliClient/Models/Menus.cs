using System;
using System.Collections.Generic;
using System.Text;
using ord = PizzaStore.Domain.Models.Order;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;
using pdm = PizzaStore.Domain.Models;
using PizzaStore.CliClient.ViewModels;

namespace PizzaStore.CliClient.Models
{
    public class Menus
    {
        private int defaultStock = 10;

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
            Console.WriteLine("4. Logout");
            var input = Console.ReadLine();
            int choice;
            bool validOption = Int32.TryParse(input, out choice);

            if (validOption)
            {
                switch (choice)
                {
                    case 1:
                        OrderPizzaMenu(user);
                        break;
                    case 2:
                        UserAccountMenu(user);
                        break;
                    case 3:
                        LocationMenu(user);
                        break;
                    case 4:
                        MainMenu();
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
        
        public void OrderPizzaMenu(us.User user)
        {
            Console.WriteLine("Which Location would you like to order from?");

            int option = 1;
            List<lo.Location> locations = new List<lo.Location>();

            foreach (var location in LocationViewModel.GetLocations())
            {
                locations.Add(location);
                Console.WriteLine(option + ". " + "Street: " + location.Address.Street + ", City: " + location.Address.City + ", State: " + location.Address.State);

                option++;
            }

            lo.Location chosenLocation = locations[0];
            var input = Console.ReadLine();
            int choice;
            bool validOption = Int32.TryParse(input, out choice);
            try
            {
                choice -= 1;
                chosenLocation = locations[choice];
            }
            catch
            {
                Console.WriteLine("Your chosen location does not exist");
                OrderPizzaMenu(user);
            }

            user.CreateOrder(chosenLocation.OrderNumber, chosenLocation.Address);

            user.CurrentOrder.CreatePizza();
            
            Console.WriteLine("What type of crust would you like for your pizza?");

            option = 1;
            List<pi.Crust> crusts = CrustViewModel.GetCrusts();
            List<lo.CrustInventory> crustIntentory = CrustInventoryViewModel.GetCrustInventory(crusts, chosenLocation.LocationId, defaultStock);
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

        public void LocationMenu(us.User user)
        {
            Console.WriteLine("The following locations are available.");
            
            foreach (var location in LocationViewModel.GetLocations())
            {
                Console.WriteLine("Street: " + location.Address.Street + ", City: " + location.Address.City + ", State: " + location.Address.State);
            }

            if (user.Username == "Admin")
            {
                CreateLocation(user);
            }
        }

        public void CreateLocation(us.User user)
        {
            Console.WriteLine("Welcome Admin!");
            Console.WriteLine("1. Create Location");
            Console.WriteLine("2. Return to previous");

            var input = Console.ReadLine();
            int choice;
            bool validOption = Int32.TryParse(input, out choice);

            if (validOption)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Street");
                        var street = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        var city = Console.ReadLine();
                        Console.WriteLine("Enter State");
                        var state = Console.ReadLine();

                        var address = new pdm.Address(street, city, state);
                        var location = new lo.Location(address);

                        LocationViewModel.SetLocation(location, address);
                        break;
                    case 2:
                        LoggedMenu(user);
                        break;
                    default:
                        Console.WriteLine("Please enter valid option.");
                        CreateLocation(user);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid option.");
                CreateLocation(user);
            }
        }
    }
}
