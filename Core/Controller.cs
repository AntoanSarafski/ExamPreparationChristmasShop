using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {


        private BoothRepository booths;
        private List<string> allowedDelicacieTypes = new List<string>() { "Gingerbread", "Stolen" };
        private List<string> allowedCocktailTypes = new List<string>() { "Hibernation", "MulledWine" };
        private List<string> allowedCocktailSizes = new List<string>() { "Small", "Middle", "Large" };

        public Controller()
        {
            booths = new BoothRepository();
        }
        public string AddBooth(int capacity)
        {
            int boothsCount = booths.Models.Count;
            Booth booth = new Booth(boothsCount + 1, capacity);

            booths.AddModel(booth);

            return string.Format(OutputMessages.NewBoothAdded, booth.BoothId, capacity);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            ICocktail cocktail = null;

            if (!allowedCocktailTypes.Any(c => c == cocktailTypeName))
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);

            if (!allowedCocktailSizes.Any(c => c == size))
                return string.Format(OutputMessages.InvalidCocktailSize, size);

            if (booth.CocktailMenu.Models.Any(c => c.Name == cocktailName && c.Size == size))
                return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);

            if (cocktailTypeName == "Hibernation")
                cocktail = new Hibernation(cocktailName, size);
            else if (cocktailTypeName == "MulledWine")
                cocktail = new MulledWine(cocktailName, size);

            booth.CocktailMenu.AddModel(cocktail);
            return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            throw new NotImplementedException();
        }

        public string BoothReport(int boothId)
        {
            throw new NotImplementedException();
        }

        public string LeaveBooth(int boothId)
        {
            throw new NotImplementedException();
        }

        public string ReserveBooth(int countOfPeople)
        {
            throw new NotImplementedException();
        }

        public string TryOrder(int boothId, string order)
        {
            throw new NotImplementedException();
        }
    }
}
