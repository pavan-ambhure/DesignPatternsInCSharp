using System;
namespace DesignPattern.Iterator
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            Name = name;

        }
    }
}
