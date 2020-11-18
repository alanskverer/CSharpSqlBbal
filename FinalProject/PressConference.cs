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
    public partial class PressConference : Form
    {
        TableManage tm;
        List<Player> players;
        string[] playersNames;
        public PressConference()
        {
            InitializeComponent();
        }

        private void PressConference_Load(object sender, EventArgs e)
        {
            tm = new TableManage();
            lblPlayersAnswer.Hide();
            lblPlayerSays.Hide();

            playersNames = tm.GetPlayersNames();
            cmbChoosePlayer.DataSource = playersNames;

            pictureBox1.ImageLocation = "../../bin/pressConference.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void btnInterview_Click(object sender, EventArgs e)
        {

            players = tm.GetAllPlayersInTheLeague();
            string playerName = cmbChoosePlayer.Text;
            foreach (Player player in players)
            {
                if (player.Name == cmbChoosePlayer.Text)
                {
                    lblPlayersAnswer.Text = $"\"{player.TalkToThePress()}\"";
                }
            }
            lblPlayerSays.Text = $"{playerName} Says:";
            lblPlayerSays.Show();
            lblPlayersAnswer.Show();
        }
    }
}
