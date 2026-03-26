using System.Collections.Generic;

namespace Lociem.Interfaces
{
    public interface IRepository<T> 
    {

        void Add(T item);
        void Delete(T item);
        void Update(T item);
        List<T> FindByName(string name); 
        T? FindById(int id);
        List<T> GetAll();
    }
}
