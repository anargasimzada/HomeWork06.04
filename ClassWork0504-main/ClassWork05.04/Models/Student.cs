using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork05._04.Models
{
    internal class Student:Person
    {
        public int _course;
        public string _uniname;
        private bool _isGraduated;

        public Student(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public int Course
        { 
            get { return _course; }

            set
            { 
                if(value>0 && value < 5)
                {
                    _course = value;
                    if (_course == 4)
                    {
                        _isGraduated = true;
                    }
                }
            }
        }
        public string UniName
        {
            get { return _uniname; }
            set { _uniname=value; }
        }
        public bool IsGraduated { get => _isGraduated; }
        //{
        //    get { return _isGraduated; }
        //}

        public override void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
