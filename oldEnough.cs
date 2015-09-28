using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?!");
            string x = Console.ReadLine();
            if (x[0] == 'A' || x[0] == 'a')
            {
                Console.WriteLine("Go to the front of the Line!");
            
            }    
            else
            {
                Console.WriteLine("Get to the back!");

            }
        }
    }
}
