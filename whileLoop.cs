using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Write a number!");
            int x = a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("write another number");
            int y = b= Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                x = b; y = a;
            }
            int counter = x++;    
            while (counter<= y)
            {
                
                Console.WriteLine(counter++);
                
            }
                


            
                

            

            
                
            }
        }
    }

