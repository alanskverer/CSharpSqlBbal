using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Player
    {
        string id;
        string name;
        string position;
        int jerseyNumber;
        int yearsInTheLeague;
        int rating;
        int points;
        int assists;
        int rebounds;
        int gamesPlayed;
        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Position { get { return position; } set { position = value; } }
        public int JerseyNumber { get { return jerseyNumber; } set { jerseyNumber = value; } }
        public int YearsInTheLeague { get { return yearsInTheLeague; } set { yearsInTheLeague = value; } }
        public int Rating { get { return rating; } set { rating = value; } }
        public int Points { get { return points; } set { points = value; } }
        public int Assists { get { return assists; } set { assists = value; } }
        public int Rebounds { get { return rebounds; } set { rebounds = value; } }
        public int GamesPlayed { get { return gamesPlayed; } set { gamesPlayed = value; } }
        public Player(string name, string position, int jerseyNumber, int yearsInTheLeague, int rating)
        {
            Name = name;
            Position = position;
            JerseyNumber = jerseyNumber;
            Rating = rating;
            points = assists = rebounds = gamesPlayed = 0;
            YearsInTheLeague = yearsInTheLeague;

        }



        public abstract int ParticipateInGame();
        public abstract string TalkToThePress();
        public abstract string ShowStats();



    }
}
