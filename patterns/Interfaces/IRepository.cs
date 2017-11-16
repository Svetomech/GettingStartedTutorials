using System.Collections.Generic;

namespace GettingStartedTutorials.CSharp.Patterns.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> ListAll();
        T Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}