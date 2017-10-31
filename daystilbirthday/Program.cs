using System;

namespace GettingStartedTutorials.CSharp.DatesTimes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input the date of your birthday: ");
            var birthDate = DateTime.Parse(Console.ReadLine());

            var age = DateTime.Today - birthDate;
            var ageInDays = age.TotalDays;
            Console.WriteLine($"You're {ageInDays} days old, sucker");

            var daysToAnniversary = 10000 - (ageInDays % 10000);
            var anniversary = DateTime.Today.AddDays(daysToAnniversary);
            Console.WriteLine($"Your next 10000 days anniversary: {anniversary.ToShortDateString()}");
        }
    }
}
