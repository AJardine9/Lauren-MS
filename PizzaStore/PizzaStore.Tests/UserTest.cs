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

        public UserTest()
        {
            sut = new us.User();
            sut.Username = "admin";
            sut.Password = "password";
        }

        // TODO: Is the user not null?
        [Fact]
        public void Test_UserExists()
        {
            Assert.NotNull(sut);
        }

        // TODO: Does the user have a username?
        [Fact]
        public void Test_Username()
        {
            var expected = "admin";

            Assert.IsType<string>(sut.Username);
            Assert.True(expected == sut.Username);
        }

        // TODO: Does the user have a password that is not null?
        [Fact]
        public void Test_Password()
        {
            var expected = "password";

            Assert.IsType<string>(sut.Password);
            Assert.True(expected == sut.Password);
        }

        // TODO: Data from the last location ordered from, both time and location
        [Fact]
        public void Test_LastLocationOrdered()
        {
            var location = new lo.Location();
            location.OrderNumber = 10;
            location.Address = "31 Main Ave. San Antonio, TX 78213";
            var order = new ord.Order(sut.Username, location.OrderNumber, location.Address);
            sut.Orders.Add(order);

            Assert.Contains(order, sut.Orders);
            Assert.True(sut.Orders.L)
        }

        // TODO: Does OrderHistory exist and contain orders?
        [Fact]
        public void Test_OrderHistory()
        {
            
        }

        // TODO: Add Order to OrderHistory
        // can not remove order from OrderHistory
        [Fact]
        public void Test_AddToOrderHistory()
        {

        }

        // TODO: CreateOrder
        [Fact]
        public void Test_CreateOrder()
        {

        }

        // TODO: CancelOrder order can only be cancelled if not yet submitted
        [Fact]
        public void Test_CancelOrder()
        {

        }

        // TODO: SubmitOrder adds complete order to order history list, order at location list
        [Fact]
        public void Test_SubmitOrder()
        {

        }
    }
}
