using Microsoft.EntityFrameworkCore;
using Pizzaria.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Data.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Itens para os pedidos 
            modelBuilder.Entity<Item>().HasData(
                new List<Item>()
                {  new Item(){ Descrição = "3 Queijos", Valor = 50},
                new Item(){ Descrição = "Frango com requeijão", Valor = 59.99},
                new Item(){ Descrição = "Mussarela", Valor = 42.50},
                new Item(){ Descrição = "Calabresa", Valor = 42.50},
                new Item(){ Descrição = "Pepperoni", Valor = 55},
                new Item(){ Descrição = "Portuguesa", Valor = 45},
                new Item(){ Descrição = "Veggie", Valor = 59.99},

                //Combinações
                new Item(){ Descrição = "1/2 3 queijos + 1/2 Frango com requeijão", Valor = 109.99},
                new Item(){ Descrição = "1/2 3 queijos + 1/2 Mussarela", Valor = 92.50},
                new Item(){ Descrição = "1/2 3 queijos + 1/2 Calabresa", Valor = 92.50},
                new Item(){ Descrição = "1/2 3 queijos + 1/2 Pepperoni", Valor = 55},
                new Item(){ Descrição = "1/2 3 queijos + 1/2 Portuguesa", Valor = 95},
                new Item(){ Descrição = "1/2 3 queijos + 1/2 Veggie", Valor = 109.99},
                new Item(){ Descrição = "1/2 Frango com requeijão + Mussarela", Valor = 102.49},
                new Item(){ Descrição = "1/2 Frango com requeijão + Calabresa", Valor = 102.49},
                new Item(){ Descrição = "1/2 Frango com requeijão + Pepperoni", Valor = 114.99},
                new Item(){ Descrição = "1/2 Frango com requeijão + Portuguesa", Valor = 104.99},
                new Item(){ Descrição = "1/2 Frango com requeijão + Veggie", Valor = 119.98},
                new Item(){ Descrição = "1/2 Mussarela + Calabresa", Valor = 85.00},
                new Item(){ Descrição = "1/2 Mussarela + 1/2 Pepperoni", Valor = 97.50},
                new Item(){ Descrição = "1/2 Mussarela + 1/2 Portuguesa", Valor = 87.50},
                new Item(){ Descrição = "1/2 Mussarela + 1/2 Veggie", Valor = 102.49},
                new Item(){ Descrição = "1/2 Calabresa + 1/2 Pepperoni", Valor = 97.50},
                new Item(){ Descrição = "1/2 Calabresa + 1/2 Portuguesa", Valor = 87.50},
                new Item(){ Descrição = "1/2 Calabresa + 1/2 Veggie", Valor = 102.49},
                new Item(){ Descrição = "1/2 Pepperoni + 1/2 Portuguesa", Valor = 100},
                new Item(){ Descrição = "1/2 Pepperoni + 1/2 Veggie", Valor = 114.99},
                new Item(){ Descrição = "1/2 Portuguesa + 1/2 Veggie", Valor = 104.99}
                }
            );

            //Clientes cadastrados
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    NomeCliente = "Christian",
                    Telefone = "1199299999",
                    Logradouro = "Estrada Com João Nery",
                    NumeroCasa = "3551",
                    Complemento = "Bloco 6 Apto 11",
                    Bairro = "Jd Bartira",
                    Cep = "0851000",
                    Estado = "São Paulo",
                    UF = "SP"
                },
                new Cliente()
                {
                    NomeCliente = "Christian owner 2",
                    Telefone = "1199298888",
                    Logradouro = "Estrada Com João Nery 2",
                    NumeroCasa = "3552",
                    Complemento = "Bloco 6 Apto 11",
                    Bairro = "Jd Bartira",
                    Cep = "0851000",
                    Estado = "São Paulo",
                    UF = "SP"
                }

            );
        }
    }
}
