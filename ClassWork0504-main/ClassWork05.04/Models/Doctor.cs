using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork05._04.Models
{
    internal class Doctor:Employee
    {
        public string _type;

        public Doctor(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public void Heal(Person person)
        {
            Console.WriteLine("healted");
        }

    }
}
