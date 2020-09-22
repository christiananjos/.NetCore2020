using Pizzaria.Business.Interfaces;
using Pizzaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Business.Repositories
{
    public class PedidoRepository<Pedido> : IRepository<Pedido> where Pedido : class
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
            _context.Set<Pedido>().Update(entity);
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
            return (Pedido)_context.Pedidos.Select(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
