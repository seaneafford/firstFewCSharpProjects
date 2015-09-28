using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong i;
            ulong g;
            for (i = 1, g=1 ; i <= 18446744073709551615, g <= 18446744073709551615; i++, g++)
           
            {
                Console.WriteLine(i);
             }
            ulong g;
            for (g = 1;; g++) 
            {
                Console.WriteLine(g);
            }

        }



    }
}
