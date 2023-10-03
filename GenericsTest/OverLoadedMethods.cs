using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class OverLoadedMethods
    {
        // out put int array
        public static void DisplayArray(int[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        // out put double array
        public static void DisplayArray(double[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        // out put char array
        public static void DisplayArray(char[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
