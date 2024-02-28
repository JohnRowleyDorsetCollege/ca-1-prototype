
using ca.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.lib
{
    public class AccountService
    {

        public AccountService() { } 

        public List<Account> AccountListing()
        {
            List<Account> accounts =  new List<Account>();

            accounts.Add(new Account("foo"));
            accounts.Add(new Account("foo1"));
            accounts.Add(new Account("foo2"));

            return accounts;


        }
    }
}
