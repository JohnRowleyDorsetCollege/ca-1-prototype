// See https://aka.ms/new-console-template for more information
using ca.domain;
using ca.lib;

Console.WriteLine("Banking Solution");

AccountService accountService = new AccountService();

List<Account> accounts = accountService.AccountListing();

foreach(Account account in accounts)
{
    Console.WriteLine($"Account Name: {account.name}");
}
