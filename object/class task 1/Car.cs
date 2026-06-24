using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_1
{
    internal class Car: Vehicle
    {
        public Car(string licentPlate, int speed):base(licentPlate, speed)
        {
            
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Car is driving on road");
        }

        public void TurnOnAirConditioner()
        {
            Console.WriteLine("A/C is on for car:" + licentPlate); 
        }
    }
}
