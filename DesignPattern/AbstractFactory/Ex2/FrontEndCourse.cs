using System;
namespace DesignPattern.AbstractFactory.Ex2
{
	public class FrontEndCourse : ICourse
	{
		public FrontEndCourse()
		{
		}

        public string GetCourseName()
        {
            return "HTML, CSS, and Bootstrap";
        }
        public string GetCourseDuration()
        {
            return "6 Months";
        }
        public int GetCourseFee()
        {
            return 2000;
        }
    }
}

