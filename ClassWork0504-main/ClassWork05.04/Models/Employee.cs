using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork05._04.Models
{
    internal class Employee:Person
    {
        public double _salary;
        public double _experience;

        public override int Age { get => base.Age; set { if (value >= 18 && value < 65) {} }

        public double Salary
        {
            get { return _salary; }
            set 
            {
                if (value >= 350)
                {
                    _salary = value;
                }
            }
        }
        public double Experience
        {
            get { return _experience; }
            set { if (value >= 0) _experience = value; }
        }
        public Employee(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{ Name}");
        }
    }
}
