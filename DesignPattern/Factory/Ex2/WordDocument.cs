using System;
namespace DesignPattern.Factory.Ex2
{
	public class WordDocument : Document
	{
        public override void Open()
        {
            Console.WriteLine("Opening Word document.");
        }

        public override void Save()
        {
            Console.WriteLine("Saving Word document.");
        }
    }
}

