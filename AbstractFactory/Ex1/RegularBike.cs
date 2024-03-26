using System;
namespace DesignPattern.AbstractFactory.Ex1
{
	public class RegularBike : IBike
	{
		public RegularBike()
		{
		}

        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details..");
        }
    }
}

