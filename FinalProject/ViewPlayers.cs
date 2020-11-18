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
    public partial class lblSelectATeam : Form
    {
        TableManage tm;
        string teamName;
        List<Player> players;
        Team team;
        public lblSelectATeam()
        {
            InitializeComponent();
            tm = new TableManage();
        }

        private void lblSelectATeam_Load(object sender, EventArgs e)
        {
            cmbTeams.DataSource = tm.GetTeamsNames();
            pictureBox1.ImageLocation = "../../bin/Player.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.BackColor = Color.Transparent;
            HideAll();


        }

        private void BtnShowPlayers_Click(object sender, EventArgs e)
        {
            teamName = cmbTeams.Text;
            team = tm.GetTeamFromName(teamName);
            players = tm.GetPlayersFromTeam(team);
            lblFirstPlayerDetails.Text = players[0].ToString();
            lblSecondPlayerDetails.Text = players[1].ToString();
            lblFirstPlayerStats.Text = players[0].ShowStats();
            lblSeondPlayerStats.Text = players[1].ShowStats();
            ShowAll();
            



        }
        public void HideAll()
        {
            lblFirstPlayerDetails.Hide();
            lblFirstPlayerStats.Hide();
            lblSecondPlayerDetails.Hide();
            lblSeondPlayerStats.Hide();
            lblStats.Hide();
            lblGeneralInfo.Hide();
        }
        public void ShowAll()
        {
            lblFirstPlayerDetails.Show();
            lblFirstPlayerStats.Show();
            lblSecondPlayerDetails.Show();
            lblSeondPlayerStats.Show();
            lblGeneralInfo.Show();
            lblStats.Show();
        }
    }
}
