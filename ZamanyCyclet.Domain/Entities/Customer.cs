using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Domain
{
    public class Customer
    {
        public int Id { get; private set; }

        public string FullName { get; set; }

        public string NationalCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; private set; }




    }
}
