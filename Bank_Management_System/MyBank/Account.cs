using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public abstract class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; protected set; } //Balance represents the current amount of money available in the account.
        protected Account (string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        // Method to deposit money, common for all account types
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        // Abstract method to withdraw money
        public abstract bool Withdraw(decimal amount);
        // Another abstract method for displaying account details
        public abstract void DisplayAccountDetails();
    }
}
