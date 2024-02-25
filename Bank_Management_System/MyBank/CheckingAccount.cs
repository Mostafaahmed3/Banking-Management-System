using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class CheckingAccount : Account
    {
        private decimal minimumBalance;
        public CheckingAccount(string accountNumber, decimal initialBalance, decimal minimumBalance)
            :base(accountNumber,initialBalance)
        {
            this.minimumBalance = minimumBalance;
        }
        public override bool Withdraw(decimal amount)
        {
            if (amount <= Balance - minimumBalance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public override void DisplayAccountDetails()
        {
            Console.WriteLine($"Checking Account Number: {AccountNumber}, Balance: {Balance}, Minimum Balance: {minimumBalance}");
        }
    }
}
