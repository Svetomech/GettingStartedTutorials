using System;
using System.Collections.Generic;

namespace GettingStartedTutorials.CSharp.Classes
{
    class Program
    {
        static void Main()
        {
            var doeAddress = new Address
            {
                StreetAddress = "123 Main Street",
                City = "Sometown",
                State = "OH",
                PostalCode = "12345",
                Country = "United States"
            };
            var johnDoe = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                ShippingAddress = doeAddress
            };
            var janeDoe = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                ShippingAddress = doeAddress
            };

            var acme = new Company
            {
                Name = "Acme, Inc.",
                ShippingAddress = new Address
                {
                    StreetAddress = "456 Submain Street",
                    City = "Othercity",
                    State = "SE",
                    PostalCode = "67890",
                    Country = "Canada"
                }
            };

            var entities = new List<Entity> { johnDoe, janeDoe, acme };

            entities.ForEach(Console.WriteLine);
        }
    }
}
