using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models.Pizza;

namespace PizzaStore.Domain.Models.Location
{
    public class Inventory
    {
        #region Field
        public List<EPizzaOptions> Ingredients { get; set; }

        private Dictionary<EPizzaOptions, double> price = new Dictionary<EPizzaOptions, double>()
        {
            // Cheese
            {EPizzaOptions.cheeseCheddar, 2},
            {EPizzaOptions.cheeseMozzarella, 2},

            // Sauce
            {EPizzaOptions.sauceAlfredo, 1},
            {EPizzaOptions.sauceBBQ, 1},
            {EPizzaOptions.sauceMarinara, 1},
            {EPizzaOptions.sauceTomato, 1},

            // Veggies
            {EPizzaOptions.veggieBlackOlive, 0.75},
            {EPizzaOptions.veggieGreenOlive, 0.75},
            {EPizzaOptions.veggieGreenPepper, 0.75},
            {EPizzaOptions.veggieMushroom, 0.75},
            {EPizzaOptions.veggiePineapple, 0.75},
            {EPizzaOptions.veggieRedOnion, 0.75},
            {EPizzaOptions.veggieSpinach, 0.75},
            {EPizzaOptions.veggieTomato, 0.75},

            // Meats
            {EPizzaOptions.meatBacon, 3},
            {EPizzaOptions.meatChicken, 3},
            {EPizzaOptions.meatEgg, 2},
            {EPizzaOptions.meatHam, 2},
            {EPizzaOptions.meatPepperoni, 2},
            {EPizzaOptions.meatSausage, 3},

            // Sizes
            {EPizzaOptions.sizeExtraLarge, 10},
            {EPizzaOptions.sizeLarge, 8.50},
            {EPizzaOptions.sizeMedium, 6},
            {EPizzaOptions.sizeSmall, 4.50},

            // Crust
            {EPizzaOptions.crustCheese, 2},
            {EPizzaOptions.crustChicago, 2},
            {EPizzaOptions.crustRegular, 1},
            {EPizzaOptions.crustThin, 0.50}
        };
        private Dictionary<EPizzaOptions, int> stock = new Dictionary<EPizzaOptions, int>()
        {
            // Cheese
            {EPizzaOptions.cheeseCheddar, 10},
            {EPizzaOptions.cheeseMozzarella, 10},

            // Sauce
            {EPizzaOptions.sauceAlfredo, 10},
            {EPizzaOptions.sauceBBQ, 10},
            {EPizzaOptions.sauceMarinara, 10},
            {EPizzaOptions.sauceTomato, 10},

            // Veggies
            {EPizzaOptions.veggieBlackOlive, 10},
            {EPizzaOptions.veggieGreenOlive, 10},
            {EPizzaOptions.veggieGreenPepper, 10},
            {EPizzaOptions.veggieMushroom, 10},
            {EPizzaOptions.veggiePineapple, 10},
            {EPizzaOptions.veggieRedOnion, 10},
            {EPizzaOptions.veggieSpinach, 10},
            {EPizzaOptions.veggieTomato, 10},

            // Meats
            {EPizzaOptions.meatBacon, 10},
            {EPizzaOptions.meatChicken, 10},
            {EPizzaOptions.meatEgg, 10},
            {EPizzaOptions.meatHam, 10},
            {EPizzaOptions.meatPepperoni, 10},
            {EPizzaOptions.meatSausage, 10},

            // Sizes
            {EPizzaOptions.sizeExtraLarge, 10},
            {EPizzaOptions.sizeLarge, 10},
            {EPizzaOptions.sizeMedium, 10},
            {EPizzaOptions.sizeSmall, 10},

            // Crust
            {EPizzaOptions.crustCheese, 10},
            {EPizzaOptions.crustChicago, 10},
            {EPizzaOptions.crustRegular, 10},
            {EPizzaOptions.crustThin, 10}
        };
        #endregion
        #region Constructor
        public Inventory()
        {
            Ingredients = new List<EPizzaOptions>(stock.Keys);
        }
        #endregion
        #region Methods
        public double GetPrice(EPizzaOptions option)
        {
            double optionPrice = price[option];
            return optionPrice;
        }

        public void SetPrice(EPizzaOptions option, double value)
        {
            if (value >= 0)
            { 
                price[option] = value;
            }
        }

        public int GetStock(EPizzaOptions option)
        {
            int optionPrice = stock[option];
            return optionPrice;
        }

        public void Restock(EPizzaOptions option, int value)
        {
            if (value >= 0)
            {
                stock[option] = value;
            }
        }

        public bool UseOption(EPizzaOptions option)
        {
            if (stock[option] > 0)
            {
                stock[option] -= 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
