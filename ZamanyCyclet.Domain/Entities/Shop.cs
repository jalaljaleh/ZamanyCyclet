using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Domain
{
    public class Shop
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }

        public string Address { get; set; }
        public string PostalCode { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<ShopInventory> ShopInventories { get; set; }
    }
}
