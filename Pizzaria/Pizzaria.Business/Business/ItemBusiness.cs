using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System;
using System.Collections.Generic;

namespace Pizzaria.Business.Business
{
    public class ItemBusiness
    {
        private readonly ItemRepository<Item> _repository;

        public ItemBusiness(ItemRepository<Item> repository)
        {
            _repository = repository;
        }

        public void Cria(Item item)
        {
            try
            {
                _repository.Create(item);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o item \n" + ex.StackTrace);
            }

        }

        public void Atualiza(Item item)
        {
            try
            {
                _repository.Edit(item);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o item \n" + ex.StackTrace);
            }
        }

        public IEnumerable<Item> RetornaTodos()
        {
            try
            {
                var item = _repository.GetAll();

                if (item == null) return null;

                return item;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o item \n" + ex.StackTrace);
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

                throw new Exception("Erro ao atualizar o item \n" + ex.StackTrace);
            }

        }

        public void Remove(Item Item)
        {
            try
            {
                _repository.Delete(Item);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao remover o I=item \n" + ex.StackTrace);
            }

        }
    }
}
