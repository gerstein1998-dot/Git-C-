using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1
{
    internal class Animal
    {
        public string name;
        public int age;

        public Animal(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"name: {name}, age: {age}";
        }
    }
}
