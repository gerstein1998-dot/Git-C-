using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_1
{
    internal class Bicycle: Vehicle
    {
        public Bicycle(string licentPlate, int speed) : base(licentPlate, speed)
        {
            
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("bicycle is pedaling on the bike lane");
        }
    }
}
