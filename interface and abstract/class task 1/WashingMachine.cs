using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_1
{
    internal class WashingMachine: Appliance
    {

        public override void TurnOn()
        {
            Console.WriteLine($"The {Brand} washing maching is ON ");
        }
    }
}
