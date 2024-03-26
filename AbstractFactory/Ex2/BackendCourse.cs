using System;
namespace DesignPattern.AbstractFactory.Ex2
{
	public class BackendCourse : ICourse
	{
        public string GetCourseDuration()
        {
            return "6 Months";
        }
        public int GetCourseFee()
        {
            return 1000;
        }
        public string GetCourseName()
        {
            return "C#, Java, and Python";
        }
    }
}

