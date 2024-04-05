using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Virtual_Override.Models
{
    internal abstract class Vehicle
    {
        public string _factoryname;
        public string _model;
        public string _color;
        public double _drivetime;
        public double _drivepath;

        public string FactoryName
        {
            get { return _factoryname; }
            set { _factoryname = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public double DriveTime
        {
            get { return _drivetime; }
            set {
                 if (value > 0)
                 {
                    _drivetime = value;
                 }
                }
        }
        public double DrivePath
        {
            get { return _drivepath; }
            set 
            {
                if (value > 0)
                {
                    _drivepath = value;
                }
            }
        }

        protected Vehicle(string factoryname,string model,string color,double drivetime,double drivepath)
        {
            FactoryName = factoryname;
            Model = model;
            Color = color;
            DrivePath = drivepath;
            DriveTime = drivetime;

        }
        public void AverageSpeed()
        {
            double averagespeed=DrivePath/DriveTime;
            Console.WriteLine(averagespeed);
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DrivePath} {DriveTime}");
        }
        public virtual void ToString()
        {
            Console.WriteLine($"{FactoryName} {Model}");
        }
        
        public abstract void DefineNatureHarmness();
        
    }
}
