using System;
namespace DesignPattern.AbstractFactory.Ex2
{
	public class Driver
	{
		public static void call()
		{
            // Fetch the Front End Course and Source Details
            // Creating OfflineSourceCourseFactory instance
            ISourceCourseFactory offlineSourceCourseFactory = new OfflineSourceCourseFactory();
            //offlineSourceCourseFactory.GetCourse() will create and return FrondEndCourse object
            var course = offlineSourceCourseFactory.GetCourse();
            Console.WriteLine("Front End Course and Source Details");
            Console.WriteLine(course.GetCourseName());
            Console.WriteLine(course.GetCourseFee());
            Console.WriteLine(course.GetCourseDuration());
            //offlineSourceCourseFactory.GetSource() will create and return Offline object
            var source = offlineSourceCourseFactory.GetSource();
            Console.WriteLine(source.GetSourceName());
            //Same steps for Online Course and Source Details
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine("Back End Course and Source Details");
            ISourceCourseFactory onlineSourceCourseFactory = new OnlineSourceCourseFactory();
            course = onlineSourceCourseFactory.GetCourse();
            Console.WriteLine(course.GetCourseName());
            Console.WriteLine(course.GetCourseFee());
            Console.WriteLine(course.GetCourseDuration());
            source = onlineSourceCourseFactory.GetSource();
            Console.WriteLine(source.GetSourceName());
            Console.ReadKey();
        }
	}
}

