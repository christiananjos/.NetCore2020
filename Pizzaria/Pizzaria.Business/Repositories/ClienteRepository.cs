using Pizzaria.Business.Interfaces;
using Pizzaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Business.Repositories
{
    public class ClienteRepository<Cliente> : IRepository<Cliente> where Cliente : class
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
            _context.Set<Cliente>().Update(entity);
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
            return (Cliente)_context.Clientes.Select(x=> x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
