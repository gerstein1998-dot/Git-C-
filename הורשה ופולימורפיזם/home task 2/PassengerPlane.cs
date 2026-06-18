using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_2
{
    internal class PassengerPlane : Aircraft
    {
        int passengerCount;

        public PassengerPlane(int alt, string flightNum, int passCount):base(alt,flightNum)
        {
            passengerCount = passCount;
        }

        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"passenger count: {passengerCount}");
        }
    }
}
