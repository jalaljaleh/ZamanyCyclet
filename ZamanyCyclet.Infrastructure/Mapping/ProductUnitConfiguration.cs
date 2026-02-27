using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Infrastructure.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using ZamanyCyclet.Domain;

    public class ProductUnitConfiguration : EntityTypeConfiguration<ProductUnit>
    {
        public ProductUnitConfiguration()
        {
            ToTable("ProductUnits");

            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80);
            HasIndex(x => x.Name)
                .IsUnique();

            Property(x => x.Symbol)
                .IsRequired()
                .HasMaxLength(20);

            HasIndex(x => x.Symbol)
                .IsUnique();

            Property(x => x.IsDecimal)
                .IsRequired();


        }
    }
}
