using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZamanyCyclet.Infrastructure;

namespace ZamanyCyclet.App.Helpers
{
    public class SystemTimeHelper
    {
        public async Task<bool> IsSystemTimeValid()
        {
            try
            {
                using (var db = new HalunDbContext())
                {
                    var dbTime = db.Database
                                   .SqlQuery<DateTime>("SELECT GETUTCDATE()")
                                   .First();

                    var localUtc = DateTime.UtcNow;

                    var diff = Math.Abs((localUtc - dbTime).TotalMinutes);

                    return diff <= 10; // allow 10 minutes tolerance
                }
            }
            catch
            {
                return true;
            }
        }
    }
}
