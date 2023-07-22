using System;
using System.Collections.Generic;

namespace OOPAdvanced.ex4
{
    public class Developer : Employee
    {
        public List<string> Skills { get; set; }
        public bool IsJunior { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Developer(string name, int age, double salary, List<string> skills, bool isJunior)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Skills = skills;
            IsJunior = isJunior;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }

        public override string GetContactInfo()
        {
            return $"Name:{Name}, Age:{Age}, Skills:{Skills}, Email:{Email}, Phone:{Phone}";
        }
    }
}
