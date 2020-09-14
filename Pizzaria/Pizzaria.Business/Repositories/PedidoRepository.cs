using Pizzaria.Business.Interfaces;
using Pizzaria.Data;
using Pizzaria.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Business.Repositories
{
    public class PedidoRepository<Pedido> : IRepository<Pedido> where Pedido : class, IEntity
    {
        private readonly DataContext _context;

        public PedidoRepository(DataContext context) => _context = context;

        public void Create(Pedido entity)
        {
            _context.Set<Pedido>().Add(entity);
        }

        public void Delete(Pedido entity)
        {
            _context.Set<Pedido>().Remove(entity);
        }

        public void Edit(Pedido entity)
        {
            var editedEntity = _context.Set<Pedido>().FirstOrDefault(e => e.Id == entity.Id);
            editedEntity = entity;
        }

        public IEnumerable<Pedido> GetAll()
        {
            return _context.Set<Pedido>();
        }

        public IEnumerable<Pedido> Filter(Func<Pedido, bool> predicate)
        {
            return _context.Set<Pedido>().Where(predicate);
        }

        public Pedido GetById(int id)
        {
            return _context.Set<Pedido>().FirstOrDefault(e => e.Id == id);
        }

        public void SaveChanges() => _context.SaveChanges();
    }
}
