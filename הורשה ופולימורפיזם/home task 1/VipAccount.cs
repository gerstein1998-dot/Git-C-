using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1
{
    internal class VipAccount : Account
    {
        public VipAccount(int accNum, double bal):base(accNum,bal)
        {
            
        }

        public override void Withdraw(double amount)
        {
            if((balance - amount) >= -5000)
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
