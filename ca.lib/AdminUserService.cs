using ca.domain;
using ca.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.services
{
    public class AdminUserService
    {
        public List<AdminUser> adminUsers { get; set; }

        public AdminUserService()
        {
            adminUsers = new List<AdminUser>();
        }

        public List<AdminUser> AdminUserListing()
        {

            adminUsers.Add(new AdminUser("AdminUser 1"));
            adminUsers.Add(new AdminUser("AdminUser 2"));
            adminUsers.Add(new AdminUser("AdminUser 3"));



            return adminUsers;
        }
    }
}
