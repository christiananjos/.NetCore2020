using Pizzaria.Model.Interfaces;

namespace Pizzaria.Model.Models
{
    public class Item : IEntity
    {

        public int Id { get; set; }

        public string Descrição { get; set; }

        public double Valor { get; set; }


    }
}
