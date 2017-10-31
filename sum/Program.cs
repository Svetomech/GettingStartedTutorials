using System;
using System.Linq;
using System.Collections.Generic;

namespace sum
{
    class Program
    {
        static void Main()
        {
            Console.Write("Numbers: ");
            var input = Console.ReadLine().Split();
            var numbersToSum = new List<int>(input.Select(int.Parse));
            Console.WriteLine($"Sum: {numbersToSum.Sum()}");
        }
    }
}
