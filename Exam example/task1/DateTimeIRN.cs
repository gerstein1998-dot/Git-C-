using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public class DateTimeIRN:IndexedRandomNumber
    {
        public string Date { get; set; }
        public string Time { get; set; }

        public DateTimeIRN(int ind):base(ind)
        {
            Date = "23 june 2026";
            Time = "19:00";
        }
        public override string ToString()
        {
            
            return base.ToString()+ $", date:{Date}, time{Time}";
        }
    }
}
