using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public enum EPizzaOptions
    {
        #region Toppings
        // Cheeses
        cheddarCheese, cheeseMozzarella,

        // Sauces
        sauceTomato, sauceMarinara, sauceAlfredo, sauceBBQ,

        // Veggies
        veggieRedOnion, veggieGreenPepper, veggieBlackOlive, veggieGreenOlive, veggieMushroom, veggieSpinach, 
        veggiePineapple, veggieTomato,


        // Meats
        meatPepperoni, meatBacon, meatSausage, meatHam, meatEgg, meatChicken,

        #endregion
        #region Pizza Sizes
        sizeSmall, sizeMedium, sizeLarge, sizeExtraLarge,

        #endregion
        #region Crust Type
        crustThin, crustRegular, crustCheese,crustChicago

        #endregion
    }
}
