using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork05._04.Models
{
    abstract class Person
    {
        public string _name;
        public string _surname;
        public int _age;

        public string Name
        {
            get { return _name; }

            set
            { 
                if (value.Length > 2)
                {
                    _name = value;
                }
               
            }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public virtual int Age
        {
            get { return _age; }
            set
            { 
                if(Age> 0)
                {
                    Age = value;
                }
            }
        }
        public  Person(string name,string surname,int age)
        {
           Name= name;
            Surname= surname;   
            Age= age;
            Console.WriteLine("person ctor ise dusdu");
        }

        public abstract void GetInfo();
        

    }
}
