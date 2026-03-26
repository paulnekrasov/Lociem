using Lociem.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lociem.Interfaces
{
    public abstract class RepositoryManagerBase<T> : IRepository<T> where T : IEntity
    {
        protected List<T> _entities = new List<T>();
        protected DataManager _dataManager;

        protected RepositoryManagerBase(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        
        public virtual void Add(T entity)
        {
            entity.Id = GenerateId();
            _entities.Add(entity);
        }
        
        public virtual void Delete(T entity)
        {
            _entities.Remove(entity);
        }
        
        public T? FindById(int id)
        {
            return _entities.Find(i => i.Id == id);
        }
        
        public List<T> GetAll()
        {
            return new List<T>(_entities);
        }

        public abstract List<T> FindByName(string name);

        public abstract void Update(T entity);

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

        public void LoadAll(List<T> entities)
        {
            _entities.Clear();
            _entities.AddRange(entities);
        }
    }
}
