using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Team
    {

        int numOfWins;
        int numOfLosses;
        int pointsScored;
        int pointsRecieved;
        string name;
        int numOfChampionships;
        string uniformColor;
        List<Player> players;

        //add players array
        public string Name { get { return name; } set { name = value; } }
        public string UniformColor { get { return uniformColor; } set { uniformColor = value; } }
        public int NumOfWins { get { return numOfWins; } set { numOfWins = value; } }
        public int NumOfLosses { get { return numOfLosses; } set { numOfLosses = value; } }
        public int PointScored { get { return pointsScored; } set { pointsScored = value; } }
        public int PointsRecieved { get { return pointsRecieved; } set { pointsRecieved = value; } }
        public int NumOfChampionships { get { return numOfChampionships; } set { numOfChampionships = value; } }
        public List<Player> Players { get { return players; } set { players = value; } }
        public Team(string name, string uniformColor)
        {
            numOfWins = 0;
            numOfLosses = 0;
            pointsRecieved = 0;
            pointsScored = 0;
            numOfChampionships = 0;
            Name = name;
            UniformColor = uniformColor;
            players = new List<Player>();





        }
        //addplayers
        //winchapoionship

    }
}
