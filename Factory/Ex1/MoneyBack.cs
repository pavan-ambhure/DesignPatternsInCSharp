using System;
namespace DesignPattern.Factory
{
	public class MoneyBack : ICreditCard
	{
		public MoneyBack()
		{
		}

        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}

