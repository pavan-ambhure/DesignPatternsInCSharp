using System;
namespace DesignPattern.AbstractFactory.Ex1
{
	public class RegularCar : ICar
	{
		public RegularCar()
		{
		}

        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }
}

