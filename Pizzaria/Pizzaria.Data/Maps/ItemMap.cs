using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Model.Models;

namespace Pizzaria.Data.Maps
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Descrição)
                    .HasColumnType("Varchar(150)");

            builder.Property(x => x.Valor)
                   .HasColumnType("Money");
        }
    }
}
