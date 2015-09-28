using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleenExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lightswitch = true; //on
            bool lamp = true; //on
            Console.WriteLine(lightswitch && lamp);
            Console.WriteLine(lightswitch || lamp);
            Console.WriteLine(!lightswitch);
            Console.WriteLine(lightswitch ^ lamp);
        }
    }
}
