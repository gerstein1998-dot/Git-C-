using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1_6._1_
{
    internal class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Item(int code, string name, int price, string desc)
        {
            Code = code;
            Name = name;
            Price= price;
            Description = desc;
        }
        public Item(string name, int price, string desc)
        {
            Name = name;
            Price = price;
            Description = desc;
        }
    }
}
