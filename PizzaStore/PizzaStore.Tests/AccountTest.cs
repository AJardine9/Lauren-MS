using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using lo = PizzaStore.Domain.Models.Location;
using ac = PizzaStore.Domain.Models;

namespace PizzaStore.Tests
{
    public class AccountTest
    {
        private readonly ac.Account sut;

        public AccountTest()
        {
            sut = new ac.Account();
        }

        // TODO: Hold list of all Users
        [Fact]
        public void Test_ListOfUsers()
        {
            //sut.CreateAccount();
            //sut.RegisterAccount();

            //Assert.True(sut.Accounts.Count > 0);
        }

        // TODO: Create Account
        [Fact]
        public void Test_CreateAccount()
        {
            //sut.CreateAccount();

            //Assert.True(sut.)
        }

        // TODO: Register Account
        [Fact]
        public void Test_RegisterAccount()
        {

        }

        // TODO: Hand User that made order to Location
        // Location shouldn't have all user info until necessary
        [Fact]
        public void Test_OrderMadeAtLocation()
        {

        }

        // TODO: Open a new location
        [Fact]
        public void Test_OpenNewLocation()
        {
            //sut.OpenNewLocation("New Location Address");
        }

        // TODO: Close a location
        [Fact]
        public void Test_CloseLocation()
        {
            //var locationToClose = sut.GetLocation();
            //sut.CloseLocation(locationToClose);
        }

        [Fact]
        public void Test_GetLocation()
        {
            //lo.Location actual = sut.GetLocation();
        }
    }
}
