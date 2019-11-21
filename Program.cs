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
            foreach( string fruit in LFruits )
            {
                Console.WriteLine($"{fruit}");
            }

        }
    }
}
