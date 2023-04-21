using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        private int boothId;
        private int capacity;
        private IRepository<IDelicacy> delicacyMenu;
        private IRepository<ICocktail> cocktailMenu;
        private double currentBill;
        private double turnover;
        private bool isReserved;

        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;
            Capacity = capacity;
            CocktailMenu = new CocktailRepository();
            DelicacyMenu = new DelicacyRepository();
        }

        public int BoothId 
        { 
            get => boothId;
            private set => boothId = value;
        }

        public int Capacity
        {
            get => capacity;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }
                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu
        {
            get => delicacyMenu;
            private set => delicacyMenu = value; 
        }


        public IRepository<ICocktail> CocktailMenu
        {
            get => cocktailMenu;
            private set => cocktailMenu = value;
        }


        public double CurrentBill
        { 
            get => currentBill;
        }

        public double Turnover
        { 
            get => turnover; 
        }

        public bool IsReserved
        { 
            get => isReserved;
        }

        public void ChangeStatus()
        {
            throw new NotImplementedException();
        }

        public void Charge()
        {
            throw new NotImplementedException();
        }

        public void UpdateCurrentBill(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
