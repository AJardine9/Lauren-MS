using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ord = PizzaStore.Domain.Models.Order;

namespace PizzaStore.Tests
{
    public class OrderTest
    {
        // TODO: Pull associated User object's username
        [Fact]
        public void Test_GetUser()
        {
            var sut = new ord.Order();
            var expected = 0;
            var actual = sut.OrderNumber;

            Assert.IsType(expected.GetType(), actual);
        }

        // TODO: What location is this purchase from?
        [Fact]
        public void Test_GetPurchaseLocation()
        {

        }

        // TODO: What is the timestamp on this order?
        [Fact]
        public void Test_TimeStamp()
        {

        }

        // TODO: Running total for the order that does not go over PriceCap
        [Fact]
        public void Test_CurrentTotal()
        {
            var sut = new ord.Order();
            var actual = sut.Total;

            Assert.IsType<double>(actual);
        }

        // TODO: Test List of Pizza exists and can contain Pizza
        [Fact]
        public void Test_ListOfPizza()
        {
            
        }

        // TODO: Test that Pizza can be created
        [Fact]
        public void Test_CreatePizza()
        {

        }

        // TODO: Add Topping to pizza
        [Fact]
        public void Test_AddToppingToPizza()
        {

        }

        // TODO: Remove Topping from pizza
        [Fact]
        public void Test_RemoveToppingFromPizza()
        {

        }

        // TODO: Adjust Crust Size
        [Fact]
        public void Test_AdjustCrustOfPizza()
        {

        }

        // TODO: Change Crust Type
        [Fact]
        public void Test_AdjustSizeOfPizza()
        {

        }

        // TODO: Test that a Pizza can be added to Pizzas
        [Fact]
        public void Test_AddPizzaToPizzas()
        {
           
        }

        // TODO: Test that a Pizza can be removed from Pizzas
        [Fact]
        public void Test_RemovePizzaFromPizzas()
        {

        }

        // TODO: Get Specific Pizza from Pizzas
        [Fact]
        public void Test_GetPizzaFromPizzas()
        {

        }

        // TODO: Get price of specific pizza
        [Fact]
        public void Test_GetPriceOfPizza()
        {

        }
    }
}
