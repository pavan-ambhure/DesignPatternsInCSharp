using System;
namespace DesignPattern.Factory
{
	public interface ICreditCard
	{
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}

