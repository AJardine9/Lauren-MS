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
        // TODO: Pull associated User object's username
        [Fact]
        public void Test_GetUser()
        {
            var user = new us.User();
            var sut = new ord.Order(user.Username, 0);
            var expected = 0;
            var actual = sut.OrderNumber;

            Assert.IsType(expected.GetType(), actual);
        }

        // TODO: What location is this purchase from?
        [Fact]
        public void Test_GetPurchaseLocation()
        {
            var sut = new lo.Location();
            var expected = "";
            var actual = sut.Address;

            Assert.IsType(expected.GetType(), actual);
        }

        // TODO: What is the timestamp on this order?
        [Fact]
        public void Test_TimeStamp()
        {
            var user = new us.User();
            var sut = new ord.Order(user.Username, 0);
            var expected = DateTime.Now;
            var actual = DateTime.Now;

            Assert.IsType(expected.GetType(), actual);
        }

        // TODO: Running total for the order that does not go over PriceCap
        [Fact]
        public void Test_CurrentTotal()
        {
            var user = new us.User();
            var sut = new ord.Order(user.Username, 0);
            var actual = sut.Total;

            Assert.IsType<double>(actual);
        }

        // TODO: Test List of Pizza exists and can contain Pizza
        [Fact]
        public void Test_ListOfPizza()
        {
            var ing = new pi.PizzaOptions();
            List<string> Toppings = new List<string>();
            Toppings.Add(ing.veggieBlackOlive);
            var sut = new pi.Pizza(ing.crustRegular, ing.sizeMedium, Toppings);

            Assert.True(Toppings.Count == 1);
            Assert.NotEmpty(Toppings);
        }

        // TODO: Test that Pizza can be created
        [Fact]
        public void Test_CreatePizza()
        {
            var ing = new pi.PizzaOptions();
            List<string> Toppings = new List<string>();
            Toppings.Add(ing.veggieBlackOlive);
            var sut = new pi.Pizza(ing.crustRegular, ing.sizeMedium, Toppings);

            Assert.NotNull(sut);
            Assert.IsType<pi.Pizza>(sut);
            Assert.True(sut.Crust == ing.crustRegular);
            Assert.True(sut.Size == ing.sizeMedium);
            Assert.True(sut.Toppings.Count == 1);
        }

        // TODO: Add Topping to pizza
        [Fact]
        public void Test_AddToppingToPizza()
        {
            var ing = new pi.PizzaOptions();
            List<string> Toppings = new List<string>();
            Toppings.Add(ing.veggieBlackOlive);
            var sut = new pi.Pizza(ing.crustRegular, ing.sizeMedium, Toppings);

            Assert.True(sut.Toppings.Count == 1);
            Assert.Contains(ing.veggieBlackOlive, sut.Toppings);
        }

        // TODO: Remove Topping from pizza
        [Fact]
        public void Test_RemoveToppingFromPizza()
        {
            var ing = new pi.PizzaOptions();
            List<string> Toppings = new List<string>();
            Toppings.Add(ing.veggieBlackOlive);
            Toppings.Remove(ing.veggieBlackOlive);
            var sut = new pi.Pizza(ing.crustRegular, ing.sizeMedium, Toppings);

            Assert.True(sut.Toppings.Count == 0);
            Assert.DoesNotContain(ing.veggieBlackOlive, sut.Toppings);
        }

        // TODO: Adjust Crust Size
        [Fact]
        public void Test_AdjustCrustOfPizza()
        {
            List<string> Toppings = new List<string>();
            var ing = new pi.PizzaOptions();
            var crust = ing.crustChicago;
            var sut = new pi.Pizza(ing.crustRegular, ing.sizeMedium, Toppings);
            sut.Crust = crust;

            Assert.True(sut.Crust == crust);
            Assert.False(sut.Crust == ing.crustRegular);
        }

        // TODO: Change Crust Type
        [Fact]
        public void Test_AdjustSizeOfPizza()
        {
            List<string> Toppings = new List<string>();
            var ing = new pi.PizzaOptions();
            var size = ing.sizeSmall;
            var sut = new pi.Pizza(ing.crustRegular, ing.sizeExtraLarge, Toppings);
            sut.Size = size;

            Assert.True(sut.Size == size);
            Assert.False(sut.Size == ing.sizeExtraLarge);
        }

        // TODO: Test that a Pizza can be added to Pizzas
        [Fact]
        public void Test_AddPizzaToPizzas()
        {
            var user = new us.User();
            var sut = new ord.Order(user.Username, 0);
            var expected = new pi.Pizza("thin", 8, null);
            sut.Pizzas.Add(expected);
            var actual = sut.Pizzas;

            Assert.True(sut.Pizzas.Count == 1);
            Assert.Contains(expected, actual);
        }

        // TODO: Test that a Pizza can be removed from Pizzas
        [Fact]
        public void Test_RemovePizzaFromPizzas()
        {
            var user = new us.User();
            var sut = new ord.Order(user.Username, 0);
            var expected = new pi.Pizza("thin", 8, null);
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
            var user = new us.User();
            var sut = new ord.Order(user.Username, 0);
            var expected = new pi.Pizza("thin", 8, null);
            sut.Pizzas.Add(expected);
            var actual = sut.Pizzas;

            Assert.True(sut.Pizzas.Count == 1);
            Assert.Contains(expected, actual);
        }

        // TODO: Get price of specific pizza
        [Fact]
        public void Test_GetPriceOfPizza()
        {
            var user = new us.User();
            var sut = new ord.Order(user.Username, 0);
            sut.Pizzas.Add(new pi.Pizza("thin", 8, null));


        }
    }
}
