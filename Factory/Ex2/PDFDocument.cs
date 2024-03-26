using System;
namespace DesignPattern.Factory.Ex2
{
	public class PDFDocument : Document
	{
		public PDFDocument()
		{
		}

        public override void Open()
        {
            Console.WriteLine("Opening PDF document.");
        }

        public override void Save()
        {
            Console.WriteLine("Saving PDF document.");
        }
    }
}

