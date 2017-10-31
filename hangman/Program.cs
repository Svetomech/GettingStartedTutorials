using System;
using IntExtensions;

namespace hangman
{
    class Program
    {
        private const int lowerBound = 1;
        private const int upperBound = 100;
        private static readonly Random random = new Random();

        static void Main()
        {
            int correctNumber = random.Next(lowerBound, upperBound + 1);
            string greetingTemplate = $"Please, guess a number between {lowerBound} and {upperBound}: ";
            string greeting = greetingTemplate;
            
            int guessedNumber;
            while (true)
            {
                Console.Write(greeting);

                bool isInputValid = int.TryParse(Console.ReadLine(), out guessedNumber);
                if (!isInputValid)
                {
                    greeting = greetingTemplate.Replace("number", "number".ToUpper());
                    continue;
                }

                bool isNumberInRange = guessedNumber.In(lowerBound, upperBound);
                if (!isNumberInRange)
                {
                    greeting = greetingTemplate.Replace("between", "between".ToUpper());
                    continue;
                }

                // Yay! Number is finally validated
                
                if (guessedNumber == correctNumber) break;
                Console.WriteLine(guessedNumber > correctNumber ? "You guessed high" : "You guessed low");

                greeting = greetingTemplate;
            }

            Console.WriteLine("Correct answer!");
        }
    }
}
