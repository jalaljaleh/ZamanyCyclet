using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanyCyclet.Domain
{
    public enum UserPermissions
    {
        None = 0,

        ViewInventory = 1,
        EditInventory = 2,

        ManageUsers = 4,

        ViewReports = 8,

        EditSettings = 16,

        ManageSettings = 32,

    }
}
