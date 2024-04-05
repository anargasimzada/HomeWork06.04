using Interfaceclasswork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceclasswork
{
    internal class Calculate : IAdd, IMultply, IDifference, IDivide
    {
        public float Add(float num1, float num2) => num1 + num2;
        public float Difference(float num1, float num2) => num1 - num2;
        public float Divide(float num1, float num2) => num1 / num2;
        public float Multply(float num1, float num2) => num1 * num2;

       
    }
}
