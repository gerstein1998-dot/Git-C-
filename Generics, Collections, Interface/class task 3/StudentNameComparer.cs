using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace class_task_3
{
    internal class StudentNameComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            Student s1 = x as Student; //בעצם אני מגדירה את איקס כסטודנט 1 שאותו אני אוכל להשוות
            Student s2 = y as Student; //ומגדירה את ווי לסטודנט 2 שמולו אני משווה 

            return string.Compare(s1.Name, s2.Name); //יחזיר לי 1\0\-1 שלפי זה יקבע הסדר שלהם
        }
    }


}
