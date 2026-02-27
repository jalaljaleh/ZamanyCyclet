using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Domain
{
    public class ProductUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; } 
        public bool IsDecimal { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
