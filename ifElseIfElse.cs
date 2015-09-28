using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the score?");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 && x <= 3)
            {
                Console.WriteLine(x * 10);
            }

            else
           if (x >= 4 && x <= 6)
            {
                Console.WriteLine(x * 100);
            }
            else
                if

               (x >= 7 && x <= 9) 
            {
                Console.WriteLine(x * 1000);
            }
            else 
            {
                Console.WriteLine("error!");
            }
            }
                   
               
                
            }
        }
    

