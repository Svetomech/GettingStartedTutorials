using System;
using System.Collections.Generic;
using GettingStartedTutorials.CSharp.Patterns.Entities;
using GettingStartedTutorials.CSharp.Patterns.Interfaces;

namespace GettingStartedTutorials.CSharp.Patterns.Data
{
    public class DbOrderRepository : IOrderRepository
    {
        public Order Add(Order item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order item)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}