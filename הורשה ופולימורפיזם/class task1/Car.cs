using System;
using System.Collections.Generic;
using System.Text;

namespace class_task1
{
    internal class Car : Vehicle
    {
        public int numOfDoors;

        public Car(string m, int y, int numO):base(m,y)
        {
            numOfDoors = numO;
        }

        public new void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($", {numOfDoors}");
        }
    }
}
