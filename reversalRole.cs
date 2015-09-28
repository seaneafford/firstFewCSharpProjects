using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
   public class Program
    {
        static  Main(string[] args)
        {
            string text = "Racecar";
            string reversed = ExtractCapital(text);
            Console.WriteLine(reversed);
            

        }


        public static string ExtractCapital(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)

            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }

            }
            return result.ToString();
        }
    }

}
