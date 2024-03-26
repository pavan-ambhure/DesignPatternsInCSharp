using System;
namespace DesignPattern.AbstractFactory.Ex2
{
    public class Online : ISource
    {
        public string GetSourceName()
        {
            return "Tutorials Zoom Classes";
        }
    }
}

