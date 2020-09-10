using Microsoft.EntityFrameworkCore;
using Pizzaria.Data.Maps;
using Pizzaria.Data.Seeds;
using Pizzaria.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pizzaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ItemMap());


            //Itens para os pedidos 
            modelBuilder.Entity<Item>().HasData(
                new List<Item>()
               {
                new Item(){ Id = 1, Descrição = "3 Queijos", Valor = 50},
                new Item(){ Id = 2, Descrição = "Frango com requeijão", Valor = 59.99},
                new Item(){ Id = 3, Descrição = "Mussarela", Valor = 42.50},
                new Item(){ Id = 4, Descrição = "Calabresa", Valor = 42.50},
                new Item(){ Id = 5, Descrição = "Pepperoni", Valor = 55},
                new Item(){ Id = 6, Descrição = "Portuguesa", Valor = 45},
                new Item(){ Id = 7, Descrição = "Veggie", Valor = 59.99},

                //Combinações
                new Item() { Id = 8, Descrição = "1/2 3 queijos + 1/2 Frango com requeijão", Valor = 109.99 },
                new Item() { Id = 9, Descrição = "1/2 3 queijos + 1/2 Mussarela", Valor = 92.50 },
                new Item() { Id = 10, Descrição = "1/2 3 queijos + 1/2 Calabresa", Valor = 92.50 },
                new Item() { Id = 11, Descrição = "1/2 3 queijos + 1/2 Pepperoni", Valor = 55 },
                new Item() { Id = 12, Descrição = "1/2 3 queijos + 1/2 Portuguesa", Valor = 95 },
                new Item() { Id = 13, Descrição = "1/2 3 queijos + 1/2 Veggie", Valor = 109.99 },
                new Item() { Id = 14, Descrição = "1/2 Frango com requeijão + Mussarela", Valor = 102.49 },
                new Item() { Id = 15, Descrição = "1/2 Frango com requeijão + Calabresa", Valor = 102.49 },
                new Item() { Id = 16, Descrição = "1/2 Frango com requeijão + Pepperoni", Valor = 114.99 },
                new Item() { Id = 17, Descrição = "1/2 Frango com requeijão + Portuguesa", Valor = 104.99 },
                new Item() { Id = 18, Descrição = "1/2 Frango com requeijão + Veggie", Valor = 119.98 },
                new Item() { Id = 19, Descrição = "1/2 Mussarela + Calabresa", Valor = 85.00 },
                new Item() { Id = 20, Descrição = "1/2 Mussarela + 1/2 Pepperoni", Valor = 97.50 },
                new Item() { Id = 21, Descrição = "1/2 Mussarela + 1/2 Portuguesa", Valor = 87.50 },
                new Item() { Id = 22, Descrição = "1/2 Mussarela + 1/2 Veggie", Valor = 102.49 },
                new Item() { Id = 23, Descrição = "1/2 Calabresa + 1/2 Pepperoni", Valor = 97.50 },
                new Item() { Id = 24, Descrição = "1/2 Calabresa + 1/2 Portuguesa", Valor = 87.50 },
                new Item() { Id = 25, Descrição = "1/2 Calabresa + 1/2 Veggie", Valor = 102.49 },
                new Item() { Id = 26, Descrição = "1/2 Pepperoni + 1/2 Portuguesa", Valor = 100 },
                new Item() { Id = 27, Descrição = "1/2 Pepperoni + 1/2 Veggie", Valor = 114.99 },
                new Item() { Id = 28, Descrição = "1/2 Portuguesa + 1/2 Veggie", Valor = 104.99 }}
            );

            //Clientes cadastrados
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = 1,
                    NomeCliente = "Christian",
                    Telefone = "1199299999",
                    Logradouro = "Estrada Dom João Nery",
                    NumeroCasa = "3551",
                    Complemento = "Bloco 6 Apto 11",
                    Bairro = "Jd Bartira",
                    Cep = "0851000",
                    Estado = "São Paulo",
                    UF = "SP"
                },
                new Cliente()
                {
                    Id = 2,
                    NomeCliente = "Douglas",
                    Telefone = "1199298888",
                    Logradouro = "Estrada Dom João Nery 2",
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
