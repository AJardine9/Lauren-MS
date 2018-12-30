using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PizzaStore.Domain.Models.Pizza;
namespace PizzaStore.Tests
{
    public class PizzaOptionsTest
    {
                [Fact]
        public void Test_Cheese()
        {
            var expectedCheddar = "Cheddar";
            var expectedMozzarella = "Mozzarella";

            var sut = new PizzaOptions();

            Assert.Contains(expectedCheddar, sut.cheeseCheddar);
            Assert.Contains(expectedMozzarella, sut.cheeseMozzarella);
        }

        [Fact]
        public void Test_Sauce()
        {
            var expectedTomato = "Tomato";
            var expectedBBQ = "BBQ";
            var expectedMarinara = "Marinara";
            var expectedAlfredo = "Alfredo";

            var sut = new PizzaOptions();

            Assert.Contains(expectedTomato, sut.sauceTomato);
            Assert.Contains(expectedBBQ, sut.sauceBBQ);
            Assert.Contains(expectedMarinara, sut.sauceMarinara);
            Assert.Contains(expectedAlfredo, sut.sauceAlfredo);
        }

        [Fact]
        public void Test_Veggie()
        {
            var expectedRedOnion = "Red Onions";
            var expectedGreenPepper = "Green Peppers";
            var expectedBlackOlive = "Black Olives";
            var expectedGreenOlive = "Green Olives";
            var expectedMushroom = "Mushrooms";
            var expectedSpinach = "Spinach";
            var expectedPineapple = "Pineapple";
            var expectedTomato = "Tomato";

            var sut = new PizzaOptions();

            Assert.Contains(expectedRedOnion, sut.veggieRedOnion);
            Assert.Contains(expectedGreenPepper, sut.veggieGreenPepper);
            Assert.Contains(expectedBlackOlive, sut.veggieBlackOlive);
            Assert.Contains(expectedGreenOlive, sut.veggieGreenOlive);
            Assert.Contains(expectedMushroom, sut.veggieMushroom);
            Assert.Contains(expectedSpinach, sut.veggieSpinach);
            Assert.Contains(expectedPineapple, sut.veggiePineapple);
            Assert.Contains(expectedTomato, sut.veggieTomato);
        }

        [Fact]
        public void Test_Meat()
        {
            var expectedPepperoni = "Pepperoni";
            var expectedBacon = "Bacon";
            var expectedSausage = "Sausage";
            var expectedHam = "Ham";
            var expectedEgg = "Egg";
            var expectedChicken = "Chicken";

            var sut = new PizzaOptions();

            Assert.Contains(expectedPepperoni, sut.meatPepperoni);
            Assert.Contains(expectedBacon, sut.meatBacon);
            Assert.Contains(expectedSausage, sut.meatSausage);
            Assert.Contains(expectedHam, sut.meatHam);
            Assert.Contains(expectedEgg, sut.meatEgg);
            Assert.Contains(expectedChicken, sut.meatChicken);
        }

        [Fact]
        public void Test_Size()
        {
            var expectedSmall = 8;
            var expectedMedium = 12;
            var expectedLarge = 16;
            var expectedExtraLarge = 20;

            var sut = new PizzaOptions();

            Assert.Equal(expectedSmall, sut.sizeSmall);
            Assert.Equal(expectedMedium, sut.sizeMedium);
            Assert.Equal(expectedLarge, sut.sizeLarge);
            Assert.Equal(expectedExtraLarge, sut.sizeExtraLarge);
        }

        [Fact]
        public void Test_Crust()
        {
            var expectedThin = "Thin";
            var expectedRegular = "Regular";
            var expectedChicago = "Chicago";
            var expectedCheese = "Cheese";

            var sut = new PizzaOptions();

            Assert.Equal(expectedThin, sut.crustThin);
            Assert.Equal(expectedRegular, sut.crustRegular);
            Assert.Equal(expectedChicago, sut.crustChicago);
            Assert.Equal(expectedCheese, sut.crustCheese);
        }
    }
}
