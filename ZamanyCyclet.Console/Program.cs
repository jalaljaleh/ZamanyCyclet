using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZamanyCyclet.Infrastructure;

namespace ZamanyCyclet.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (HalunDbContext db = new HalunDbContext())
            {
                if (db.Database.Exists())
                    db.Database.Delete();

                db.Database.CreateIfNotExists();
                var a = db.Customers.Count();
            }
        }
    }
}