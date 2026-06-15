using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace תרגיל_6_חלק_א
{
    internal class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Item(string name, String dscription, int price)
        {
            Name = name;
            Description = dscription;   
            Price = price;
        }
        public Item(int code,string name, String description, int price)
        {
            Code = code;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
