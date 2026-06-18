using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_2
{
    internal class Shape
    {
        public string color;

        public Shape(string c)
        {
            color = c;
        }

        public virtual void Drow()
        {
            Console.WriteLine($"Drowing a {color} shape");
        }
    }
}
