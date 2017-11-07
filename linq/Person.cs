using System;

namespace GettingStartedTutorials.CSharp.Linq
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}