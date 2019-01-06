using System;
using System.Collections.Generic;
using System.Text;
using lo = PizzaStore.Domain.Models.Location;
using ord = PizzaStore.Domain.Models.Order;
using us = PizzaStore.Domain.Models.User;
using Xunit;

namespace PizzaStore.Tests
{
    public class UserTest
    {
        public us.User sut { get; private set; }
        public lo.Location location { get; private set; }
        public ord.Order order { get; private set; }

        public UserTest()
        {
            sut = new us.User("admin", "password");

            location = new lo.Location("test address");

            sut.CreateOrder(location.OrderNumber, location.Address);
            sut.AddOrder();
        }

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
        /*[Fact]
        public void Test_LastLocationOrdered()
        {
            var expected = location.Address;
            Assert.True(sut.LastLocationOrdered == expected);
        }

        // TODO: Does OrderHistory exist and contain orders?
        [Fact]
        public void Test_OrderHistory()
        {
            Assert.Contains(order, sut.Orders);
        }

        // TODO: CreateOrder
        [Fact]
        public void Test_CreateOrder()
        {
            sut.CreateOrder(location.OrderNumber, location.Address);
            Assert.True(sut.Orders.Count == 2);
        }

        // TODO: CancelOrder order can only be cancelled if not yet submitted
        [Fact]
        public void Test_CancelOrder()
        {
            sut.CreateOrder(location.OrderNumber, location.Address);
            sut.CancelOrder();

            Assert.Null(sut.CurrentOrder);
            Assert.IsType<ord.Order>(sut.CurrentOrder);
        }

        // TODO: SubmitOrder adds complete order to order history list, order at location list
        [Fact]
        public void Test_AddOrder()
        {
            sut.CreateOrder(location.OrderNumber, location.Address);
            sut.AddOrder();

            Assert.Null(sut.CurrentOrder);
            Assert.IsType<ord.Order>(sut.CurrentOrder);
            Assert.True(sut.Orders.Count == 3);
        }*/
    }
}
