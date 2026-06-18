using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_3
{
    internal class Manager: Emploee
    {
        public int teemSize;

        public Manager(string n, int s, int tZ): base(n,s)
        {
            teemSize = tZ;
        }

        public override void Work()
        {
            Console.WriteLine($"{name}, manage right now teem of {teemSize}");
        }

        public void AssignBonus()
        {
            Console.WriteLine($"{name}, aproove bonuses");
        }
    }
}
