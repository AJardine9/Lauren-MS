using System;
using System.Collections.Generic;
using System.Text;
using pizza = PizzaStore.Domain.Models;
using Xunit;
using PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Tests
{
    public class PizzaTest
    {
        // TODO: Test Pizza
        [Fact]
        public void Test_Pizza()
        {
            var sut = new Pizza();

            Assert.NotNull(sut);
            //Assert.True(sut.Price > 0);
        }

        // TODO: Test that Pizza has crust type
        [Fact]
        public void Test_PizzaCrust()
        {
            var expected = "Regular";
            var sut = new Pizza();
            var actual = sut.Crust;

            Assert.Contains(expected, sut.Crust);
        }

        // TODO: Test that Pizza has crust size
        [Fact]
        public void Test_PizzaSize()
        {
            var expected = 12;
            var sut = new Pizza();
            var actual = sut.Size;

            Assert.Equal(expected, actual);
        }

        // Test that Pizza can have Toppings
        [Fact]
        public void Test_PizzaToppings()
        {
            var sut = new Pizza();
            var actual = sut.Toppings;

            Assert.NotNull(actual);
            Assert.True(sut.Toppings.Count <= 5);
        }

        // Test that Pizza can have Price
        [Fact]
        public void Test_PizzaPrice()
        {
            var sut = new Pizza();
            sut.Get
            var actual = sut.Price;

            Assert.True(sut.Price > 0);
        }
    }
}
