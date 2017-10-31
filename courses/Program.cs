using System;
using System.Collections.Generic;

namespace GettingStartedTutorials.CSharp.Accessibility
{
    public class Program
    {
        private static readonly Random rand = new Random();

        public static void Main()
        {
            var vova = new Student("Vladimir", "Shilenkov", new DateTime(1998, 8, 21));
            var andrey = new Student("Andrey", "Belyaev", new DateTime(1997, 8, 21));
            var fedya = new Student("Fedor", "Ivandikov", new DateTime(1997, rand.Next(1, 13), rand.Next(1, 29)));
            var vlad = new Student("Vladislav", "Zagidullin", new DateTime(1999, rand.Next(1, 13), rand.Next(1, 29)));
            var kolya = new Student("Nikolay", "Filippov", new DateTime(1999, rand.Next(1, 13), rand.Next(1, 29)));

            var SECourse = new Course(new List<Student> { andrey, vlad, kolya });
            var geologyCourse = new Course(new List<Student> { vova, andrey, fedya }) { Name = "Geology" };

            var courses = new List<Course> { SECourse, geologyCourse };
            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
                foreach (var studentName in course.GetRoster())
                {
                    Console.WriteLine("    " + studentName);
                }
                Console.WriteLine();
            }
        }
    }
}