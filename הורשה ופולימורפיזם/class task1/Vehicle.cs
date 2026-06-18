using System;
using System.Collections.Generic;
using System.Text;

namespace class_task1
{
    internal class Vehicle
    {
        protected string model;
        protected int year;

        public Vehicle(string m, int y)
        {
            model = m;
            year = y;
        }
        public void PrintDetails()
        {
            Console.Write($"{model}, {year}");
        }

    }
}
