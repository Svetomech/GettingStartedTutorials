using System;
using System.Collections.Generic;
using System.Linq;

namespace GettingStartedTutorials.CSharp.Linq
{
    public class Program
    {
        public static void Main()
        {
            var people = GenerateListOfPeople();

            Console.Write("Please, type age criteria (lower bound): ");
            int.TryParse(Console.ReadLine(), out int age);

            people.Where(x => x.Age > age).ToList().ForEach(Console.WriteLine);
        }

        public static IList<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

            return people;
        }
    }
}
