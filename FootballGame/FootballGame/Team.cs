using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team(Coach coach)
        {
            Coach = coach;
            Players = new List<FootballPlayer>();
        }

        public double CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }

            return (double)totalAge / Players.Count;
        }
    }
}
