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
            Console.WriteLine("How Old are you?!");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 18)

            {
                Console.WriteLine("How tall are you");
            }
            else
            {
                Console.WriteLine("You cant ride");
            }

                double y = Convert.ToDouble(Console.ReadLine());
                if (y>= 5.0)
                {
                    Console.WriteLine("Enter!!");
                } 

                else
                {
                    Console.WriteLine("DO NOT ENTER!!!");
                }
            }
        }
    }

