using Alpaca_Burguer.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alpaca_Burguer.Data.Data.Mapping
{
    public class IngredientMapping : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.Preco)
                .IsRequired();
        }
    }
}
