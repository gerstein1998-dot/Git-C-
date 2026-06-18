using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_2
{
    internal class Circle:Shape
    {
        public Circle(string c): base(c)
        {
            
        }

        public override void Drow()
        {
            Console.WriteLine($"Drowing a {color} circle");
        }
    }
}
