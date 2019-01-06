using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Tests
{
    public class PizzaTest
    {
        public pi.Pizza sut { get; private set; }

        public PizzaTest()
        {
            
            sut = new pi.Pizza(pi.EPizzaOptions.crustRegular, pi.EPizzaOptions.sizeMedium);
            sut.AddTopping(pi.EPizzaOptions.veggieGreenOlive);
            sut.AddTopping(pi.EPizzaOptions.meatBacon);
        }

        // TODO: Test Pizza
        [Fact]
        public void Test_Pizza()
        {
            Assert.NotNull(sut);
            //Assert.True(sut.Price > 0);
        }

        // TODO: Test that Pizza has crust type
        [Fact]
        public void Test_PizzaCrust()
        {
            var expected = pi.EPizzaOptions.crustRegular;
            var actual = sut.Crust;

            Assert.Equal(expected, sut.Crust);
        }

        // TODO: Test that Pizza has crust size
        [Fact]
        public void Test_PizzaSize()
        {
            var expected = pi.EPizzaOptions.sizeMedium;
            var actual = sut.Size;

            Assert.Equal(expected, actual);
        }

        // Test that Pizza can have Toppings
        [Fact]
        public void Test_PizzaToppings()
        {
            var actual = sut.Toppings;

            Assert.NotNull(actual);
            Assert.True(sut.Toppings.Count <= 5);
        }

        // Test that Pizza can have Price
        [Fact]
        public void Test_PizzaPrice()
        {
            var actual = sut.GetPriceOfPizza(sut);

            Assert.True(actual > 0);
        }
    }
}
