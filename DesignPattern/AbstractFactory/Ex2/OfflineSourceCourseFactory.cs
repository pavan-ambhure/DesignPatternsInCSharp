﻿using System;
namespace DesignPattern.AbstractFactory.Ex2
{
    public class OfflineSourceCourseFactory : ISourceCourseFactory
    {
        public ISource GetSource()
        {
            return new Offline();
        }
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }
    }
}

