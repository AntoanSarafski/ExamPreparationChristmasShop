using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        public int BoothId => throw new NotImplementedException();

        public int Capacity => throw new NotImplementedException();

        public IRepository<IDelicacy> DelicacyMenu => throw new NotImplementedException();

        public IRepository<ICocktail> CocktailMenu => throw new NotImplementedException();

        public double CurrentBill => throw new NotImplementedException();

        public double Turnover => throw new NotImplementedException();

        public bool IsReserved => throw new NotImplementedException();

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
