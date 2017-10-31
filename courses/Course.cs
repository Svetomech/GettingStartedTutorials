using System;
using System.Collections.Generic;

namespace GettingStartedTutorials.CSharp.Accessibility
{
    public class Course
    {
        private IEnumerable<Student> enrolledStudents;

        public Course(IEnumerable<Student> enrolledStudents)
        {
            this.enrolledStudents = enrolledStudents;
        }

        public string Name { get; set; } = "Software Engineering";

        public IEnumerable<string> GetRoster()
        {
            foreach (var student in enrolledStudents)
            {
                yield return student.RosterName;
            }
        }
    }
}