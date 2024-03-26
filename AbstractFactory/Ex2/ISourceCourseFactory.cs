using System;
namespace DesignPattern.AbstractFactory.Ex2
{
	public interface ISourceCourseFactory
	{
        //Abstract Product A
        ISource GetSource();
        //Abstract Product B
        ICourse GetCourse();
    }
}

