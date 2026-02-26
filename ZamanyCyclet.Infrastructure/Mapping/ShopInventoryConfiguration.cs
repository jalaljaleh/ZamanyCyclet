using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Infrastructure.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using ZamanyCyclet.Domain;

    public class ShopInventoryConfiguration : EntityTypeConfiguration<ShopInventory>
    {
        public ShopInventoryConfiguration()
        {
            ToTable("ShopInventories");

            HasKey(x => x.Id);

            Property(x => x.Quantity)
                .IsRequired();

            Property(x => x.MinimumStock)
                .IsRequired();

            HasRequired(x => x.Shop)
                .WithMany(x => x.ShopInventories)
                .HasForeignKey(x => x.ShopId);

            HasRequired(x => x.Product)
                .WithMany(x => x.ShopInventories)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
