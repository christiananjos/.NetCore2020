using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Model.Models
{
    public class Pedido
    {
        public Pedido()
        {

        }

        public int Id { get; set; }
        public string NomeUsuarioSistema { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
        public int ValorFrete { get; set; }

        public double ValorTotalPedido { get; set; }

        public DateTime DtHoraPedido
        {
            get
            {
                return DateTime.Now;
            }
        }

        public List<Item> Itens { get; set; }

    }
}
