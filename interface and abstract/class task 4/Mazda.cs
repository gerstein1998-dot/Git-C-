using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_4
{
    internal class Mazda : Car
    {
        public string OwnerName { get; set; }
        public Mazda(int y, string m,string ownerName):base(y, m) 
        {
            OwnerName = ownerName;
        }

        public override string ToString()
        {
            return $"{base.ToString()} owner name: {OwnerName}";

        }
        public override void FillGas()
        {
            fuel += 50;
            Console.WriteLine("you fill 50 litter of fuel");
        }
    }
}
