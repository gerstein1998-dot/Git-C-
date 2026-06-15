using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class student : IComparable
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public int compareTo(object obl)
        {

        }

    }
}
