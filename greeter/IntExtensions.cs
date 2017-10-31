using System;

namespace Svetomech.Utilities.Extensions
{
    public static class IntExtensions
    {
        public static bool In(this int number, int lowerBound, int upperBound) => 
            number >= lowerBound && number <= upperBound;
    }
}
