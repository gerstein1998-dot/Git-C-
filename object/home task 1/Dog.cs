using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1
{
    internal class Dog: Animal
    {
        public Dog(string name, int age):base(name,age)
        {
           
        }
        public void Bark()
        {
            Console.WriteLine("bark");
        }
    }
}

