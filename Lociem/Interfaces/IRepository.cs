using Lociem.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Lociem.Interfaces
{
    public interface IRepository<T> 
    {

        void Add(T item);
        void Delete(T item);
        void Update(T item);
        List<T> FindbyName(string name); 
        T? FindbyId(int id);
        List<T> GetAll();
    }
}
