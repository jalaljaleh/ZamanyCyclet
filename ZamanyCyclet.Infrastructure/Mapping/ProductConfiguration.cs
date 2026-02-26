using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Infrastructure.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using ZamanyCyclet.Domain;

    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");

            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Brand)
                .HasMaxLength(100);

            Property(x => x.Category)
                .HasMaxLength(100);

            Property(x => x.Unit)
                .HasMaxLength(20);

            Property(x => x.PurchasePrice)
                .HasPrecision(18, 2);

            Property(x => x.SalePrice)
                .HasPrecision(18, 2);

            Property(x => x.CreatedAt)
                .IsRequired();

            HasMany(x => x.ShopInventories)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
