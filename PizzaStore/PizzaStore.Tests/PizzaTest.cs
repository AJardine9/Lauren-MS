using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using pi = PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Tests
{
    public class PizzaTest
    {
        private readonly pi.Pizza sut;
        private readonly pi.Crust crust;
        private readonly pi.Size size;
        private readonly pi.Toppings toppings;

        public PizzaTest()
        {
            crust = new pi.Crust();
            size = new pi.Size();
            toppings = new pi.Toppings();

            sut = new pi.Pizza(crust, size);
            sut.AddTopping(toppings);
            sut.AddTopping(toppings);
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
            var expected = crust;
            var actual = sut.Crust;

            Assert.Equal(expected, sut.Crust);
        }

        // TODO: Test that Pizza has crust size
        [Fact]
        public void Test_PizzaSize()
        {
            var expected = size;
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
