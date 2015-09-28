using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trollProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthyear!");
            string bYear = Console.ReadLine();
            int x = int.Parse(bYear);
            //int x = Convert.ToInt32(Console.ReadLine());
            int y = Math.Abs(1994 - x);
            if (y >= 21)
            {
                Console.WriteLine("legal");
            }
            else
            {
                Console.WriteLine("Illegal");
            }

            Console.WriteLine("This is how we do it");

        }
    }
}
