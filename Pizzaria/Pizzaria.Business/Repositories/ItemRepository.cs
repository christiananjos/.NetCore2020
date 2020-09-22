using Pizzaria.Business.Interfaces;
using Pizzaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Business.Repositories
{
    public class ItemRepository<Item> : IRepository<Item> where Item : class
    {
        private readonly DataContext _context;

        public ItemRepository(DataContext context) => _context = context;

        public void Create(Item entity)
        {
            _context.Set<Item>().Add(entity);
        }

        public void Delete(Item entity)
        {
            _context.Set<Item>().Remove(entity);
        }

        public void Edit(Item entity)
        {
            _context.Set<Item>().Update(entity);
        }

        public IEnumerable<Item> GetAll()
        {
            return _context.Set<Item>();
        }

        public IEnumerable<Item> Filter(Func<Item, bool> predicate)
        {
            return _context.Set<Item>().Where(predicate);
        }

        public Item GetById(int id)
        {
            return (Item)_context.Clientes.Where(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
