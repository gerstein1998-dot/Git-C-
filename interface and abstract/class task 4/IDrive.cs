using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_4
{
    internal interface IDrive
    {
        public int Kilometer { get; set; }
        void Drive(int km);
    }
}
