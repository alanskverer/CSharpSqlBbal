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
    public partial class AddTeam : Form
    {
        string color= "";
        TableManage tm;
        bool playerAdded;
        List<Player> players;
        string[] positions;
        Player rookie;
        Player veteran;
        Team newTeam;
        League league;
        int playersToAdd;
        public AddTeam()
        {
            InitializeComponent();

            tm = new TableManage();
           
            
            playersToAdd = 2;
            players = new List<Player>();
            positions = new string[]
            {

                "Point Guard",
                "Shooting Guard",
                "Small Forward",
                "Power Forward",
                "Center"
            };
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {
            cmbPosition.DataSource = positions;
            playerAdded = false;
            checkBoxHumble.Hide();
        }

        private void numericUpDownYearsInLeague_ValueChanged_1(object sender, EventArgs e)
        {

            try
            {
                int number = int.Parse(numericUpDownYearsInLeague.Value.ToString());
                if (number > 2)
                {
                    checkBoxHumble.Show();
                }
                else
                {
                    checkBoxHumble.Hide();
                }
            }
            catch (Exception)
            {

            }


        }

        private void BtnChooseColor_Click(object sender, EventArgs e)
        {
            Color chosenColor = ShowColorPicker();
            if (chosenColor.Name.ToLower().Equals("mediumvioletred") && !color.Equals("mediumvioletred"))
            {
                return;
            }
            txtColorChosen.BackColor = chosenColor;
            color = chosenColor.Name.ToLower();

        }

        private Color ShowColorPicker()
        {
            try
            {
                ColorDialog colorDialog1 = new ColorDialog();
                DialogResult result = colorDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {

                    return colorDialog1.Color;

                }
            }
            catch (Exception)
            {
                System.Windows.Forms.DialogResult dr =
                MessageBox.Show("An error has occured"
                 , "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
            return Color.MediumVioletRed;
        }



        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {



            lblPLayersLeft.Text = $"{playersToAdd} Players left to add";
            BtnDoneAdding.Enabled = false;
            string playerName, playerPosition;
            int jersey, rating, yearsInTheLeague;
            decimal vIn = 0;
            if (!playerAdded)
            {
                string teamName = txtTeamName.Text;


                newTeam = new Team(teamName, color);
                //tm.AddTeam(newTeam);
                playerAdded = true;
                txtTeamName.ReadOnly = true;
                BtnChooseColor.Enabled = false;
            }
            playerName = TxtPlayerName.Text;
            playerPosition = cmbPosition.SelectedValue.ToString();
            vIn = numericUpDownRating.Value;
            rating = Convert.ToInt32(vIn);
            vIn = numericUpDownYearsInLeague.Value;
            yearsInTheLeague = Convert.ToInt32(vIn);
            vIn = numericUpDownJersey.Value;
            jersey = Convert.ToInt32(vIn);
            if (yearsInTheLeague <= 2)
            {

                DialogResult dialogResult = MessageBox.Show("Is your player excited about getting into the team?", "check", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    rookie = new Rookie(playerName, playerPosition, jersey, yearsInTheLeague, rating, true);


                }
                else if (dialogResult == DialogResult.No)
                {
                    rookie = new Rookie(playerName, playerPosition, jersey, yearsInTheLeague, rating, false);
                }
                players.Add(rookie);
                newTeam.Players = players;
                playersToAdd--;
                lblPLayersLeft.Text = $"{playersToAdd} Players left to add";
                if (playersToAdd==0)
                {
                    lblPLayersLeft.Text = $"{playersToAdd} Players left to add";
                    BtnAddPlayer.Enabled = false;
                    BtnDoneAdding.Enabled = true;
                    ReadOnly();
                }
                MessageBox.Show($"{playerName} was added to the team successfully");
                ClearPicks();
            }
            else
            {
                if (checkBoxHumble.Checked)
                {
                    veteran = new Veteran(playerName, playerPosition, jersey, yearsInTheLeague, rating, true);
                }
                else
                {
                    veteran = new Veteran(playerName, playerPosition, jersey, yearsInTheLeague, rating, false);
                }
                players.Add(veteran);

                playersToAdd--;
                lblPLayersLeft.Text = $"{playersToAdd} Players left to add";

                if (playersToAdd == 0)
                {
                    BtnAddPlayer.Enabled = false;
                    BtnDoneAdding.Enabled = true;
                    ReadOnly();
                }
                MessageBox.Show($"{playerName} was added to the team successfully");
                ClearPicks();


            }
           
           
        }

        private void BtnDoneAdding_Click(object sender, EventArgs e)
        {
            league = tm.GetLeague();
            if (league != null)
            {
                newTeam.Players = players;
                tm.AddTeam(newTeam);
                if (league.AddTeamToTheLeague(newTeam))
                {
                    MessageBox.Show("Team was added successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("League is already full");
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("League doesn't exist in database. If problem persists, reset league.");
            }

        }
        public void ClearPicks()
        {
            TxtPlayerName.Clear();
            Decimal d = 0;
            numericUpDownJersey.Value = d;
            numericUpDownRating.Value = d;
            numericUpDownYearsInLeague.Value = d;
            cmbPosition.DataSource = positions;
            checkBoxHumble.Checked = false;


        }
        public void ReadOnly()
        {
            numericUpDownJersey.ReadOnly = true;
            numericUpDownRating.ReadOnly = true;
            numericUpDownYearsInLeague.ReadOnly = true;
            TxtPlayerName.ReadOnly = true;
            cmbPosition.Enabled = false;
            checkBoxHumble.Enabled = false;
        }
        
        //numericUpDownYearsInLeague
    }
}
