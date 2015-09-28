using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = int.Parse(Console.ReadLine());
            int y =  int.Parse(Console.ReadLine());
            decimal factorial = 1;

            if (x > y)
            {
                do
                {
                    if (x <= 1)
                    {
                        break;
                    }
                    factorial *= x;
                    x--;
                }
                while (x >= y);

                    Console.WriteLine("x!= " + factorial);
            }

            else if (y > x)
                do
                {
                    if (y >= 1)
                    {
                        break;
                    }
                    factorial *= y;
                    y--;
                }
                while (y >= x);
                Console.WriteLine("y! = " + factorial);


               
                
                    
               
                
            
           
        }
    }
}
