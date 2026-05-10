using System;
using System.Collections.Generic;
using System.Text;

namespace מערך__תרגול_מחלקות_מופשטות_וממשקים
{
    internal class Oven : Appliance
    {
        public Oven (string brand)
        {
            Brand = brand;
        }
        public override void TurnOn()
        {
            Console.WriteLine($"the {Brand} oven is on");
        } 

    }


}
