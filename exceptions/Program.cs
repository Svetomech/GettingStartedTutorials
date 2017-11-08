using System;
using System.Collections.Generic;
using Svetomech.Utilities.Extensions;

namespace GettingStartedTutorials.CSharp.Exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            var permissions = new List<string>();
            
            try
            {
                permissions = (List<string>)GetAccessPermissions(args[0]);
            }
            catch (ArgumentException ex) when (TokenFilter(ex))
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception _)
            {
                Console.WriteLine("Usage: dotnet run [token]");
                Console.WriteLine("Usage: exceptions [token]");
            }

            foreach (var permission in permissions)
            {
                Console.WriteLine(permission);
            }

            bool TokenFilter(ArgumentException ex) =>
                ex is MissingTokenException || ex is InvalidTokenException;
        }

        public static IEnumerable<string> GetAccessPermissions(string token)
        {
            if (String.IsNullOrWhiteSpace(token))
            {
                throw new MissingTokenException();
            }
            if (!token.Length.In(12, 64))
            {
                throw new InvalidTokenException();
            }

            return new List<string> { "ReadLessons", "ReviewLessons" };
        }
    }
}
