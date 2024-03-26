using System;
namespace DesignPattern.AbstractFactory.Ex2
{
    public class Offline : ISource
    {
        public string GetSourceName()
        {
            return "Tutorials Class Room Training";
        }
    }
}

