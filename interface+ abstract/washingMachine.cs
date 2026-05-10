using System;
using System.Collections.Generic;
using System.Text;

namespace מערך__תרגול_מחלקות_מופשטות_וממשקים
{
    internal class washingMachine : Appliance
    {
        public washingMachine(string brand)
        {
            Brand = brand;
        }
        public override void TurnOn()
        {
            Console.WriteLine($"the {Brand}  washing machine is on");
        }
    }
}
