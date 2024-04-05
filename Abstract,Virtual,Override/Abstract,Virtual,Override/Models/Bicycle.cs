using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Virtual_Override.Models
{
    internal class Bicycle : Vehicle
    {
        public string _type;

        public Bicycle(string factoryname, string model, string color, double drivetime, double drivepath,string type) : base(factoryname, model, color, drivetime, drivepath)
        {
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }  
        }
        public override void GetInfo()
        {
            base.GetInfo();
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("none");
        }
        public override void ToString()
        {
            base.ToString();
        }
    }
}
