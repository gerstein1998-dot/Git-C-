using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public abstract class RandomNumber
    {
        public int Number { get; set; }

        protected RandomNumber()
        {
            Random rnd = new Random();
            Number = rnd.Next(100)+1; //כל מספר שיצא יתווסף לו 1 כדי שיהיה מספרים מ1-100 אחרת זה יעשה 0-99
        }

        public abstract string ToString();


    }
}
