using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_6_חלק_ב._2
{
    internal class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }


        public Item(int code, string name, String dscription, int price)
        {
            Code = code;
            Name = name;
            Description = dscription;
            Price = price;
        }
        public Item(string name, String dscription, int price)
        {
            Name = name;
            Description = dscription;
            Price = price;
        }
    }
}
