using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 12, 15, 17 };

            if (ages[0] < ages[1] && ages[0] < ages[2])
            {
                Console.WriteLine(ages[0]);
            }
            else
                if (ages[1] < ages[2] && ages[1] < ages[0])
            {
                Console.WriteLine(ages[1]);
            }
            else
                Console.WriteLine(ages[2]);
            }
    
        }
    }

