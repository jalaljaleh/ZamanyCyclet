using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }

        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UnitId { get; set; }
        public virtual ProductUnit Unit { get; set; }

        public virtual ICollection<ShopInventory> ShopInventories { get; set; }




     
    }
}
