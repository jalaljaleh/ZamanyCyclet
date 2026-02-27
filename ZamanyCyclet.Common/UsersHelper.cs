using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZamanyCyclet.Domain;

namespace ZamanyCyclet.Common
{
    public class UsersHelper
    {
        public static User GetDeveloperUser()
        {
            return new User
            {
                Username = "Developer",
                DisplayName = "توسعه دهنده",
                Password = "654321",
                CreatedAt = DateTime.Now,
                Permissions = UserPermissions.None,
            };
        }
    }
}
