using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Model.Models;

namespace Pizzaria.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.NomeCliente)
                    .HasColumnType("Varchar(100)");

            builder.Property(x => x.Logradouro)
                   .HasColumnType("Varchar(200)");

            builder.Property(x => x.NumeroCasa)
                   .HasColumnType("Varchar(20)");

            builder.Property(x => x.Complemento)
                   .HasColumnType("Varchar(50)");

            builder.Property(x => x.Bairro)
                   .HasColumnType("Varchar(50)");

            builder.Property(x => x.UF)
                   .HasColumnType("Char(2)");

            builder.Property(x => x.Telefone)
                   .HasColumnType("Varchar(20)");
        }
    }
}
