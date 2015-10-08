using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> birthYears = new List<int>() {1993,1970,1955,1967 };
            birthYears.Add(1992);
            
            StreamWriter write = new StreamWriter("..\\docs.txt ");
            using (write)
            foreach (int year in birthYears)
            {
                    write.WriteLine(year);

            }

          


        }
    }
}
