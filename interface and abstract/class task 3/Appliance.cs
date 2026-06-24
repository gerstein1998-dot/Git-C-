using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_3
{
    internal class Appliance : IComparable
    {
        public int Price { get; set; }

        public int CompareTo(object? obj)
        {
            return Price.CompareTo(((Appliance)obj).Price);
        }
    }
}

