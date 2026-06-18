using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_3
{
    internal class Emploee
    {
        public string name;
        public int salary;

        public Emploee(string n, int s)
        {
            name = n;
            salary = s;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{name}, working right now");
        }
    }
}
