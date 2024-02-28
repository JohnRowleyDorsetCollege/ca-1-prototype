using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.domain.Models
{
    public class AdminUser
    {
        public AdminUser(string _name)
        {
            name = _name;
        }

        public string name { get; set; }
    }
}
