using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_3
{
    internal class Student : IComparable
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public int CompareTo(object? obj)
        {
            return (((Student)obj).Grade).CompareTo(Grade); //עצם זה שהפכתי את הסדר של ההשוואה בין סטודנט לאוביקט מסוג סטודנט זה סידר לי את הרשימה בצורה מהגדול לקטן
        }

       
}
}
