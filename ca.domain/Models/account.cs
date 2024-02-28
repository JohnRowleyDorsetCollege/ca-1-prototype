using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ca.domain
{
    public class Account
    {
        public Account(string firstName, string lastName)
        {
            name = GenerateName(firstName, lastName);
        }
        public string name { get; set; }

        private string GenerateName(string firstName, string lastName)
        {
            name = $"{firstName}-{lastName}-001";
            return name;
        }
    }
}
