using System;

namespace IntExtensions
{
    public static class Library
    {
        public static bool In(this int number, int lowerBound, int upperBound) => 
            number >= lowerBound && number <= upperBound;
    }
}
