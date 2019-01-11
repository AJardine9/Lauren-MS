using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using ord = PizzaStore.Domain.Models.Order;
using us = PizzaStore.Domain.Models.User;
using PizzaStore.Domain.Models
using Xunit;

namespace PizzaStore.Tests
{
    public class UserTest
    {
        private readonly us.User sut;
        private readonly lo.Location location;
        private readonly Address address;
        private readonly Address userAddress;
        public ord.Order order { get; private set; }

        public UserTest()
        {
            address = new Address("1123 Fletcher St", "Tampa", "Florida");
            userAddress = new Address("51 Viking Oak", "Tampa", "Florida");

            sut = new us.User("admin", "password", userAddress);
            location = new lo.Location(address);

            sut.CreateOrder(location.OrderNumber, location.Address);
        }

        //public UserTest()
        //{
        //    sut = new User()
        //    {
        //        Name = "fred",
        //        Address = new Address()
        //        {
        //            City = "Tampa",
        //            State = "Florida",
        //            Street = "Fletcher Ave"
        //        }
        //    };
        //}

        //[Fact]
        //public void Test_SetDataUser()
        //{
        //    Assert.True(UserHelper.SetUser(sut));
        //}

        // TODO: Is the user not null?
        [Fact]
        public void Test_UserExists()
        {
            Assert.NotNull(sut);
            Assert.IsType<us.User>(sut);
        }

        // TODO: Does the user have a username?
        // If username exists, password exists but can't test as password is private
        [Fact]
        public void Test_Username()
        {
            Assert.IsType<string>(sut.Username);
        }

        // TODO: Data from the last location ordered from, both time and location
        [Fact]
        public void Test_LastLocationOrdered()
        {
            Assert.IsType<string>(sut.LastLocationOrdered);
        }

        // TODO: CreateOrder
        [Fact]
        public void Test_CreateOrder()
        {
            sut.CreateOrder(location.OrderNumber, location.Address);
            Assert.NotNull(sut.CurrentOrder);
        }


        // TODO: Does OrderHistory exist and contain orders?
        [Fact]
        public void Test_OrderHistory()
        {
            Assert.NotNull(sut.Orders);
            Assert.IsType<List<ord.Order>>(sut.Orders);
        }

        // TODO: CancelOrder order can only be cancelled if not yet submitted
        [Fact]
        public void Test_CancelOrder()
        {
            sut.CreateOrder(location.OrderNumber, location.Address);
            sut.CancelOrder();

            Assert.Null(sut.CurrentOrder);
        }

        // TODO: SubmitOrder adds complete order to order history list, order at location list
        [Fact]
        public void Test_AddOrder()
        {
            sut.CreateOrder(location.OrderNumber, location.Address);
            sut.AddOrder();

            Assert.Null(sut.CurrentOrder);
            Assert.True(sut.Orders.Count > 0);
        }
    }
}
