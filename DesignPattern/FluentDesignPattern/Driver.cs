using System;
namespace DesignPattern.FluentDesignPattern
{
	public class Driver
	{
		public static void Call()
		{
            FluentEmployee obj = new FluentEmployee();
            //Call Methods one by one using dot Operator whose Return Type is FluentEmployee
            obj.NameOfTheEmployee("Pavan Ambhure")
                    .Born("07/06/1996")
                    .WorkingOn("IT")
                    .StaysAt("Pune -India");
            //To See the Details call the ShowDetails Method
            obj.ShowDetails();
        }
	}
}

