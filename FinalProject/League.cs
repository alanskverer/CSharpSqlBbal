using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class League
    {
        string name;
        Team[] teamsInTheLeague;
        int numberOfTeams;
        
        
        public string Name { get { return name; } set { name = value; } }
        public int NumberOfTeams { get { return numberOfTeams; } set { numberOfTeams = value; } }
        public Team[] TeamsInTheLeague { get { return teamsInTheLeague; } set { teamsInTheLeague = value; } }

        public League(string name, int numOfTeams)
        {
            Name = name;
            teamsInTheLeague = new Team[numOfTeams];
            numberOfTeams = numOfTeams;


        }
        public bool AddTeamToTheLeague(Team team)
        {
            bool added ;

            if (teamsInTheLeague[teamsInTheLeague.Length - 1] == null)
            {
                for (int i = 0; i < teamsInTheLeague.Length; i++)
                {
                    if (teamsInTheLeague[i] == null)
                    {

                        teamsInTheLeague[i] = team;
                        added = true;
                        return added; ;
                    }
                }
            }
            return false;
        }


    }
}
