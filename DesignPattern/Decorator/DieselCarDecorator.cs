using System;
namespace DesignPattern.Decorator
{
	public class DieselCarDecorator : CarDecorator
	{
		public DieselCarDecorator(ICar car) : base(car)
        {
		}

        public override ICar ManufactureCar()
        {
            //First Call the Concrete Components ManufactureCar Method 
            car.ManufactureCar();
            //Then Add a Petrol Engine by calling the AddEngine Method
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Disel Engine";
                Console.WriteLine("DiselCarDecorator added Disel Engine to the Car : " + car);
            }
        }
    }
}

