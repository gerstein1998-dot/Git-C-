using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_1
{
    internal class RoundTable
    {
        DBconection db;
        Knight[] knights;
        public RoundTable()
        {
            knights = new Knight[0];
            db = new DBconection();
        }

        public void AddKnight(Knight knight)
        {
            Knight[] temp = (Knight[])knights.Clone();
            knights = new Knight[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                knights[i] = temp[i];
            }
            knights[knights.Length - 1] = knight;


            Console.WriteLine($"{db.AddKnightToDB(knight)} new knight added!"); 
            
        }

        public void DeleteKnightFromDB(int code)
        {
            Console.WriteLine($"{db.DeletKnightFromDB(code)} knight deleted!"); 
        }

        public string PrintKnightByPower(string power)
        {
            return db.PrintKnightsByPower(power);
        }

        public override string ToString()
        {
            return db.ReadKnightsTable();
        }
}
}
