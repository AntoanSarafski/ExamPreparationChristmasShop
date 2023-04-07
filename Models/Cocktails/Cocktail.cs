using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail : ICocktail
    {
        private string name;
        private string size;
        private double price;
        private string[] allowedSizeValues = new string[] { "Small", "Middle", "Large" };

        public string Name 
        {
            get => name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }

        public string Size 
        {
            get => size;
            private set => size = value;
        }

        public double Price 
        {
            get => price;
            private set
            {
                if (Size == "Large")
                {
                    price = value;
                }
                else if (Size == "Middle")
                {
                    price = 2* (value / 3.0);
                }
                else
                {
                    price = value / 3.0;
                }
            }
        }
    }
}
