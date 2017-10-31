using System;

namespace factors
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1)
            {
                int candidateFactor = 2;
                while (candidateFactor <= number)
                {
                    if (number % candidateFactor == 0)
                    {
                        Console.Write(candidateFactor);
                        number /= candidateFactor;
                        Console.Write(number > 1 ? ", " : String.Empty);
                    }
                    candidateFactor++;
                }
            }
            Console.WriteLine();
        }
    }
}
