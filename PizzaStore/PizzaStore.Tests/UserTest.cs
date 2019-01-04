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
        // TODO: Is the user not null?
        [Fact]
        public void Test_UserExists()
        {
            
        }

        // TODO: Does the user have a username?
        [Fact]
        public void Test_Username()
        {
            var expected = "admin";
            var sut = new us.User();

            Assert.IsType<string>(sut.Username);
            Assert.True(expected == sut.Username);
        }

        // TODO: Does the user have a password that is not null?
        [Fact]
        public void Test_Password()
        {
            var expected = "admin";
            var sut = new us.User();

            Assert.IsType<string>(sut.Password);
            Assert.True(expected == sut.Password);
        }

        // TODO: Data from the last location ordered from, both time and location
        [Fact]
        public void Test_LastLocationOrdered()
        {

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
