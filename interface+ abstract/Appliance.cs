using System;
using System.Collections.Generic;
using System.Text;

namespace מערך__תרגול_מחלקות_מופשטות_וממשקים
{
    
 internal abstract class Appliance
    {
        public string Brand { get; set; }

        public abstract void TurnOn();
    }

}
