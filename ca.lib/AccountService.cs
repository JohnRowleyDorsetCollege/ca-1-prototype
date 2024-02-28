
using ca.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.services
{
    public class AccountService
    {

        public AccountService() { } 

        public List<Account> AccountListing()
        {
            List<Account> accounts =  new List<Account>();

            accounts.Add(new Account("foo", "fooLast"));
            accounts.Add(new Account("foo1", "foo1Last"));
            accounts.Add(new Account("foo2", "foo2Last"));

            return accounts;


        }
    }
}
