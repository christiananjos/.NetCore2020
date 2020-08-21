using Pizzaria.Business.Interfaces;
using Pizzaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Business.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
           where TEntity : class, IEntity
    {
        private readonly DataContext _context;

        public Repository(DataContext context) => _context = context;

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void Delete(Guid id)
        {
            var entityToDelete = _context.Set<TEntity>().FirstOrDefault(e => e.Id == id);
            if (entityToDelete != null)
            {
                _context.Set<TEntity>().Remove(entityToDelete);
            }
        }

        public void Edit(TEntity entity)
        {
            var editedEntity = _context.Set<TEntity>().FirstOrDefault(e => e.Id == entity.Id);
            editedEntity = entity;
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<TEntity> Filter()
        {
            return _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public void SaveChanges() => _context.SaveChanges();
    }
}
