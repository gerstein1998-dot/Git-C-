using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Transactions;

namespace targil_7_class
{
    internal class knight
    {
        public int ID { get; set; };
        public string FirstName { get; set; };
        public string LastName { get; set; };
        public string Power { get; set; };

        public knight(string firstName, string lastName, string power)
        {
            FirstName = firstName;
            LastName = lastName;
            Power = power;
        }
        public knight( int id, string firstName, string lastName, string power)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Power = power;
        }
        public override string ToString()
        {
            return $"{ID} | {LastName} {FirstName} | {Power}"
        }
    }
}
