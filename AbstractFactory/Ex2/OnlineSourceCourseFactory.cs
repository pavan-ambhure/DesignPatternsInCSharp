using System;
namespace DesignPattern.AbstractFactory.Ex2
{
    public class OnlineSourceCourseFactory : ISourceCourseFactory
    {
        public ISource GetSource()
        {
            return new Online();
        }
        public ICourse GetCourse()
        {
            return new BackendCourse();
        }
    }
}

