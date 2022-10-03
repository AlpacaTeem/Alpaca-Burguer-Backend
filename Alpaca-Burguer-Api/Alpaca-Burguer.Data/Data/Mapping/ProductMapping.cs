using Alpaca_Burguer.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alpaca_Burguer.Data.Data.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.MargemDeLucroVisada)
                .IsRequired();

            builder.Property(p => p.Preco)
                .IsRequired();

            builder.Property(p => p.Ingredients)
                .IsRequired();
        }
    }
}
