// See https://aka.ms/new-console-template for more information
using ca.domain;
using ca.domain.Models;
using ca.services;

Console.WriteLine("Banking Solution");

AccountService accountService = new AccountService();


List<Account> accounts = accountService.AccountListing();

foreach(Account account in accounts)
{
    Console.WriteLine($"Account Name: {account.name}");
}

AdminUserService adminUserService = new AdminUserService();
List<AdminUser> adminUsers = adminUserService.AdminUserListing();

foreach (AdminUser adminUser in adminUsers)
{
    Console.WriteLine($"Admin User Name: {adminUser.name}");
}
