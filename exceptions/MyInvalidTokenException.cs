using System;

namespace GettingStartedTutorials.CSharp.Exceptions
{
    public class InvalidTokenException : ArgumentException
    {
        public InvalidTokenException() : base("Invalid token.")
        { }
    }
}