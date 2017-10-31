using System;

namespace GettingStartedTutorials.CSharp.Accessibility
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth)
            : base(firstName, lastName, dateOfBirth)
        { }

        public string RosterName => $"{this.LastName}, {this.FirstName}";
        public string SchoolName { get; set; }
    }
}