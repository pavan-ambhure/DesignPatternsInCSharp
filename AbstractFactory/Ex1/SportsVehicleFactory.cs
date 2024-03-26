using System;
namespace DesignPattern.AbstractFactory.Ex1
{
	public class SportsVehicleFactory : IVehicleFactory
	{
		public SportsVehicleFactory()
		{
		}

        public IBike CreateBike()
        {
            return new SportsBike();
        }

        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}

