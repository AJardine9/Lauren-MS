using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models.Pizza
{
    public class PizzaOptions
    {
        #region Private Toppings
        // Cheeses
        private readonly string _cheeseCheddar = "Cheddar Cheese";
        private readonly string _cheeseMozzarella = "Mozzarella Cheese";

        // Sauces
        private readonly string _sauceTomato = "Tomato Sauce";
        private readonly string _sauceMarinara = "Marinara Sauce";
        private readonly string _sauceAlfredo = "Alfredo Sauce";
        private readonly string _sauceBBQ = "BBQ Sauce";

        // Veggies
        private readonly string _veggieRedOnion = "Red Onions";
        private readonly string _veggieGreenPepper = "Green Peppers";
        private readonly string _veggieBlackOlive = "Black Olives";
        private readonly string _veggieGreenOlive = "Green Olives";
        private readonly string _veggieMushroom = "Mushrooms";
        private readonly string _veggieSpinach = "Spinach";
        private readonly string _veggiePineapple = "Pineapple";
        private readonly string _veggieTomato = "Tomatoes";


        // Meats
        private readonly string _meatPepperoni = "Pepperoni";
        private readonly string _meatBacon = "Bacon";
        private readonly string _meatSausage = "Sausage";
        private readonly string _meatHam = "Ham";
        private readonly string _meatEgg = "Egg";
        private readonly string _meatChicken = "Chicken";

        #endregion
        #region Private Pizza Sizes
        private readonly int _sizeSmall = 8;
        private readonly int _sizeMedium = 12;
        private readonly int _sizeLarge = 16;
        private readonly int _sizeExtraLarge = 20;

        #endregion
        #region Private Crust Type
        private readonly string _crustThin = "Thin Crust";
        private readonly string _crustRegular = "Regular Crust";
        private readonly string _crustCheese = "Cheese-filled Crust";
        private readonly string _crustChicago = "Chicago Style Crust";

        #endregion

        #region Public Toppings
        // Cheeses
        public string cheeseCheddar
        {
            get
            {
                return _cheeseCheddar;
            }
        }
        public string cheeseMozzarella
        {
            get
            {
                return _cheeseMozzarella;
            }
        }

        // Sauces
        public string sauceTomato
        {
            get
            {
                return _sauceTomato;
            }
        }
        public string sauceMarinara
        {
            get
            {
                return _sauceMarinara;
            }
        }
        public string sauceAlfredo
        {
            get
            {
                return _sauceAlfredo;
            }
        }
        public string sauceBBQ
        {
            get
            {
                return _sauceBBQ;
            }
        }

        // Veggies
        public string veggieRedOnion
        {
            get
            {
                return _veggieRedOnion;
            }
        }
        public string veggieGreenPepper
        {
            get
            {
                return _veggieGreenPepper;
            }
        }
        public string veggieBlackOlive
        {
            get
            {
                return _veggieBlackOlive;
            }
        }
        public string veggieGreenOlive
        {
            get
            {
                return _veggieGreenOlive;
            }
        }
        public string veggieMushroom
        {
            get
            {
                return _veggieMushroom;
            }
        }
        public string veggieSpinach
        {
            get
            {
                return _veggieSpinach;
            }
        }
        public string veggiePineapple
        {
            get
            {
                return _veggiePineapple;
            }
        }
        public string veggieTomato
        {
            get
            {
                return _veggieTomato;
            }
        }

        // Meats
        public string meatPepperoni
        {
            get
            {
                return _meatPepperoni;
            }
        }
        public string meatBacon
        {
            get
            {
                return _meatBacon;
            }
        }
        public string meatSausage
        {
            get
            {
                return _meatSausage;
            }
        }
        public string meatHam
        {
            get
            {
                return _meatHam;
            }
        }
        public string meatEgg
        {
            get
            {
                return _meatEgg;
            }
        }
        public string meatChicken
        {
            get
            {
                return _meatChicken;
            }
        }

        #endregion
        #region Public Pizza Sizes
        public int sizeSmall
        {
            get
            {
                return _sizeSmall;
            }
        }
        public int sizeMedium
        {
            get
            {
                return _sizeMedium;
            }
        }
        public int sizeLarge
        {
            get
            {
                return _sizeLarge;
            }
        }
        public int sizeExtraLarge
        {
            get
            {
                return _sizeExtraLarge;
            }
        }

        #endregion
        #region Public Crust Type
        public string crustThin
        {
            get
            {
                return _crustThin;
            }
        }
        public string crustRegular
        {
            get
            {
                return _crustRegular;
            }
        }
        public string crustCheese
        {
            get
            {
                return _crustCheese;
            }
        }
        public string crustChicago
        {
            get
            {
                return _crustChicago;
            }
        }

        #endregion
    }
}
