using System;
using System.Linq;

namespace GettingStartedTutorials.CSharp.Encapsulation
{
    static class Program
    {
        static void Main(string[] args)
        {
            var petya = new Customer("Petya");

            // Customers expose a method for adding an Order
            petya.AddOrderHooked(new Order("123"));

            // Trying to add a null Order should do nothing
            try { petya.AddOrderHooked(null); }
            catch { ArgumentNullException _; }

            petya.AddOrderHooked(new Order("456"));
            petya.AddOrderHooked(new Order("789"));

            // Trying to add an Order with an existing OrderNumber 
            // should replace the existing Order
            petya.AddOrderHooked(new Order("123", DateTime.Now.AddYears(-1)));

            // Orders should expose an OrderDate (which can be read/write)
            var maliciousOrder = new Order("666", new DateTime(6, 6, 6));
            petya.AddOrderHooked(maliciousOrder);
            maliciousOrder.Date = DateTime.Now.AddSeconds(-30);
            petya.AddOrderHooked(maliciousOrder);

            // Trying to add an order with an OrderDate in the future 
            // should do nothing
            try { petya.AddOrderHooked(new Order("231", DateTime.Now.AddDays(1))); }
            catch { ArgumentOutOfRangeException _; }
        }

        static void AddOrderHooked(this Customer self, Order order)
        {
            self.AddOrder(order);
            DisplayOrders(self);

            void DisplayOrders(Customer customer)
            {
                Console.WriteLine($"There are currently {customer.Orders.Count} orders for {customer.Name}. Displaying...");
                customer.Orders.ToList().ForEach(Console.WriteLine);
            }
        }
    }
}
