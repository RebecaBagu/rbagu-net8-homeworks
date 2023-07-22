using System;
namespace OOPAdvanced.ex4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    
        public Employee()
        {
        }

        public abstract double CalculateBonus();

        public virtual string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
