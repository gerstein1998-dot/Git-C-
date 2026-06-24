using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class GameManager
    {
        DBConnection db = new DBConnection();


        public void AddMaxNumToTBGames(int game, DateTimeIRN dateTime)
        {
            db.InsertToTBGames(game, dateTime);
        }

        public void AddNumToTBNum(int game, DateTimeIRN dateTime)
        {
            db.InsertToTBNum(game, dateTime);
        }
    }
}
