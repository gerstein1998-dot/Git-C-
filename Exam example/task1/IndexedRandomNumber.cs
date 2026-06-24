using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public class IndexedRandomNumber: RandomNumber
    {
        public int Index { get; set; }
        public IndexedRandomNumber(int ind)
        {
            Index = ind;
        }

        public override string ToString()
        {
            return $"index:{Index}, random number:{Number}";
        }
    }
}
