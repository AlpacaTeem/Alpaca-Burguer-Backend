using Alpaca_Burguer.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alpaca_Burguer.Data.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired();

            builder.Property(p => p.Email)
                .IsRequired();

            builder.Property(p => p.Password)
               .IsRequired();

            builder.Property(p => p.Role)
               .IsRequired();
        }
    }
}

