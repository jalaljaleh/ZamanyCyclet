using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZamanyCyclet.Domain;
using ZamanyCyclet.Infrastructure.Mapping;

namespace ZamanyCyclet.Infrastructure
{
    public class HalunDbContext : DbContext
    {
        public HalunDbContext() : base($@"Data Source=(LocalDB)\MSSQLLocalDB;
                      AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HalunDb.mdf")};
                      Integrated Security=True;
                      Connect Timeout=30")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductUnit> ProductUnit { get; set; }
        public DbSet<ShopInventory> ShopInventories { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductUnitConfiguration());
            modelBuilder.Configurations.Add(new ShopConfiguration());
            modelBuilder.Configurations.Add(new ShopInventoryConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}