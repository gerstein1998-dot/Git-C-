using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_1
{
    internal class Vehicle
    {
       public string licentPlate;
       public int speed;
        public Vehicle(string licentPlate, int speed)
        {
            this.licentPlate = licentPlate;
            this.speed = speed;
        }

        public virtual void Move()
        {
            Console.WriteLine($"vehicle is mooving at {speed} km/h");
        }

        public override string ToString()
        {
            return $"licent plate:{licentPlate}, speed: {speed}";
        }

        public override bool Equals(object obj)
        {
            Vehicle otherVehicle = obj as Vehicle;
            if (otherVehicle != null)
            {
                return this.licentPlate == otherVehicle.licentPlate;
            }
            return false;
            
        }
    }
}

