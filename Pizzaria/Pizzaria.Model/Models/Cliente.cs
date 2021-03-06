﻿namespace Pizzaria.Model.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
    }
}
