using System;
using System.Collections.Generic;
using System.Text;

namespace class_task1
{
    internal class Team
    {
        List<string> players;
        public Team()
        {
            players = new List<string>();
        }

        public void AddPlayer(string playerName)
        {
            players.Add(playerName);
        }

        public void PrintPlayers()
        {
            foreach (string player in players)
            {
                Console.Write(player + ", ");
            }
    }
}
}
