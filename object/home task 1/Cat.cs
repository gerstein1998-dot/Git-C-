using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1
{
    sealed class Cat: Animal
    {
        public Cat(string name, int age):base(name,age)
        {
            
        }

        public void Purr()
        {
            Console.WriteLine("purr");
        }
    }
}
