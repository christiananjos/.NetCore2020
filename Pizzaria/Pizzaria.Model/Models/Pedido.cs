using Pizzaria.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace Pizzaria.Model.Models
{
    public class Pedido : IEntity
    {

        public int Id { get; set; }
        public string NomeUsuarioSistema { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        
        public int ValorFrete { get; set; }
        public double ValorTotalPedido { get; set; }
        public DateTime DtHoraPedido
        {
            get;set;
        }

        public List<Item> Itens { get; set; }

    }
}
