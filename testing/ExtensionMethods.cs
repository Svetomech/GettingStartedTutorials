using System;

namespace GettingStartedTutorials.CSharp.Testing
{
    public static class ExtensionMethods
    {
        public static int PlusFive(this int input)
        {
            return input + 5;
        }
    }
}