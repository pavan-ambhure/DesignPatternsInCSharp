using System;
namespace DesignPattern.AbstractFactory.Ex1
{
	public class SportsBike : IBike
	{
		public SportsBike()
		{
		}

        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsBike Details..");
        }
    }
}

