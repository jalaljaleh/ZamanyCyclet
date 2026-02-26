using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Domain
{
    public class ShopInventory
    {
        public int Id { get; set; }

        public int ShopId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public int MinimumStock { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual Product Product { get; set; }
    }
}
