using System;

namespace GettingStartedTutorials.CSharp.Exceptions
{
    public class MissingTokenException : ArgumentException
    {
        public MissingTokenException() : base("Missing token.")
        { }
    }
}