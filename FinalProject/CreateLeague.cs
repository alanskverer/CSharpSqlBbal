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
    public partial class CreateLeague : Form
    {
        public League newLeague;
        TableManage tm;
        
        public CreateLeague()
        {
            InitializeComponent();
            tm = new TableManage();
        }

        private void BtnCreateLeague_Click(object sender, EventArgs e)
        {

            try
            {
                string name = txtLeagueName.Text;
                int numOfTeams = int.Parse(txtNumOfTeams.Text);
                newLeague = new League(name, numOfTeams);
                //DialogResult = DialogResult.OK;
                tm.AddLeague(newLeague);
                MessageBox.Show($"{name} was created successfully with {numOfTeams} teams in it");

                this.Close();


            }
            catch (Exception error)
            {

                MessageBox.Show("Please enter a valid number of teams ");
                //MessageBox.Show("ERROR: "+error.Message);
            }
        }
        public League SendLeague()
        {
            return newLeague;
        }

        private void CreateLeague_Load(object sender, EventArgs e)
        {

        }
    }
}
