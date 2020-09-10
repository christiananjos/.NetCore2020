using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Model.Models;

namespace Pizzaria.Data.Maps
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.NomeUsuarioSistema)
                    .IsRequired()
                    .HasColumnType("Varchar(50)");

            builder.Property(x => x.ValorFrete)
                   .HasColumnType("Money");

            builder.Property(x => x.ValorTotalPedido)
                  .HasColumnType("Money");

            builder.Property(x => x.DtHoraPedido)
                  .HasColumnType("Datetime");



        }
    }
}
