using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_4
{
    internal class Audi : Car
    {
        public int MaxFast { get; set; }

        public Audi(int y, string m, int fast) : base(y, m)
        {
         MaxFast = fast;   
        }

        public override string ToString()
        {
            return base.ToString() + $"max fast is: {MaxFast}";
        }
        public override void FillGas()
        {
            fuel += 60;
            Console.WriteLine("you fill 60 litter of fuel.");
        }
    }
}
