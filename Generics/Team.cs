using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class Team
    {
        List<string> names= new List<string>();

     
        public void AddPlayer(string name)
        {
            names.Add(name);

        }
        public void print()
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        
        
        }
}
}

