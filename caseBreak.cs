using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            switch (letter)
            {
                case 'a':
                    Console.WriteLine("its an a");
                    break;
                case 'e':
                    Console.WriteLine("its an e");
                    break;
                default:
                    Console.WriteLine("undifined");
                    break;


            }
        }
    }
}
