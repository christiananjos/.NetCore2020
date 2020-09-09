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

            //modelBuilder.Seeds();
        }

    }
}
