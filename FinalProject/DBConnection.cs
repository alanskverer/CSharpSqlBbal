using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class DBConnection
    {
        // Fields
        string strCon = @"Data Source=ALAN\SQLEXPRESS;Initial Catalog=nba;Integrated Security=True";
        string strCmd;


        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;


        public DBConnection()
        {
            con = new SqlConnection(strCon);
            dt = new DataTable();
        }


        public DataTable TeamsTable()
        {
            try
            {
                strCmd = "select Name, Color, Wins, Losses, PointsScored AS \"Points Scored\", PointsReceived AS \"Points Rececived\", NumberOfChampionships AS \"Number of Championships\" from Teams ORDER BY Wins DESC, PointsReceived, NumberOfChampionships DESC;";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt.Clear();
                adtr.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public int InsertLeague(League league)
        {
            strCmd = $"insert into League (ID, Name, NumberOfTeams) values (1, '{league.Name}', {league.NumberOfTeams})";
            //MessageBox.Show(strCmd);
            return ExeqNonQuery(strCmd);
        }

        public int InsertTeam(Team team)
        {
            League league = GetLeague();
            // MessageBox.Show($"League:{league.Name}', '{league.NumberOfTeams}, {GetCurrentTotalTeamCount()}" );
            if (league == null || GetCurrentTotalTeamCount() < league.NumberOfTeams)
            {
                strCmd = $"insert into Teams (Name, Color) values ('{team.Name}', '{team.UniformColor}')";
                //   MessageBox.Show(strCmd);
                int status = ExeqNonQuery(strCmd);
                if (status == -1)
                {
                    //ERROR
                    MessageBox.Show("Error occured while adding team, can't proceed to add players.");
                    return status;
                }
                else
                {
                    foreach (Player player in team.Players)
                    {
                        InsertPlayer(player, team);
                    }
                }
            }
            else
            {
                MessageBox.Show("League already has enough teams!");
            }
            return -1;
        }


        public int UpdateTeam(Team team, int wins, int losses)
        {
            strCmd = $"update Teams set Wins={wins} and Losses={losses} where Name = {team.Name}";
            return ExeqNonQuery(strCmd);
        }

        public int TeamChampionship(Team team)
        {
            strCmd = $"update Teams set NumberOfChampionships=NumberOfChampionships+1 where Name = {team.Name}";
            return ExeqNonQuery(strCmd);
        }


        public League GetLeague()
        {
            try
            {
                strCmd = "SELECT * FROM League ORDER BY ID DESC";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                League league = new League(dt.Rows[0]["Name"].ToString(), int.Parse(dt.Rows[0]["NumberOfTeams"].ToString()));
                return league;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        public int GetCurrentTotalTeamCount()
        {
            try
            {
                strCmd = "select COUNT(*) as totalCount from Teams";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                return int.Parse(reader["totalCount"].ToString());
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }


        public Team[] GetTeamsFromLeague(string order = "")
        {
            try
            {
                strCmd = "select * from Teams";
                if (!order.Equals(""))
                    strCmd = strCmd + " order by " + order;
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                Team[] res = new Team[dt.Rows.Count];
                for (int i = 0; i < res.Length; i++)
                {
                    Team team = new Team(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Color"].ToString());
                    team.NumOfWins = int.Parse(dt.Rows[i]["Wins"].ToString());
                    team.NumOfLosses = int.Parse(dt.Rows[i]["Losses"].ToString());
                    team.PointScored = int.Parse(dt.Rows[i]["PointsScored"].ToString());
                    team.PointsRecieved = int.Parse(dt.Rows[i]["PointsReceived"].ToString());
                    team.NumOfChampionships = int.Parse(dt.Rows[i]["NumberOfChampionships"].ToString());
                    res[i] = team;
                }
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Player> GetPlayersFromTeam(Team team)
        {
            try
            {
                int teamId = GetTeamId(team);
                strCmd = $"select * from Players where Team_ID={teamId}";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                string[] res = new string[dt.Rows.Count];
                List<Player> players = new List<Player>();
                for (int i = 0; i < res.Length; i++)
                {
                    Player player;
                    if (int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()) > 2)
                    {
                        player = new Veteran(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()), bool.Parse(dt.Rows[i]["IsHumble"].ToString()));
                    }
                    else
                    {
                        player = new Rookie(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()), bool.Parse(dt.Rows[i]["IsExcited"].ToString()));
                    }
                    //Player player = new Player(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()));
                    player.ID = dt.Rows[i]["ID"].ToString();
                    player.Points = int.Parse(dt.Rows[i]["Points"].ToString());
                    player.Assists = int.Parse(dt.Rows[i]["Assists"].ToString());
                    player.Rebounds = int.Parse(dt.Rows[i]["Rebounds"].ToString());
                    player.GamesPlayed = int.Parse(dt.Rows[i]["GamesPlayed"].ToString());
                    players.Add(player);
                }
                return players;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Player> GetPlayersByStats(string order)
        {
            try
            {
                strCmd = $"select * from Players ORDER BY {order} DESC";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                string[] res = new string[dt.Rows.Count];
                List<Player> players = new List<Player>();
                for (int i = 0; i < res.Length; i++)
                {
                    Player player;
                    if (int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()) > 2)
                    {
                        player = new Veteran(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()), bool.Parse(dt.Rows[i]["IsHumble"].ToString()));
                    }
                    else
                    {
                        player = new Rookie(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()), bool.Parse(dt.Rows[i]["IsExcited"].ToString()));
                    }
                    //Player player = new Player(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()));
                    player.ID = dt.Rows[i]["ID"].ToString();
                    player.Points = int.Parse(dt.Rows[i]["Points"].ToString());
                    player.Assists = int.Parse(dt.Rows[i]["Assists"].ToString());
                    player.Rebounds = int.Parse(dt.Rows[i]["Rebounds"].ToString());
                    player.GamesPlayed = int.Parse(dt.Rows[i]["GamesPlayed"].ToString());
                    players.Add(player);
                }
                return players;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public List<Player> GetAllPlayersInTheLeague()
        {
            try
            {
                strCmd = $"select * from Players";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                string[] res = new string[dt.Rows.Count];
                List<Player> players = new List<Player>();
                for (int i = 0; i < res.Length; i++)
                {
                    Player player;
                    if (int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()) > 2)
                    {
                        player = new Veteran(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()), bool.Parse(dt.Rows[i]["IsHumble"].ToString()));
                    }
                    else
                    {
                        player = new Rookie(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()), bool.Parse(dt.Rows[i]["IsExcited"].ToString()));
                    }
                    //Player player = new Player(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Position"].ToString(), int.Parse(dt.Rows[i]["JerseyNumber"].ToString()), int.Parse(dt.Rows[i]["YearsInTheLeague"].ToString()), int.Parse(dt.Rows[i]["Rating"].ToString()));
                    player.ID = dt.Rows[i]["ID"].ToString();
                    player.Points = int.Parse(dt.Rows[i]["Points"].ToString());
                    player.Assists = int.Parse(dt.Rows[i]["Assists"].ToString());
                    player.Rebounds = int.Parse(dt.Rows[i]["Rebounds"].ToString());
                    player.GamesPlayed = int.Parse(dt.Rows[i]["GamesPlayed"].ToString());
                    players.Add(player);
                }
                return players;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public string[] GetTeamsNames()
        {
            try
            {
                strCmd = "select distinct Name from Teams";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                string[] res = new string[dt.Rows.Count];
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = dt.Rows[i]["Name"].ToString();
                    //MessageBox.Show("Found team: " + res[i]);
                }
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string[] GetPlayersNames()
        {
            try
            {
                strCmd = "select distinct Name from Players";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                string[] res = new string[dt.Rows.Count];
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = dt.Rows[i]["Name"].ToString();
                    //MessageBox.Show("Found team: " + res[i]);
                }
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Team GetTeamFromName(string teamName)
        {
            try
            {
                strCmd = $"select * from Teams where Name='{teamName}'";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                Team team = new Team(dt.Rows[0]["Name"].ToString(), dt.Rows[0]["Color"].ToString());
                team.NumOfWins = int.Parse(dt.Rows[0]["Wins"].ToString());
                team.NumOfLosses = int.Parse(dt.Rows[0]["Losses"].ToString());
                team.PointScored = int.Parse(dt.Rows[0]["PointsScored"].ToString());
                team.PointsRecieved = int.Parse(dt.Rows[0]["PointsReceived"].ToString());
                team.NumOfChampionships = int.Parse(dt.Rows[0]["NumberOfChampionships"].ToString());
                team.Players = GetPlayersFromTeam(team);


                return team;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int GetTeamId(Team team)
        {
            try
            {
                strCmd = $"select ID from Teams where Name='{team.Name}'";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                return int.Parse(reader["ID"].ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }


        public int DeleteTeam(string name)
        {
            Team team = GetTeamFromName(name);
            if (team != null && team.Players != null)
            {
                foreach (Player player in team.Players)
                {
                    DeletePlayer(player);
                }
                strCmd = $"delete from Teams where Name = '{name}'";
                return ExeqNonQuery(strCmd);
            }
            return -1;
        }


        public int InsertPlayer(Player player, Team team)
        {
            int isHumble = 0;
            int isExcited = 0;
            if (player is Rookie)
            {
                Rookie rookie = (Rookie)player;
                if (rookie.IsExited)
                    isExcited = 1;
            }
            else if (player != null)
            {
                Veteran veteran = (Veteran)player;
                if (veteran.Humble)
                    isHumble = 1;
            }
            strCmd = $"insert into Players (Team_ID, Name, Position, JerseyNumber, YearsInTheLeague, Rating, isHumble, isExcited) values ({GetTeamId(team)}, '{player.Name}', '{player.Position}', '{player.JerseyNumber}', '{player.YearsInTheLeague}', '{player.Rating}', {isHumble}, {isExcited})";
            return ExeqNonQuery(strCmd);

        }


        public string[] GetPlayersNamesFromTeam(int team_id)
        {
            try
            {
                strCmd = $"select distinct Name from Players where Team_ID={team_id}";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adtr.Fill(dt);

                string[] res = new string[dt.Rows.Count];
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = dt.Rows[i]["Name"].ToString();
                }
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public int UpdateGameResults(Team winningTeam, Team LosingTeam)
        {
            int winningScore = 0;
            int losingScore = 0;
            foreach (Player player in winningTeam.Players)
            {
                winningScore += player.Points;
                UpdatePlayerStats(player);
            }
            foreach (Player player in LosingTeam.Players)
            {
                losingScore += player.Points;
                UpdatePlayerStats(player);
            }

            //Winning team
            strCmd = $"update teams set Wins=Wins+1, PointsScored=PointsScored+{winningScore}, PointsReceived=PointsReceived+{losingScore} where ID={GetTeamId(winningTeam)}";
            int status = ExeqNonQuery(strCmd);
            //Losing team
            strCmd = $"update teams set Losses=Losses+1, PointsScored=PointsScored+{losingScore}, PointsReceived=PointsReceived+{winningScore} where ID={GetTeamId(LosingTeam)}";
            return ExeqNonQuery(strCmd);
        }

        public int UpdatePlayerStats(Player player)
        {
            strCmd = $"update Players set Points=Points+{player.Points}, Assists=Assists+{player.Assists}, Rebounds=Rebounds+{player.Rebounds}, GamesPlayed=GamesPlayed+1 WHERE ID={player.ID}";
            return ExeqNonQuery(strCmd);
        }

        public int CrownChampion(Team team)
        {
            string teamName = team.Name;
            strCmd = $"update Teams set NumberOfChampionships=NumberOfChampionships+1 where Name='{teamName}'";
            int status = ExeqNonQuery(strCmd);
            if (status == -1)
            {
                MessageBox.Show("An unknown error has occured while crowning a champion (Code: 1)");
            }
            else
            {
                strCmd = $"update Teams set Wins=0, Losses=0, PointsScored=0, PointsReceived=0";
                status = ExeqNonQuery(strCmd);
                if (status == -1)
                {
                    MessageBox.Show("An unknown error has occured while crowning a champion (Code: 2)");
                }
                else
                {
                    strCmd = $"update Players set Points=0, Assists=0, Rebounds=0, GamesPlayed=0";
                    return ExeqNonQuery(strCmd);
                }
            }
            return -1;
        }

        public bool LeagueContainsTeams()
        {
            League league = GetLeague();
            Team[] teams = GetTeamsFromLeague();

            return (league != null && teams.Length > 0);
        }


        public int DeletePlayer(Player player)
        {
            strCmd = $"delete from Players where ID = {player.ID}";
            //MessageBox.Show(strCmd);
            return ExeqNonQuery(strCmd);
        }

        public int ResetLeague()
        {
            strCmd = $"delete from Players";
            int status = ExeqNonQuery(strCmd);
            if (status == -1)
            {
                MessageBox.Show("An unknown error has occured while resetting league (Code: 1)");
            }
            else
            {
                strCmd = $"delete from Teams";
                status = ExeqNonQuery(strCmd);
                if (status == -1)
                {
                    MessageBox.Show("An unknown error has occured while resetting league (Code: 2)");
                }
                else
                {
                    strCmd = $"delete from League";
                    return ExeqNonQuery(strCmd);
                }
            }
            return -1;
        }


        public int ExeqNonQuery(string command)     // execute non query and retun result e.g. insert, delete  
        {
            try
            {
                cmd = new SqlCommand(command, con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
