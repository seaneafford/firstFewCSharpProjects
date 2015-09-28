using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 1.0f;
            double b = 0.33f;
            double sum = 1.33f;
            bool equal = (a + b == sum); //FALSE!!
            Console.WriteLine("a+b={0} sum={1} equal = {2} ", a+b, sum, equal);
        }
    }
}
