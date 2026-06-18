using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1
{
    internal class Account
    {
        protected int accountNumber;
        protected double balance;

        public Account(int accNum, double bal)
        {
            accountNumber = accNum;
            balance = bal;
        }

        public virtual void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("your balance is:" + balance);
            }
            else
            {
                Console.WriteLine("Not enough money :(");
            }

        }
    }
}
