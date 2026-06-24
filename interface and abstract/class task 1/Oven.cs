using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_1
{
    internal class Oven: Appliance
    {

        public override void TurnOn()
        {
            Console.WriteLine($"The {Brand} oven is ON ");
        }
    }
}
