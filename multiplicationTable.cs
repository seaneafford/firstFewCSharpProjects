using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = 12;
            int numCollums = 12;

            for (int i = 1; i <=numRows ; i++)
            {
                for (int n = 1; n <= numCollums; n++)
                {
                    Console.Write(string.Format("{0,4}",(n* i)));
                }
                Console.WriteLine();
            }

        }
    }
}
