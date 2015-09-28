using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 16)
            {
                Console.WriteLine("You are Old enough to drive!");
                if (x >= 18)
                {
                    Console.WriteLine("You are an adult");
                }
                
            }
            else

            {
                Console.WriteLine("Get outta here your a kid!");

            }

               
            }
               
        }
    }

