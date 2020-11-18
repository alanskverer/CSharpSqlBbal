using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        static String txtPath = "../../../company.txt";

        CreateLeague createLeague;
        lblSelectATeam viewPlayers;
        ViewLeagueLeadersLoad viewLeagueLeaders;
        PressConference pressConference;
        Dictionary<string, int> dictionaryRatings;
        Dictionary<string, int> dictionaryJeseys;
        List<Player> players;
        PlayGame playGame;
        AddTeam addTeam;
        TableManage tm;
        League league;


        public Form1()
        {
            InitializeComponent();
            tm = new TableManage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTeamsTable.DataSource = tm.TeamsTable();
            dgvTeamsTable.AutoGenerateColumns = false;
            checkLeagueHasTeams();

            // this.dgvTeamsTable.DefaultCellStyle.Font = new Font("Tahoma", 12);
            tmr.Start();
            league = tm.GetLeague();
            if (league != null)
            {
                BtnCreateLeague.Enabled = false;
                lblLeagueName.Text = $"Welcome to {league.Name} league";
            }
            else
            {
                lblLeagueName.Text = $"Welcome, please create a new league";
            }


        }

        private void checkLeagueHasTeams()
        {
            if (!tm.LeagueContainsTeams())
            {
                BtnPlayGame.Enabled = false;
                BtnViewPlayers.Enabled = false;
                BtnPressConference.Enabled = false;
                BtnPlayersDictionary.Enabled = false;
                BtnViewLeagueLeadres.Enabled = false;
                BtnTextGeneral.Enabled = false;
                BtnEndSeason.Enabled = false;
            }
            else
            {
                BtnPlayGame.Enabled = true;
                BtnViewPlayers.Enabled = true;
                BtnPressConference.Enabled = true;
                BtnPlayersDictionary.Enabled = true;
                BtnViewLeagueLeadres.Enabled = true;
                BtnTextGeneral.Enabled = true;
                BtnEndSeason.Enabled = true;
            }
        }

        private void BtnCreateLeague_Click(object sender, EventArgs e)
        {
            createLeague = new CreateLeague();
            createLeague.Show();
            BtnCreateLeague.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dataTable = tm.TeamsTable();
            dgvTeamsTable.DataSource = dataTable;
            checkLeagueHasTeams();

            League league = tm.GetLeague();
            if (league != null)
            {
                BtnCreateLeague.Enabled = false;
                lblLeagueName.Text = $"Welcome to {league.Name} league";
            }
            else
            {
                lblLeagueName.Text = $"Welcome, please create a new league";
            }

        }

        private void BtnAddNewTeam_Click(object sender, EventArgs e)
        {
            league = tm.GetLeague();
            if (league != null)
            {
                if (!CheckIfLeagueIsFull())
                {
                    addTeam = new AddTeam();
                    addTeam.Show();
                }
                else
                {
                    MessageBox.Show("League is full");
                }
            }
            else
            {
                MessageBox.Show("Please create a league first.");
            }

        }
        private bool CheckIfLeagueIsFull()
        {
            bool full = false;
            League league = tm.GetLeague();

            if (league == null || tm.GetCurrentTotalTeamCount() < league.NumberOfTeams)
            {
                return full;
            }
            else
            {
                full = true;
                return full;
            }

        }

        private void BtnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (tm.GetCurrentTotalTeamCount() == 0)
            {
                MessageBox.Show("There are no teams in the league");
            }
            else
            {
                string teamToDelete = TxtTeamNameToDel.Text;
                if (teamToDelete == "Enter Team Name")
                {
                    MessageBox.Show("Please Enter Team Name To Delete");
                }
                else
                {
                    int rowsAffected = tm.DeleteTeam(teamToDelete);
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show($"{teamToDelete} was deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show($"{teamToDelete} doesn't exists in the league");
                    }
                }
                

            }
        }

        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            playGame = new PlayGame();
            playGame.Show();
        }

        private void BtnViewPlayers_Click(object sender, EventArgs e)
        {
            viewPlayers = new lblSelectATeam();
            viewPlayers.Show();
        }

        private void BtnExportTxt_Click(object sender, EventArgs e)
        {

            try
            {
                League myLeague = tm.GetLeague();
                Team[] leagueTeams = tm.GetTeamsFromLeague("Wins DESC, PointsScored DESC, PointsReceived");
                foreach (Team team in leagueTeams)
                {
                    team.Players = tm.GetPlayersFromTeam(team);
                }
                String saveString = "League " + myLeague.Name + ":\n-----------------------------------------\n";
                for (int i = 0; i < leagueTeams.Length; i++)
                {
                    Team currentTeam = leagueTeams[i];
                    saveString = saveString + "" + (i + 1) + ": " + currentTeam.Name + $" (Wins {currentTeam.NumOfWins} / Losses {currentTeam.NumOfLosses}) Color: {currentTeam.UniformColor}\n\tPlayers:\n";
                    foreach (Player searchPlayer in currentTeam.Players)
                    {
                        if (searchPlayer.YearsInTheLeague > 2)
                        {
                            Veteran currentPlayer = (Veteran)searchPlayer;
                            saveString = saveString + $"\t\tName: {currentPlayer.Name} Position: {currentPlayer.Position} Jersey Number: {currentPlayer.JerseyNumber} Years In The League: {currentPlayer.YearsInTheLeague} Rating: {currentPlayer.Rating} Humble? {currentPlayer.Humble}\n" +
                                $"\t\tSeason Average - Points: {((currentPlayer.GamesPlayed > 0) ? (currentPlayer.Points / currentPlayer.GamesPlayed) : 0)} Assists: {((currentPlayer.GamesPlayed > 0) ? (currentPlayer.Assists / currentPlayer.GamesPlayed) : 0)} Rebounds: {((currentPlayer.GamesPlayed > 0) ? (currentPlayer.Rebounds / currentPlayer.GamesPlayed) : 0)}\n";

                        }
                        else
                        {
                            Rookie currentPlayer = (Rookie)searchPlayer;
                            saveString = saveString + $"\t\tName: {currentPlayer.Name} Position: {currentPlayer.Position} Jersey Number: {currentPlayer.JerseyNumber} Years In The League: {currentPlayer.YearsInTheLeague} Rating: {currentPlayer.Rating} Excited? {currentPlayer.IsExited}\n" +
                                $"\t\tSeason Average - Points: {((currentPlayer.GamesPlayed > 0) ? (currentPlayer.Points / currentPlayer.GamesPlayed) : 0)} Assists: {((currentPlayer.GamesPlayed > 0) ? (currentPlayer.Assists / currentPlayer.GamesPlayed) : 0)} Rebounds: {((currentPlayer.GamesPlayed > 0) ? (currentPlayer.Rebounds / currentPlayer.GamesPlayed) : 0)}\n";
                        }
                    }
                }

                StreamWriter writer = new StreamWriter(txtPath);
                writer.Write(saveString);
                writer.Close();
                MessageBox.Show("Saved TXT File!", "Success");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void BtnReadText_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(txtPath);
                string res = reader.ReadToEnd();
                reader.Close();
                MessageBox.Show(res, "Read Saved TXT File");
            }
            catch (Exception)
            {
                MessageBox.Show("The TXT file you seek does not exist!");
            }
        }

        private void BtnViewLeagueLeadres_Click(object sender, EventArgs e)
        {
            viewLeagueLeaders = new ViewLeagueLeadersLoad();
            viewLeagueLeaders.Show();

        }

        private void BtnPressConference_Click(object sender, EventArgs e)
        {
            pressConference = new PressConference();
            pressConference.Show();
        }

        private void dgvTeamsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtmGetPlayersRatingDictionary_Click(object sender, EventArgs e)
        {
            try
            {
                bool nameExists = false;
                int rating;
                string playerName = TxtPlayersNameGetRating.Text.ToLower();
                dictionaryRatings = new Dictionary<string, int>();
                players = tm.GetAllPlayersInTheLeague();
                foreach (Player player in players)
                {
                    string name = player.Name.ToLower();
                    dictionaryRatings.Add(name, player.Rating);
                    if (name == playerName)
                    {
                        nameExists = true;
                    }
                }

                if (nameExists)
                {
                    rating = dictionaryRatings[playerName];
                    MessageBox.Show($"{playerName} Rating Is: {rating}");
                    TxtPlayersNameGetRating.Text = "Enter Player's Name";
                }
                else
                {
                    if (TxtPlayersNameGetRating.Text == "Enter Player's Name")
                    {
                        MessageBox.Show($"Please enter a player name first");
                    }
                    else
                    {
                        MessageBox.Show($"Couldn't find {playerName} in the player's list, try again");
                    }
                    

                }

            }
            catch (Exception)
            {

                MessageBox.Show("There are two players with the same name - cannot execute your command");
            }



        }

        private void BtmGetPlayersJerseyDictionary_Click(object sender, EventArgs e)
        {
            try
            {
                bool nameExists = false;
                int jerseyNumber;
                string playerName = TxtPlayersNameGetJersey.Text.ToLower();
                dictionaryRatings = new Dictionary<string, int>();
                players = tm.GetAllPlayersInTheLeague();
                foreach (Player player in players)
                {
                    dictionaryRatings.Add(player.Name.ToLower(), player.JerseyNumber);
                    if (player.Name.ToLower() == playerName)
                    {
                        nameExists = true;
                    }
                }

                if (nameExists)
                {
                    jerseyNumber = dictionaryRatings[playerName];
                    MessageBox.Show($"{playerName} Jersey Number Is: {jerseyNumber}");
                    TxtPlayersNameGetJersey.Text = "Enter Player's Name";
                }
                else
                {
                    if (TxtPlayersNameGetJersey.Text == "Enter Player's Name")
                    {
                        MessageBox.Show($"Please enter a player name first");
                    }
                    else
                    {
                        MessageBox.Show($"Couldn't find {playerName} in the player's list, try again");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("There are two players with the same name - cannot execute your command");
            }
        }

        private void BtnRefreshTable_Click(object sender, EventArgs e)
        {
            DataTable dataTable = tm.TeamsTable();
            dgvTeamsTable.DataSource = dataTable;
            checkLeagueHasTeams();
            if (league != null)
            {
                BtnCreateLeague.Enabled = false;
                lblLeagueName.Text = $"Welcome to {league.Name} league";
            }
            else
            {
                lblLeagueName.Text = $"Welcome, please create a new league";
            }
        }

        private void BtnEndSeason_Click(object sender, EventArgs e)
        {
            //Find winner, MVP
            if (league != null)
            {
                Team[] leagueTeams = tm.GetTeamsFromLeague("Wins DESC, PointsScored DESC, PointsReceived");
                if (leagueTeams.Length > 0)
                {
                    int gamesPlayed = 0;
                    foreach (Team team in leagueTeams)
                    {
                        gamesPlayed = gamesPlayed + team.NumOfWins + team.NumOfLosses;
                    }

                    if (gamesPlayed > 0)
                    {
                        Team championTeam = leagueTeams[0];
                        championTeam.Players = tm.GetPlayersFromTeam(championTeam);

                        Player[] mvpPlayers = new Player[1];
                        int mvpBestValue = 0;
                        foreach (Player player in championTeam.Players)
                        {
                            int playerValue = player.Points + player.Assists + player.Rebounds;
                            if (playerValue >= mvpBestValue)
                            {
                                mvpBestValue = playerValue;
                                mvpPlayers[0] = player;
                            }
                        }

                        Player mvpPlayer = mvpPlayers[0];
                        string message = $"THE CHAMPION OF THE {league.Name} LEAGUE IS {championTeam.Name}!!!\nCONGRAGULATIONS!\n\nTHE MVP OF THE SEASON IS: {mvpPlayer.Name}\nPoints: {mvpPlayer.Points}\nAssists: {mvpPlayer.Assists}\nRebounds: {mvpPlayer.Rebounds}\n\nA new season will now start";
                        tm.CrownChampion(championTeam);
                        MessageBox.Show(message, "End of Season");
                    }
                    else
                    {
                        MessageBox.Show("Can't end season when no games have been played");
                    }
                }
                else
                {
                    MessageBox.Show("Can't end season when there are no teams in the league");
                }
            }
            else
            {
                MessageBox.Show("Can't end season when a league doesn't exist");
            }
        }

        private void BtnResetLeague_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset league? All data will be lost", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int status = tm.ResetLeague();
                if (status != -1)
                {
                    lblLeagueName.Text = $"Welcome, please create a new league";
                    BtnCreateLeague.Enabled = true;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void BtnPredictRookie_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRookieMinutes.Text.Contains("."))
                {
                    //double
                    MyGenericPredicition<double> myGenericDOUBLE = new MyGenericPredicition<double>(double.Parse(txtRookieMinutes.Text));
                    MessageBox.Show($"This veteran will score {myGenericDOUBLE.Predict("Rookie")}", "Prediction Results");
                }
                else
                {
                    //int
                    MyGenericPredicition<int> myGenericINT = new MyGenericPredicition<int>(int.Parse(txtRookieMinutes.Text));
                    MessageBox.Show($"This veteran will score {myGenericINT.Predict("Rookie")}", "Prediction Results");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number", "Error");
            }
        
        }

        private void BtnPredictVeteran_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPredictVeteran.Text.Contains("."))
                {
                    //double
                    MyGenericPredicition<double> myGenericDOUBLE = new MyGenericPredicition<double>(double.Parse(txtPredictVeteran.Text));
                    MessageBox.Show($"This veteran will score {myGenericDOUBLE.Predict("Veteran")}", "Prediction Results");
                }
                else
                {
                    //int
                    MyGenericPredicition<int> myGenericINT = new MyGenericPredicition<int>(int.Parse(txtPredictVeteran.Text));
                    MessageBox.Show($"This veteran will score {myGenericINT.Predict("Veteran")}", "Prediction Results");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number", "Error");
            }
            
        }
    }
}
