using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using lo = PizzaStore.Domain.Models.Location;

namespace PizzaStore.Tests
{
    public class LocationTest
    {
        public lo.Location sut { get; private set; }

        public LocationTest()
        {
            sut = new lo.Location("test address");
        }
        // TODO: Test that list of orders exists
        // no test for adding order to list necessary, as it's in User
        // no way to delete past orders
        [Fact]
        public void Test_ListOfOrders()
        {
            Assert.NotNull(sut.Orders);
            Assert.True(sut.Orders.Count == 0);
        }

        // TODO: Test that a list of users exists
        [Fact]
        public void Test_ListOfUsers()
        {
            Assert.NotNull(sut.Users);
            Assert.True(sut.Users.Count == 0);
        }

        // TODO: Test that you can add a user to the list
        // no way to delete a user. Once they exist, they exist.
        [Fact]
        public void Test_AddUser()
        {

        }

        // TODO: Test that inventory exists and is not null
        [Fact]
        public void Test_Inventory()
        {

        }

        // TODO: Test that you can get/set ingredient in Inventory
        [Fact]
        public void Test_IngredientInInventory()
        {

        }

        // TODO: Test that you can add an ingredient to Inventory
        [Fact]
        public void Test_AddIngredientToInventory()
        {

        }

        // TODO: Test that you can remove an ingredient from Inventory
        [Fact]
        public void Test_RemoveIngredientFromInventory()
        {

        }

        // TODO: Test that you can get/set the price of an ingredient in Inventory
        [Fact]
        public void Test_PriceInInventory()
        {

        }

        // TODO: Test that you can add a new price option to Inventory
        [Fact]
        public void Test_AddPriceToInventory()
        {

        }

        // TODO: Test that you can remove an old price option from Inventory
        [Fact]
        public void Test_RemovePriceFromInventory()
        {

        }

        // TODO: Test that you can get/set the stock of an ingredient in Inventory
        [Fact]
        public void Test_StockInInventory()
        {

        }

        // TODO: Test that you can add a new stock option to Inventory
        [Fact]
        public void Test_AddStockToInventory()
        {

        }

        // TODO: Test that you can remove an old stock option from Inventory
        [Fact]
        public void Test_RemoveStockFromInventory()
        {

        }

        // TODO: Test that Total Sales for all Locations can be get/set and is a double
        // Total Sales takes the entered amount and adds it to Total Sales (negative amounts should therefore subtract automatically)
        [Fact]
        public void Test_TotalSales()
        {

        }

        // TODO: Test that Total Sales for Location can be get/set and is a double
        // Total Sales takes the entered amount and adds it to Total Sales (negative amounts should therefore subtract automatically)
        [Fact]
        public void Test_TotalSalesAtLocation()
        {

        }

        // TODO: Test that Price Cap has a get/set and is a double
        [Fact]
        public void Test_PriceCap()
        {

        }


        // TODO: Create Account
        // TODO: Register Account
        // TODO: Add User to List of Users
    }
}
