using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Rookie : Player , IComparable
    {
        bool isExited;
        public bool IsExited { get { return isExited; } set { isExited = value; } }
        public Rookie(string name, string position, int jerseyNumber, int yearsInTheLeague, int rating, bool isExited) : base(name, position, jerseyNumber, yearsInTheLeague, rating)
        {
            IsExited = isExited;
        }
        public override int ParticipateInGame()
        {
            int assists, rebounds, points;
            GamesPlayed++;
            Random rand = new Random();
            assists = rand.Next(2, 6);
            Assists += assists;
            System.Threading.Thread.Sleep(500);
            rebounds = rand.Next(2, 6);
            Rebounds += rebounds;
            Random pts = new Random();
            points = pts.Next(10, 20);
            Points += points;
            return points;




            

        }
        
        
        public override string TalkToThePress()
        {
            if (isExited)
            {
                return $"Hello, my name is {Name} and i'm very excited to play in the league!";
            }
            return $"Hello! my name is {Name} and i'm not so excited to play in the league";
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
            if ((obj as Player).Points< this.Points)
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
