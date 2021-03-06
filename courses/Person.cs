using System;

namespace GettingStartedTutorials.CSharp.Accessibility
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public string FullName => $"{this.FirstName} {this.LastName}";
        public DateTime DateOfBirth { get; private set; }
        protected string LastName { get; private set; }
        protected string FirstName { get; private set; }

        public bool IsAnAdult()
        {
            var eighteenYearsAgo = DateTime.Today.AddYears(-18);
            return this.DateOfBirth < eighteenYearsAgo;
        }
    }
}