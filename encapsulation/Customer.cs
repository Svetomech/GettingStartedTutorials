using System;
using System.Collections.Generic;

namespace GettingStartedTutorials.CSharp.Encapsulation
{
    public class Customer
    {
        private List<Order> _orders = new List<Order>();

        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public IReadOnlyList<Order> Orders => _orders.AsReadOnly();

        public void AddOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            int existingOrderIndex = _orders.FindIndex(o => o.Number == order.Number);
            if (existingOrderIndex != -1)
            {
                _orders[existingOrderIndex] = order;
            }
            else
            {
                _orders.Add(order);
            }
        }
    }
}