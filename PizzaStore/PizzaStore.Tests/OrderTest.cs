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
            sut.CreatePizza();
            sut.AddToppingToPizza(pi.EPizzaOptions.veggiePineapple);
            sut.AddPizza();
            sut.CreatePizza();
            sut.AddToppingToPizza(pi.EPizzaOptions.meatPepperoni);
            sut.AddPizza();

            Assert.True(sut.Pizzas.Count == 2);
            Assert.NotEmpty(sut.Pizzas);
            Assert.Contains(pi.EPizzaOptions.veggiePineapple, sut.Pizzas[0].Toppings);
            Assert.Contains(pi.EPizzaOptions.meatPepperoni, sut.Pizzas[1].Toppings);
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
            sut.CreatePizza();
            var actual = sut.AdjustCrustOfPizza(pi.EPizzaOptions.crustThin);

            Assert.True(actual);
            Assert.True(sut.CurrPizza.Crust == pi.EPizzaOptions.crustThin);
        }

        // TODO: Change Crust Type
        [Fact]
        public void Test_AdjustSizeOfPizza()
        {
            sut.CreatePizza();
            var actual = sut.AdjustSizeOfPizza(pi.EPizzaOptions.sizeLarge);

            Assert.True(actual);
            Assert.True(sut.CurrPizza.Size == pi.EPizzaOptions.sizeLarge);
        }

        // TODO: Test that a Pizza can be added to Pizzas
        [Fact]
        public void Test_AddPizzaToPizzas()
        {
            sut.CreatePizza();
            sut.AddPizza();

            Assert.True(sut.Pizzas.Count > 0);
        }

        // TODO: Test that a Pizza can be removed from Pizzas
        [Fact]
        public void Test_RemovePizzaFromPizzas()
        {
            sut.CreatePizza();
            sut.AddPizza();
            var expected = sut.GetPizzaFromPizzas(sut.Pizzas[0]);
            sut.RemovePizzaFromPizzas(expected);

            Assert.True(sut.Pizzas.Count == 0);
            Assert.DoesNotContain(expected, sut.Pizzas);
        }

        // TODO: Get Specific Pizza from Pizzas
        [Fact]
        public void Test_GetPizzaFromPizzas()
        {
            sut.CreatePizza();
            sut.AddPizza();
            var expected = sut.Pizzas[0];
            var actual = sut.GetPizzaFromPizzas(expected);

            Assert.NotNull(sut.CurrPizza);
            Assert.True(actual == expected);
        }
    }
}
