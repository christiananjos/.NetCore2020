using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Business.Business
{
    public class ClienteBusiness
    {
        private readonly ClienteRepository<Cliente> _repository;

        public ClienteBusiness(ClienteRepository<Cliente> repository)
        {
            _repository = repository;
        }

        public void Cria(Cliente cliente)
        {
            try
            {
                _repository.Create(cliente);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o cliente \n" + ex.StackTrace);
            }

        }

        public void Atualiza(Cliente cliente)
        {
            try
            {
                _repository.Edit(cliente);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o cliente \n" + ex.StackTrace);
            }
        }

        public IEnumerable<Cliente> RetornaTodos()
        {
            try
            {
                var clientes = _repository.GetAll();

                if (clientes == null) return null;

                return clientes;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao retornar os clientes \n" + ex.StackTrace);
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

                throw new Exception("Erro ao retornar o cliente selecionado \n" + ex.StackTrace);
            }

        }

        public void Remove(Cliente cliente)
        {
            try
            {
                _repository.Delete(cliente);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao remover o cliente selecionado \n" + ex.StackTrace);
            }

        }
    }
}
