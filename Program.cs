using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_07.LINQ.Restriction_Filtering_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = from fruit in fruits
                where fruit.StartsWith("L")
                orderby fruit ascending
                select fruit;

            Console.WriteLine("Fruits, that start with the letter L:");
            foreach( string fruit in LFruits )
            {
                Console.WriteLine($"{fruit}");
            }
            Console.Write("\n");

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where( n => n % 4 == 0 || n % 6 == 0).ToList();

            Console.WriteLine("Numbers, that are multiples of 4 or 6:");
            foreach( int n in fourSixMultiples )
            {
                Console.WriteLine($"{n}");
            }
        }
    }
}
