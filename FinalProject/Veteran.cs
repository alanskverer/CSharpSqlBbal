using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Veteran : Player, IComparable
    {
        bool humble;
        public bool Humble { get { return humble; } set { humble = value; } }
        public Veteran(string name, string position, int jerseyNumber, int yearsInTheLeague, int rating, bool humble) : base(name, position, jerseyNumber, yearsInTheLeague, rating)
        {
            Humble = humble;
        }
        public override int ParticipateInGame()
        {
            int assists, rebounds, points;
            GamesPlayed++;
            Random rand = new Random();
            assists = rand.Next(5, 10);
            Assists += assists;
            System.Threading.Thread.Sleep(500);
            rebounds = rand.Next(5, 11);
            Rebounds += rebounds;
            Random pts = new Random();
            points = pts.Next(20, 30);
            Points += points;
            return points;

            



        }
        public override string TalkToThePress()
        {
            if (humble)
            {
                return "We should keep playing hard and stay hubmle";
            }
            return $"You already know that {Name} is the best player in the league so no worries the championship is ours";
        }
        public override string ToString()
        {
            return $"Name: {Name} || Position: {Position} || Jersey Number: {JerseyNumber} || Years in the league: {YearsInTheLeague} || Rating: {Rating}";
        }
        public override string ShowStats()
        {
            int astPgm, rebPgm, ptsPgm;
            if (GamesPlayed == 0)
            {
                astPgm = rebPgm = ptsPgm = 0;
            }
            else
            {
                astPgm = Assists / GamesPlayed;
                rebPgm = Rebounds / GamesPlayed;
                ptsPgm = Points / GamesPlayed;
            }
            return $"{Name} Stats - Points: {Points} || Rebounds: {Rebounds} || Assists: {Assists} || Points Per Game: {ptsPgm} || Assist per Game: {astPgm} || Rebound Per Game: {rebPgm} ";
        }
        public int CompareTo(object obj)
        {
            if ((obj as Player).Points < this.Points)
            {
                return -1;
            }
            else if (((obj as Player).Points > this.Points))
            {
                return 1;
            }
            return 0;
        }
    }
}
