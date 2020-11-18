using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class TableManage
    {
        // Fields
        Team[] teams;

        DBConnection db;

        // Ctor
        public TableManage()
        {
            teams = new Team[0];

            db = new DBConnection();
        }

        // Methods
        public DataTable TeamsTable()
        {
            return db.TeamsTable();
        }

        public int AddLeague(League league)
        {
            return db.InsertLeague(league);
        }

        public int AddTeam(Team team)
        {
            return db.InsertTeam(team);
        }
        public League GetLeague()
        {
            return db.GetLeague();
        }
        public int GetCurrentTotalTeamCount()
        {
            return db.GetCurrentTotalTeamCount();
        }
        public int DeleteTeam(string name)
        {
            return db.DeleteTeam(name);
        }
        public string[] GetTeamsNames()
        {
            return db.GetTeamsNames();
        }
        public Team[] GetTeamsFromLeague(string order = "")
        {
            return db.GetTeamsFromLeague(order);
        }
        public Team GetTeamFromName(string teamName)
        {
            return db.GetTeamFromName(teamName);
        }
        public List<Player> GetPlayersFromTeam(Team team)
        {
            return db.GetPlayersFromTeam(team);
        }
        public List<Player> GetPlayersByStats(string order)
        {
            return db.GetPlayersByStats(order);
        }
        public int UpdateGameResults(Team winningTeam, Team LosingTeam)
        {
            return db.UpdateGameResults(winningTeam, LosingTeam);
        }
        public List<Player> GetAllPlayersInTheLeague()
        {
            return db.GetAllPlayersInTheLeague();
        }
        public string[] GetPlayersNames()
        {
            return db.GetPlayersNames();
        }
        public int CrownChampion(Team team)
        {
            return db.CrownChampion(team);
        }
        public int ResetLeague()
        {
            return db.ResetLeague();
        }
        public bool LeagueContainsTeams()
        {
            return db.LeagueContainsTeams();
        }
    }
}