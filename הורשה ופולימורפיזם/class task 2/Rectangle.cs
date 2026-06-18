using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_2
{
    internal class Rectangle: Shape
    {
        public Rectangle(string c):base(c)
        {
            
        }

        public override void Drow()
        {
            Console.WriteLine($"Drowing a {color} rectangle");
        }
    }
}
