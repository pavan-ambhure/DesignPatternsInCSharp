using System;
namespace DesignPattern.AbstractFactory.Ex1
{
    public interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike();
        //Abstract Product B
        ICar CreateCar();
    }
}

