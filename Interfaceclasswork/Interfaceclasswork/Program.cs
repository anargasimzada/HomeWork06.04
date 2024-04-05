using Interfaceclasswork.Interface;

namespace Interfaceclasswork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDivide c = new Calculate();
           
            Console.WriteLine(c.Divide(1, 5));

        }
    }
}
