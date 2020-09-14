using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System;
using System.Collections.Generic;

namespace Pizzaria.Business.Business
{
    public class PedidoBusiness
    {
        private readonly PedidoRepository<Pedido> _repository;

        public PedidoBusiness(PedidoRepository<Pedido> repository)
        {
            _repository = repository;
        }

        public void Cria(Pedido pedido)
        {
            try
            {
                _repository.Create(pedido);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public void Atualiza(Pedido pedido)
        {
            try
            {
                _repository.Edit(pedido);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Pedido> RetornaTodos()
        {
            try
            {
                var pedidos = _repository.GetAll();

                if (pedidos == null) return null;

                return pedidos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
           
        }

        public void RetornaPorId(int id)
        {
            try
            {
                _repository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public void Remove(Pedido pedido)
        {
            try
            {
                _repository.Delete(pedido);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

    }
}
