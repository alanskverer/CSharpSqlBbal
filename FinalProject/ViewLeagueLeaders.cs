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
    public partial class ViewLeagueLeadersLoad : Form
    {
        string[] categories;
        TableManage tm;
        List<Player> players;
        public ViewLeagueLeadersLoad()
        {
            InitializeComponent();
            tm = new TableManage();
            categories = new string[]
            {
                "Points",
                "Assists",
                "Rebounds"
            };
        }

        private void ViewLeagueLeadersLoad_Load(object sender, EventArgs e)
        {
            cmbChooseCategory.DataSource = categories;
        }

        private void BtnSortLeaders_Click(object sender, EventArgs e)
        {
            string res = "";
            int count = 1;
            if (cmbChooseCategory.Text == "Points")
            {
                players = tm.GetAllPlayersInTheLeague();
                players.Sort();
                foreach (Player player in players)
                {
                    res += $"{count++}. {player.Name} With {player.Points} Points\n";
                }
                richTextBox1.Text = res;
                count = 0;

            }
            else if (cmbChooseCategory.Text == "Rebounds")
            {
                players = tm.GetPlayersByStats("Rebounds");
                foreach (Player player in players)
                {
                    res += $"{count++}. {player.Name} With {player.Rebounds} Rebounds\n";
                }
                richTextBox1.Text = res;
                count = 0;
            }
            else
            {
                players = tm.GetPlayersByStats("Assists");
                foreach (Player player in players)
                {
                    res += $"{count++}. {player.Name} With {player.Assists} Assists\n";
                }
                richTextBox1.Text = res;
                count = 0;
            }

        }
    }
}
