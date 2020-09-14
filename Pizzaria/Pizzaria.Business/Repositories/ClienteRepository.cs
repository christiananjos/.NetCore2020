using Pizzaria.Business.Interfaces;
using Pizzaria.Data;
using Pizzaria.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Business.Repositories
{
    public class ClienteRepository<Cliente> : IRepository<Cliente> where Cliente : class, IEntity
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context) => _context = context;

        public void Create(Cliente entity)
        {
            _context.Set<Cliente>().Add(entity);
        }

        public void Delete(Cliente entity)
        {
            _context.Set<Cliente>().Remove(entity);
        }

        public void Edit(Cliente entity)
        {
            var editedEntity = _context.Set<Cliente>().FirstOrDefault(e => e.Id == entity.Id);
            editedEntity = entity;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Set<Cliente>();
        }

        public IEnumerable<Cliente> Filter(Func<Cliente, bool> predicate)
        {
            return _context.Set<Cliente>().Where(predicate);
        }

        public Cliente GetById(int id)
        {
            return _context.Set<Cliente>().FirstOrDefault(e => e.Id == id);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
