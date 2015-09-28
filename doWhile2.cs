using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            do //ensures is run at least once
            {
                if (n <= 1) //condition with which to break
                {
                    break;
                }
                factorial *= n;
                n--;
            } while (true);
            Console.WriteLine("n!=" + factorial);

        }
    }
}
