using PizzaStore.CliClient.ViewModels;
using PizzaStore.CliClient.Models;
using System;

namespace PizzaStore.CliClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var menus = new Menus();
            menus.MainMenu();
        }
    }
}
