using System;
using System.Collections.Generic;
using System.Text;

namespace Lociem.Interfaces
{
    public abstract class RepositoryManagerBase<T> : IRepository<T> where T : IEntity
    {
        protected List<T> _entities = new List<T>();
        
        public void Add(T item)
        {
            item.Id = GenerateId();
            _entities.Add(item);
        }
        
        public virtual void Delete(T item)
        {
            _entities.Remove(item);
        }
        
        public T? FindbyId(int id)
        {
            return _entities.Find(i => i.Id == id);
        }
        
        public List<T> GetAll()
        {
            return new List<T>(_entities);
        }

        public abstract List<T> FindbyName(string name);

        public abstract void Update(T item);

        protected int GenerateId()
        {
            if (_entities.Count == 0)
            {
                return 1;
            }
            else
            {
                return _entities.Max(i => i.Id) + 1;
            }
        }
    }
}
