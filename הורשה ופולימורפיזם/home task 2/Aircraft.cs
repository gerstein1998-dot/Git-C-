using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_2
{
    internal class Aircraft
    {
        int altitude; // גובה נוכחי
        string flightNumber; // מספר טיסה

        public Aircraft(int alt, string flightNum)
        {
            altitude = alt;
            flightNumber = flightNum;
        }

        public virtual void PrintStatus()
        {
            Console.WriteLine($"altitude: {altitude},flight number: {flightNumber}");
        }
    }
}
