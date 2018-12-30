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
        [Fact]
        public void Test_PizzaCrust()
        {
            var sut = new Pizza();
            var actual = sut.Crust;
        }

        [Fact]
        public void Test_PizzaSize()
        {
            var sut = new Pizza();
            var actual = sut.Size;
        }

        [Fact]
        public void Test_PizzaToppings()
        {
        }
    }
}
