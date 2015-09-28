using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] noun = { "She", "He", "It", "The cat", "The mongoose", "The orange", "The trampoline", "Musicians", "Programmers", "The shake" };
            string[] verb = { "ate", "barbequed", "chirped", "collided", "sang", "spoke", "cartwheeled", "dined", "watched", "directed" };
            string[] where = { "With the monkeys", "on the porch", "under the moon", "after the storm", "before the prince, over the lake", "in the gazebo", "between the lines", "during the festival", "with them all." };

            CryptoRandom rng = new CryptoRandom();
            int nouns = rng.Next(1, 11);
            StringBuilder sentence = new StringBuilder();

            sentence.Append(noun[nouns - 1]+" ");
            

            int verbs = rng.Next(1, 11);
            sentence.Append(verb[verbs - 1] + " ");


            int wheres = rng.Next(1, 11);
            sentence.Append(where[wheres - 1] + " ");
            Console.Write(sentence);

        }

        class CryptoRandom : RandomNumberGenerator
{
private static RandomNumberGenerator r;
        /// Will  Creates an instance of the default implementation of a cryptographic random number generator that can be used to generate random data.
        ///</summary>
        public CryptoRandom()
        {
            r = RandomNumberGenerator.Create();
        }
        ///<summary>
        /// Fills the elements of a specified array of bytes with random numbers.
        ///</summary>
        ///<param name=”buffer”>An array of bytes to contain random numbers.</param>
        public override void GetBytes(byte[] buffer)
        {
            r.GetBytes(buffer);
        }
        ///<summary>
        /// Returns a random number between 0.0 and 1.0.
        ///</summary>
        public double NextDouble()
        {
            byte[] b = new byte[4];
            r.GetBytes(b);
            return (double)BitConverter.ToUInt32(b, 0) / UInt32.MaxValue;
        }
        ///<summary>
        /// Returns a random number within the specified range.
        ///</summary>
        ///<param name=”minValue”>The inclusive lower bound of the random number returned.</param>
        ///<param name=”maxValue”>The exclusive upper bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        public int Next(int minValue, int maxValue)
        {
            return (int)Math.Round(NextDouble() * (maxValue - minValue - 1)) +minValue;
        }
        ///<summary>
        /// Returns a nonnegative random number.
        ///</summary>
        public int Next()
        {
            return Next(0, Int32.MaxValue);
        }
        ///<summary>
        /// Returns a nonnegative random number less than the specified maximum
        ///<param name=”maxValue”>The inclusive upper bound of the random number returned. maxValue must be greater than or equal 0</param>
        public int Next(int maxValue)
        {
            return Next(0, maxValue);
        }
    }
}

}