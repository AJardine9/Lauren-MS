using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class PizzaOptions
    {
        #region Toppings
        // Cheeses
        public string cheeseCheddar { get; } = "Cheddar Cheese";
        public string cheeseMozzarella { get; } = "Mozzarella Cheese";

        // Sauces
        public string sauceTomato { get; } = "Tomato Sauce";
        public string sauceMarinara { get; } = "Marinara Sauce";
        public string sauceAlfredo { get; } = "Alfredo Sauce";
        public string sauceBBQ { get; } = "BBQ Sauce";

        // Veggies
        public string veggieRedOnion { get; } = "Red Onions";
        public string veggieGreenPepper { get; } = "Green Peppers";
        public string veggieBlackOlive { get; } = "Black Olives";
        public string veggieGreenOlive { get; } = "Green Olives";
        public string veggieMushroom { get; } = "Mushrooms";
        public string veggieSpinach { get; } = "Spinach";
        public string veggiePineapple { get; } = "Pineapple";
        public string veggieTomato { get; } = "Tomatoes";


        // Meats
        public string meatPepperoni { get; } = "Pepperoni";
        public string meatBacon { get; } = "Bacon";
        public string meatSausage { get; } = "Sausage";
        public string meatHam { get; } = "Ham";
        public string meatEgg { get; } = "Egg";
        public string meatChicken { get; } = "Chicken";

        #endregion
        #region Pizza Sizes
        public int sizeSmall { get; } = 8;
        public int sizeMedium { get; } = 12;
        public int sizeLarge { get; } = 16;
        public int sizeExtraLarge { get; } = 20;

        #endregion
        #region Crust Type
        public string crustThin { get; } = "Thin Crust";
        public string crustRegular { get; } = "Regular Crust";
        public string crustCheese { get; } = "Cheese Crust";
        public string crustChicago { get; } = "Chicago Style Crust";

        #endregion
    }
}
