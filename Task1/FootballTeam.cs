using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorsDZ.Task1
{
    public class FootballTeam
    {
        private FootballPlayer[] players = new FootballPlayer[11];

        public FootballPlayer this[int index]
        {
            get { return players[index]; }
            set { players[index] = value; }
        }

        public FootballPlayer GetPlayerByName(string name)
        {
            foreach (FootballPlayer player in players)
            {
                if (player.Name == name)                
                    return player;
                
            }
            return null;
        }
    }
}
