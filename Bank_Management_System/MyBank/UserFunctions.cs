using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class UserFunctions
    {
        private List<Account> accounts = new List<Account>();
        public void CreateAccount()
        {
            Console.WriteLine("Select account type (1 for Savings, 2 for Checking):");
            string accountType = Console.ReadLine();
            Console.WriteLine("Enter account number:");
            string accountNumber = Console.ReadLine();
            Console.WriteLine("Enter initial balance:");
            decimal initialBalance = decimal.Parse(Console.ReadLine());
            switch (accountType)
            {
                case "1":
                    Console.WriteLine("Enter interest rate (as a percentage):");
                    decimal interestRate = decimal.Parse(Console.ReadLine());
                    accounts.Add(new SavingAccount(accountNumber,initialBalance,interestRate));
                    break;
                case "2":
                    Console.WriteLine("Enter minimum balance:");
                    decimal minimumBalance = decimal.Parse(Console.ReadLine());
                    accounts.Add(new CheckingAccount(accountNumber, initialBalance, minimumBalance));
                    break;
                default:
                    Console.WriteLine("Invalid account type selected.");
                    break;
            }
        }
        public void MakeTransaction(bool isDeposit)
        {
            Console.WriteLine("Enter account number:");
            string accountNumber = Console.ReadLine();
            Account account = accounts.Find(a => a.AccountNumber==accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }
            Console.WriteLine($"Enter amount to{(isDeposit? "deposit" : "withdraw")}");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (isDeposit)
            {
                account.Deposit(amount);
            }
            else if(!account.Withdraw(amount)){
                Console.WriteLine("Transaction failed.");
            }



        }
        public void DisplayAccounts()
        {
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts to display.");
                return;
            }
            foreach(Account account in accounts)
            {
                account.DisplayAccountDetails();
            }

        }
    }
}
