using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ord = PizzaStore.Domain.Models.Order;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Tests
{
    public class OrderTest
    {
        public ord.Order sut { get; private set; }
        public us.User user { get; private set; }
        public lo.Location location { get; set; }
        //List<pi.EPizzaOptions> Toppings = new List<pi.EPizzaOptions>();

        public OrderTest()
        {
            location = new lo.Location("test location");
            user = new us.User("admin", "password");
            sut = new ord.Order(user.Username, location.OrderNumber, location.Address);
        }

        // TODO: Pull associated User object's username
        [Fact]
        public void Test_GetUser()
        {
            var expected = user.Username;

            Assert.IsType<string>(expected);
        }

        // TODO: What location is this purchase from?
        [Fact]
        public void Test_GetPurchaseLocation()
        {
            var actual = sut.LocationAddress;

            Assert.IsType<string>(actual);
        }

        // TODO: What is the timestamp on this order?
        [Fact]
        public void Test_TimeStamp()
        {
            var actual = sut.PurchaseTime;

            Assert.IsType<DateTime>(actual);
        }

        // TODO: Running total for the order that does not go over PriceCap
        [Fact]
        public void Test_CurrentTotal()
        {
            var actual = sut.Total;

            Assert.IsType<double>(actual);
        }

        // TODO: Test List of Pizza exists and can contain Pizza
        [Fact]
        public void Test_ListOfPizza()
        {
            var pizza = new pi.Pizza(pi.EPizzaOptions.crustRegular, pi.EPizzaOptions.sizeMedium);
            pizza.AddTopping(pi.EPizzaOptions.veggieBlackOlive);
            sut.Pizzas.Add(pizza);

            Assert.True(sut.Pizzas.Count == 1);
            Assert.NotEmpty(sut.Pizzas);
        }

        // TODO: Test that Pizza can be created
        [Fact]
        public void Test_CreatePizza()
        {
            sut.CreatePizza();

            Assert.NotNull(sut.CurrPizza);
            Assert.IsType<pi.Pizza>(sut.CurrPizza);
            Assert.True(sut.CurrPizza.Crust == pi.EPizzaOptions.crustRegular);
            Assert.True(sut.CurrPizza.Size == pi.EPizzaOptions.sizeMedium);
            Assert.True(sut.CurrPizza.Toppings.Count == 2);
        }

        // TODO: Add Topping to pizza
        [Fact]
        public void Test_AddToppingToPizza()
        {
            sut.CreatePizza();
            bool actual = sut.AddToppingToPizza(pi.EPizzaOptions.veggieBlackOlive);

            Assert.True(actual);
            Assert.Contains(pi.EPizzaOptions.veggieBlackOlive, sut.CurrPizza.Toppings);
        }

        // TODO: Remove Topping from pizza
        [Fact]
        public void Test_RemoveToppingFromPizza()
        {
            sut.CreatePizza();
            sut.RemoveToppingFromPizza(pi.EPizzaOptions.cheeseCheddar);

            Assert.True(sut.CurrPizza.Toppings.Count == 1);
            Assert.DoesNotContain(pi.EPizzaOptions.cheeseCheddar, sut.CurrPizza.Toppings);
        }

        // TODO: Adjust Crust Size
        [Fact]
        public void Test_AdjustCrustOfPizza()
        {
            var crust = pi.EPizzaOptions.crustChicago;
            var sut = new pi.Pizza(pi.EPizzaOptions.crustRegular, pi.EPizzaOptions.sizeMedium);
            sut.Crust = crust;

            Assert.True(sut.Crust == crust);
            Assert.False(sut.Crust == pi.EPizzaOptions.crustRegular);
        }

        // TODO: Change Crust Type
        [Fact]
        public void Test_AdjustSizeOfPizza()
        {
            var size = pi.EPizzaOptions.sizeSmall;
            var sut = new pi.Pizza(pi.EPizzaOptions.crustRegular, pi.EPizzaOptions.sizeExtraLarge);
            sut.Size = size;

            Assert.True(sut.Size == size);
            Assert.False(sut.Size == pi.EPizzaOptions.sizeExtraLarge);
        }

        // TODO: Test that a Pizza can be added to Pizzas
        [Fact]
        public void Test_AddPizzaToPizzas()
        {
            var expected = new pi.Pizza(pi.EPizzaOptions.crustThin, pi.EPizzaOptions.sizeSmall);
            sut.Pizzas.Add(expected);
            var actual = sut.Pizzas;

            Assert.True(sut.Pizzas.Count == 1);
            Assert.Contains(expected, actual);
        }

        // TODO: Test that a Pizza can be removed from Pizzas
        [Fact]
        public void Test_RemovePizzaFromPizzas()
        {
            var expected = new pi.Pizza(pi.EPizzaOptions.crustThin, pi.EPizzaOptions.sizeSmall);
            sut.Pizzas.Add(expected);
            sut.Pizzas.Remove(expected);
            var actual = sut.Pizzas;

            Assert.True(sut.Pizzas.Count == 0);
            Assert.DoesNotContain(expected, actual);
        }

        // TODO: Get Specific Pizza from Pizzas
        [Fact]
        public void Test_GetPizzaFromPizzas()
        {
            var expected = new pi.Pizza(pi.EPizzaOptions.crustThin, pi.EPizzaOptions.sizeSmall);
            sut.Pizzas.Add(expected);
            var actual = sut.Pizzas;

            Assert.True(sut.Pizzas.Count == 1);
            Assert.Contains(expected, actual);
        }
    }
}
