﻿using System;
namespace OOPAdvanced.ex4
{
    public class Manager : Employee
    {
        public Department Department { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Manager(string name, int age, double salary, Department department)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Department = department;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

        public override string GetContactInfo()
        {
            return $"Name:{Name}, Age:{Age}, Department:{Department}, Email:{Email}, Phone:{Phone}";
        }
    }
}
