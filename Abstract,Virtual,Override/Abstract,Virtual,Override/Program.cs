using Abstract_Virtual_Override.Models;
using System.Reflection.Metadata;

namespace Abstract_Virtual_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car=new Car("nurlan","ad1","goy",12,6,4,true);
            Bicycle bicycle=new Bicycle("bmw","m10","qara",10,5,"bmx");
            //Car car1 = new Car("ramal", "qa32", "goy", 12, 6);
            //Bicycle bicycle1 = new Bicycle("amg", "g63", "qara", 10, 5);
            Vehicle[] vehicles = {car,  bicycle}; 
            


            foreach (var vehicle in vehicles)
            {
                car.GetInfo();
                car.DefineNatureHarmness();
                car.AverageSpeed();
                bicycle.GetInfo();
                bicycle.DefineNatureHarmness();
                bicycle.AverageSpeed();
            }
        }
    }
}
