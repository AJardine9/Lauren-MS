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
        public pi.PizzaOptions option { get; private set; }

        public PizzaTest()
        {
            option = new pi.PizzaOptions();
            
            sut = new pi.Pizza(option.crustRegular, option.sizeMedium, (double)5.50);
            sut.AddTopping(option.veggieGreenOlive);
            sut.AddTopping(option.meatBacon);
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
            var expected = option.crustRegular;
            var actual = sut.Crust;

            Assert.Contains(expected, sut.Crust);
        }

        // TODO: Test that Pizza has crust size
        [Fact]
        public void Test_PizzaSize()
        {
            var expected = option.sizeMedium;
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
            sut.GetPriceOfPizza(sut);
            var actual = sut.Price;

            Assert.True(sut.Price > 0);
        }
    }
}
