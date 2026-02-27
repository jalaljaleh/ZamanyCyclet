using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Infrastructure.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using ZamanyCyclet.Domain;

    public class ShopConfiguration : EntityTypeConfiguration<Shop>
    {
        public ShopConfiguration()
        {
            ToTable("Shops");

            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Address)
                .HasMaxLength(500);

            Property(x => x.Description)
               .HasMaxLength(200);

            Property(x => x.PostalCode)
                .HasMaxLength(20);

            Property(x => x.PhoneNumber)
               .HasMaxLength(40);

            Property(x => x.CreatedAt)
                .IsRequired();

            HasMany(x => x.ShopInventories)
                .WithRequired(x => x.Shop)
                .HasForeignKey(x => x.ShopId);
        }
    }
}
