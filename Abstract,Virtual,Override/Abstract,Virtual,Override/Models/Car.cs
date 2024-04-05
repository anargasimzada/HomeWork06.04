using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Virtual_Override.Models
{
    internal class Car : Vehicle
    {
        public int _doorcount;
        public bool _iselcticCar;

        public Car(string factoryname, string model, string color, double drivetime, double drivepath,int doorcount,bool iselectric) : base(factoryname, model, color, drivetime, drivepath)
        {
        }

        public int Doorcount
        {
            get { return _doorcount; }
            set 
            {
                if (value > 0)
                {
                    _doorcount = value;
                }
            }
        }
        public bool IsElctricCar
        {
            get { return _iselcticCar; }
            set 
            {
                if(_iselcticCar )
                {
                   _iselcticCar = true;
                }
                else
                {
                    _iselcticCar = false;
                }
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }
        public override void DefineNatureHarmness()
        {    if (IsElctricCar) 
            {
                Console.WriteLine("low");
            }
            else
            {
                Console.WriteLine("high");
            }
          
        }
        public override void ToString()
        {
            base.ToString();
        }
    }
}
