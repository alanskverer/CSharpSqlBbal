using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{

    public partial class PlayGame : Form
    {
        int gameTime;
        int time;
        string homeTeamName;
        string awayTeamName;
        string homeTeamFirstPlayerName;
        string homeTeamSecondPlayerName;
        string awayTeamFirstPlayerName;
        string awayTeamSecondPlayerName;
        int firstHomePlayerPoints;
        int secondHomePlayerPoints;
        int firstAwayPlayerPoints;
        int secondAwayPlayerPoints;
        int finalScoreHomeTeam;
        int finalScoreAwayTeam;
        Team homeTeam;
        Team awayTeam;
        
        TableManage tm;
        public PlayGame()
        {
            InitializeComponent();
            gameTime = 6;
            time = 0;
            tm = new TableManage();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            if (cmbAwayTeam.Text == cmbHomeTeam.Text)
            {
                MessageBox.Show("The teams must be different in order to play agains each other, try again!");

            }
           
            //get 2 teams and play against each other
           
            else
            {
                tmr.Start();
                lblGameInProgress.Show();
                ShowBallProgress();
                pictureBox6.Show();
                StartGame();
            }
            //MessageBox.Show($"Final score: {finalScoreHomeTeam} vs {finalScoreAwayTeam}");



        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (time == gameTime)
            {
                tmr.Stop();
                //Close();
                lblGameInProgress.Hide();

                lblFinalScore.Show();
                lblAwayTeamPoints.Show();
                lblHomeTeamPoints.Show();
                lblHomeTeamPoints.Text = $"{homeTeam.Name}: {finalScoreHomeTeam}";
                lblAwayTeamPoints.Text = $"{awayTeam.Name}: {finalScoreAwayTeam}";
                ShowBallProgress(); // hiding the balls
                
                

                if (finalScoreHomeTeam > finalScoreAwayTeam)
                {
                    lblPlayersPoints.Show();
                    MessageBox.Show($"{homeTeam.Name} won the game! and now have {homeTeam.NumOfWins + 1} wins");
                    
                    

                    
                    tm.UpdateGameResults(homeTeam, awayTeam);
                }
                else if (finalScoreAwayTeam > finalScoreHomeTeam)
                {


                    lblPlayersPoints.Show();
                    MessageBox.Show($"{awayTeam.Name} won the game! and now have {awayTeam.NumOfWins + 1} wins");
                    
                    tm.UpdateGameResults(awayTeam, homeTeam);
                }
                else
                {
                    MessageBox.Show("Game was tied, Please start a new game");
                    this.Close();
                   

                }

                lblFirstHomePlayerScore.Text = $"{homeTeamFirstPlayerName}: {firstHomePlayerPoints} points";
                lblSecondHomePlayerScore.Text = $"{homeTeamSecondPlayerName}: {secondHomePlayerPoints} points";
                lblFirstAwayPlayerScore.Text = $"{awayTeamFirstPlayerName}: {firstAwayPlayerPoints} points";
                lblSecondAwayPlayerScore.Text = $"{awayTeamSecondPlayerName}: {secondAwayPlayerPoints} points";
                lblFirstHomePlayerScore.Show();
                lblSecondHomePlayerScore.Show();
                lblFirstAwayPlayerScore.Show();
                lblSecondAwayPlayerScore.Show();
                pictureBox6.Show();
                BtnStartGame.Enabled = false;
                //show scorres
                return;
            }
            if (time==1)
            {
                pictureBox1.Show();
            }
            else if (time==2)
            {
                pictureBox2.Show();
            }
            else if (time==3)
            {
                pictureBox3.Show();
            }
            else if (time==4)
            {
                pictureBox4.Show();
            }
            else if (time==5)
            {
                pictureBox5.Show();
            }
            time++;
            lblGameInProgress.Text = $"Game is in progress";
            

        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
            cmbHomeTeam.DataSource = tm.GetTeamsNames();
            cmbAwayTeam.DataSource = tm.GetTeamsNames();
            pictureBox6.Hide();
            HideAll();

        }
        private void StartGame()
        {
            homeTeamName = cmbHomeTeam.Text;
            awayTeamName = cmbAwayTeam.Text;

            homeTeam = tm.GetTeamFromName(homeTeamName);
            awayTeam = tm.GetTeamFromName(awayTeamName);

            homeTeam.Players[0].Points = 0;
            homeTeam.Players[0].Assists = 0;
            homeTeam.Players[0].Rebounds = 0;
            firstHomePlayerPoints = homeTeam.Players[0].ParticipateInGame();
            System.Threading.Thread.Sleep(50);
            homeTeam.Players[1].Points = 0;
            homeTeam.Players[1].Assists = 0;
            homeTeam.Players[1].Rebounds = 0;
            secondHomePlayerPoints = homeTeam.Players[1].ParticipateInGame();
            System.Threading.Thread.Sleep(50);
            awayTeam.Players[0].Points = 0;
            awayTeam.Players[0].Assists = 0;
            awayTeam.Players[0].Rebounds = 0;
            firstAwayPlayerPoints = awayTeam.Players[0].ParticipateInGame();
            System.Threading.Thread.Sleep(50);
            awayTeam.Players[1].Points = 0;
            awayTeam.Players[1].Assists = 0;
            awayTeam.Players[1].Rebounds = 0;
            secondAwayPlayerPoints = awayTeam.Players[1].ParticipateInGame();
            homeTeamFirstPlayerName = homeTeam.Players[0].Name;
            homeTeamSecondPlayerName = homeTeam.Players[1].Name;
            awayTeamFirstPlayerName = awayTeam.Players[0].Name;
            awayTeamSecondPlayerName = awayTeam.Players[1].Name;
            finalScoreHomeTeam = firstHomePlayerPoints + secondHomePlayerPoints;
            finalScoreAwayTeam = firstAwayPlayerPoints + secondAwayPlayerPoints;

        }
        private void HideAll()
        {
            lblGameInProgress.Hide();
            lblFinalScore.Hide();
            lblAwayTeamPoints.Hide();
            lblHomeTeamPoints.Hide();
            
            lblFirstHomePlayerScore.Hide();
            lblPlayersPoints.Hide();
            lblSecondHomePlayerScore.Hide();
            lblFirstAwayPlayerScore.Hide();
            lblSecondAwayPlayerScore.Hide();
            
        }
        private void ShowBallProgress()
        {
            pictureBox1.ImageLocation = "../../bin/NewBall.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            MakeTransparent(pictureBox1);
            pictureBox2.ImageLocation = "../../bin/NewBall.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            MakeTransparent(pictureBox2);
            pictureBox3.ImageLocation = "../../bin/NewBall.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            MakeTransparent(pictureBox3);
            pictureBox4.ImageLocation = "../../bin/NewBall.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            MakeTransparent(pictureBox4);
            pictureBox5.ImageLocation = "../../bin/NewBall.png";
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            MakeTransparent(pictureBox5);

            pictureBox6.ImageLocation = "../../bin/Court.png";
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            
        }

        void MakeTransparent(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Parent = pictureBox6;
            pictureBox.Location =
                new Point(
                    pictureBox.Location.X
                    - pictureBox6.Location.X,
                    pictureBox.Location.Y
                    - pictureBox6.Location.Y);
        }

        private void lblFirstHomePlayerScore_Click(object sender, EventArgs e)
        {

        }

        private void cmbHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
