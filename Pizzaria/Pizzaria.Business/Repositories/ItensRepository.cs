using Pizzaria.Business.Interfaces;
using Pizzaria.Data;
using Pizzaria.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Business.Repositories
{
    public class ItensRepository<Itens> : IRepository<Itens> where Itens : class, IEntity
    {
        private readonly DataContext _context;

        public ItensRepository(DataContext context) => _context = context;

        public void Create(Itens entity)
        {
            _context.Set<Itens>().Add(entity);
        }

        public void Delete(Itens entity)
        {
            _context.Set<Itens>().Remove(entity);
        }

        public void Edit(Itens entity)
        {
            var editedEntity = _context.Set<Itens>().FirstOrDefault(e => e.Id == entity.Id);
            editedEntity = entity;
        }

        public IEnumerable<Itens> Filter()
        {
            return _context.Set<Itens>();
        }

        public IEnumerable<Itens> Filter(Func<Itens, bool> predicate)
        {
            return _context.Set<Itens>().Where(predicate);
        }

        public Itens GetById(int id)
        {
            return _context.Set<Itens>().FirstOrDefault(e => e.Id == id);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
