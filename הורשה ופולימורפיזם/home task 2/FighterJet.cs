using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_2
{
    internal class FighterJet: Aircraft
    {
        bool missilesLoaded;

        public FighterJet(int alt, string flightNum) : base(alt, flightNum)
        {
            missilesLoaded = true;
        }

        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"missiles loaded: {missilesLoaded}");
        }
        public void FireMissile()
        {
            if (missilesLoaded)
            {
                Console.WriteLine("Missiles fired!");
                missilesLoaded = false;
            }
            

        }
    }
}

