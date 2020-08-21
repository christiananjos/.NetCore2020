using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Business.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
        void Edit(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
        void SaveChanges();
    }
}
