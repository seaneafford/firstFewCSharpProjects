using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 17)
            {
                Console.WriteLine("Enter");

            }
            else
            {
                Console.WriteLine("DO NOT ENTER!!!");
            }

        }   
         
    }
}
