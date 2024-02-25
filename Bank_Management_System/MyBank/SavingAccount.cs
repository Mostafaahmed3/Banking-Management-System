using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class SavingAccount : Account
    {
        private decimal interestRate;
        // Specific method for SavingsAccount
        public void AddInterest()
        {
            var interest = Balance * interestRate / 100;
            Balance += interest;
        }
        public SavingAccount(string accountNumber, decimal initialBalance, decimal interestRate)
           : base(accountNumber, initialBalance)
        {
            this.interestRate = interestRate;
        }
        public override bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;          
                return true;
            }
            return false;
        }
        public override void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}, Interest Rate: {interestRate}%");
        }


    }
}
