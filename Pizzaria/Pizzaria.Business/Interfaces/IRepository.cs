using Pizzaria.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace Pizzaria.Business.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Filter(Func<T, bool> predicate);
        void SaveChanges();
    }
}
