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

                throw new Exception("Erro ao gravar o pedido \n" + ex.StackTrace);
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

                throw new Exception("Erro ao atualizar o pedido \n" + ex.StackTrace);
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

                throw new Exception("Erro ao retornar os pedidos \n" + ex.StackTrace);
            }


        }

        public Pedido RetornaPorId(int id)
        {
            try
            {
                var pedido = _repository.GetById(id);

                if (pedido == null) return null;

                return pedido;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao retornar o pedido selecionado \n" + ex.StackTrace);
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

                throw new Exception("Erro ao remover o pedido \n" + ex.StackTrace);
            }

        }

    }
}
