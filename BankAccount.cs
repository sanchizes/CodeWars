using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class BankAccount
    {
        private double balance;

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Your balance was increased by {amount}");
        }

        public void Withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine($"Your balance was decreased by {amount}");
        }

        public void GetBalance()
        {
            Console.WriteLine(balance);
        }
    }
}
