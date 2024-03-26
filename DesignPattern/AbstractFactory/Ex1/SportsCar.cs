using System;
namespace DesignPattern.AbstractFactory.Ex1
{
	public class SportsCar : ICar
	{
		public SportsCar()
		{
		}

        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsCar Details..");
        }
    }
}

