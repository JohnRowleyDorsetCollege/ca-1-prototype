
using ca.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ca.services
{
    public class AccountService
    {
        public List<Account> accounts { get; set; }
       
        public AccountService() { 
            accounts = new List<Account>();
        } 

        public List<Account> AccountListing()
        {
           

            accounts.Add(new Account(GenerateAccountName("foo", "last")));
            accounts.Add(new Account(GenerateAccountName("foo", "last")));
            accounts.Add(new Account(GenerateAccountName("foo", "last")));

            return accounts;


        }

        private string GenerateAccountName(string firstName, string lastName)
        {
            int counter = 1;
            string accountName = $"{firstName}-{lastName}-{counter}";

            while (AccountNameExists(accountName)) {
                counter++;
                //Console.WriteLine($"{accountName}:{counter}");
                accountName = $"{firstName}-{lastName}-{counter}";
            }

            return accountName;
        }

        public bool AccountNameExists(string accountName)
        {
             int count = accounts.Where(x=>x.name.Equals(accountName)).Count();
         
            return count > 0;

         
        }
    }
}
