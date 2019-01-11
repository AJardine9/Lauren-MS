using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ord = PizzaStore.Domain.Models.Order;
using lo = PizzaStore.Domain.Models.Location;
using us = PizzaStore.Domain.Models.User;
using pi = PizzaStore.Domain.Models.Pizza;
using PizzaStore.Domain.Models;

namespace PizzaStore.Tests
{
    public class OrderTest
    {
        public ord.Order sut { get; private set; }
        private readonly us.User user;
        private readonly Address address;
        private readonly Address userAddress;
        private readonly lo.Location location;
        public pi.Crust crust { get; set; }
        public pi.Size size { get; set; }
        public pi.Toppings topping { get; set; }
        List<pi.Toppings> Toppings = new List<pi.Toppings>();

        public OrderTest()
        {
            address = new Address("1123 Fletcher St", "Tampa", "Florida");
            userAddress = new Address("51 Viking Oak", "Tampa", "Florida");

            location = new lo.Location(address);
            user = new us.User("admin", "password", userAddress);
            sut = new ord.Order(user.Username, location.OrderNumber, location.Address);

            crust = new pi.Crust();
            size = new pi.Size();
            topping = new pi.Toppings();
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
            sut.AddToppingToPizza(topping);
            sut.AddPizza();
            sut.CreatePizza();
            sut.AddToppingToPizza(topping);
            sut.AddPizza();

            Assert.True(sut.Pizzas.Count == 2);
            Assert.NotEmpty(sut.Pizzas);
            Assert.Contains(topping, sut.Pizzas[0].Toppings);
            Assert.Contains(topping, sut.Pizzas[1].Toppings);
        }

        // TODO: Test that Pizza can be created
        [Fact]
        public void Test_CreatePizza()
        {
            sut.CreatePizza();

            Assert.NotNull(sut.CurrPizza);
            Assert.IsType<pi.Pizza>(sut.CurrPizza);
            Assert.True(sut.CurrPizza.Crust == crust);
            Assert.True(sut.CurrPizza.Size == size);
            Assert.True(sut.CurrPizza.Toppings.Count == 2);
        }

        // TODO: Add Topping to pizza
        [Fact]
        public void Test_AddToppingToPizza()
        {
            sut.CreatePizza();
            bool actual = sut.AddToppingToPizza(topping);

            Assert.True(actual);
            Assert.Contains(topping, sut.CurrPizza.Toppings);
        }

        // TODO: Remove Topping from pizza
        [Fact]
        public void Test_RemoveToppingFromPizza()
        {
            sut.CreatePizza();
            sut.RemoveToppingFromPizza(topping);

            Assert.True(sut.CurrPizza.Toppings.Count == 1);
            Assert.DoesNotContain(topping, sut.CurrPizza.Toppings);
        }

        // TODO: Adjust Crust Size
        [Fact]
        public void Test_AdjustCrustOfPizza()
        {
            sut.CreatePizza();
            var actual = sut.AdjustCrustOfPizza(crust);

            Assert.True(actual);
            Assert.True(sut.CurrPizza.Crust == crust);
        }

        // TODO: Change Crust Type
        [Fact]
        public void Test_AdjustSizeOfPizza()
        {
            sut.CreatePizza();
            var actual = sut.AdjustSizeOfPizza(size);

            Assert.True(actual);
            Assert.True(sut.CurrPizza.Size == size);
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
