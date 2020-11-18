namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnCreateLeague = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPlayGame = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnManageTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddNewTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDeleteTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtTeamNameToDel = new System.Windows.Forms.ToolStripTextBox();
            this.BtnViewPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPressConference = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPlayersDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.BtmGetPlayersRatingDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtPlayersNameGetRating = new System.Windows.Forms.ToolStripTextBox();
            this.BtmGetPlayersJerseyDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtPlayersNameGetJersey = new System.Windows.Forms.ToolStripTextBox();
            this.BtnPredict = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPredictRookie = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRookieMinutes = new System.Windows.Forms.ToolStripTextBox();
            this.BtnPredictVeteran = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPredictVeteran = new System.Windows.Forms.ToolStripTextBox();
            this.BtnViewLeagueLeadres = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTextGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExportTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReadText = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEndSeason = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnResetLeague = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTeamsTable = new System.Windows.Forms.DataGridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblLeagueName = new System.Windows.Forms.Label();
            this.BtnRefreshTable = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCreateLeague,
            this.BtnPlayGame,
            this.BtnManageTeams,
            this.BtnViewPlayers,
            this.BtnPressConference,
            this.BtnPlayersDictionary,
            this.BtnPredict,
            this.BtnViewLeagueLeadres,
            this.BtnTextGeneral,
            this.BtnEndSeason,
            this.BtnResetLeague});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1040, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnCreateLeague
            // 
            this.BtnCreateLeague.Name = "BtnCreateLeague";
            this.BtnCreateLeague.Size = new System.Drawing.Size(94, 19);
            this.BtnCreateLeague.Text = "Create League";
            this.BtnCreateLeague.Click += new System.EventHandler(this.BtnCreateLeague_Click);
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(75, 19);
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            // 
            // BtnManageTeams
            // 
            this.BtnManageTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddNewTeam,
            this.BtnDeleteTeam});
            this.BtnManageTeams.Name = "BtnManageTeams";
            this.BtnManageTeams.Size = new System.Drawing.Size(98, 19);
            this.BtnManageTeams.Text = "Manage Teams";
            // 
            // BtnAddNewTeam
            // 
            this.BtnAddNewTeam.Name = "BtnAddNewTeam";
            this.BtnAddNewTeam.Size = new System.Drawing.Size(154, 22);
            this.BtnAddNewTeam.Text = "Add New Team";
            this.BtnAddNewTeam.Click += new System.EventHandler(this.BtnAddNewTeam_Click);
            // 
            // BtnDeleteTeam
            // 
            this.BtnDeleteTeam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtTeamNameToDel});
            this.BtnDeleteTeam.Name = "BtnDeleteTeam";
            this.BtnDeleteTeam.Size = new System.Drawing.Size(154, 22);
            this.BtnDeleteTeam.Text = "Delete Team";
            this.BtnDeleteTeam.Click += new System.EventHandler(this.BtnDeleteTeam_Click);
            // 
            // TxtTeamNameToDel
            // 
            this.TxtTeamNameToDel.Name = "TxtTeamNameToDel";
            this.TxtTeamNameToDel.Size = new System.Drawing.Size(100, 23);
            this.TxtTeamNameToDel.Text = "Enter Team Name";
            // 
            // BtnViewPlayers
            // 
            this.BtnViewPlayers.Name = "BtnViewPlayers";
            this.BtnViewPlayers.Size = new System.Drawing.Size(84, 19);
            this.BtnViewPlayers.Text = "View Players";
            this.BtnViewPlayers.Click += new System.EventHandler(this.BtnViewPlayers_Click);
            // 
            // BtnPressConference
            // 
            this.BtnPressConference.Name = "BtnPressConference";
            this.BtnPressConference.Size = new System.Drawing.Size(110, 19);
            this.BtnPressConference.Text = "Press Conference";
            this.BtnPressConference.Click += new System.EventHandler(this.BtnPressConference_Click);
            // 
            // BtnPlayersDictionary
            // 
            this.BtnPlayersDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtmGetPlayersRatingDictionary,
            this.BtmGetPlayersJerseyDictionary});
            this.BtnPlayersDictionary.Name = "BtnPlayersDictionary";
            this.BtnPlayersDictionary.Size = new System.Drawing.Size(113, 19);
            this.BtnPlayersDictionary.Text = "Players Dictionary";
            // 
            // BtmGetPlayersRatingDictionary
            // 
            this.BtmGetPlayersRatingDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtPlayersNameGetRating});
            this.BtmGetPlayersRatingDictionary.Name = "BtmGetPlayersRatingDictionary";
            this.BtmGetPlayersRatingDictionary.Size = new System.Drawing.Size(216, 22);
            this.BtmGetPlayersRatingDictionary.Text = "Get Player\'s Rating";
            this.BtmGetPlayersRatingDictionary.Click += new System.EventHandler(this.BtmGetPlayersRatingDictionary_Click);
            // 
            // TxtPlayersNameGetRating
            // 
            this.TxtPlayersNameGetRating.Name = "TxtPlayersNameGetRating";
            this.TxtPlayersNameGetRating.Size = new System.Drawing.Size(120, 23);
            this.TxtPlayersNameGetRating.Text = "Enter Player\'s Name";
            // 
            // BtmGetPlayersJerseyDictionary
            // 
            this.BtmGetPlayersJerseyDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtPlayersNameGetJersey});
            this.BtmGetPlayersJerseyDictionary.Name = "BtmGetPlayersJerseyDictionary";
            this.BtmGetPlayersJerseyDictionary.Size = new System.Drawing.Size(216, 22);
            this.BtmGetPlayersJerseyDictionary.Text = "Get Player\'s Jersey Number";
            this.BtmGetPlayersJerseyDictionary.Click += new System.EventHandler(this.BtmGetPlayersJerseyDictionary_Click);
            // 
            // TxtPlayersNameGetJersey
            // 
            this.TxtPlayersNameGetJersey.Name = "TxtPlayersNameGetJersey";
            this.TxtPlayersNameGetJersey.Size = new System.Drawing.Size(120, 23);
            this.TxtPlayersNameGetJersey.Text = "Enter Player\'s Name";
            // 
            // BtnPredict
            // 
            this.BtnPredict.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnPredictRookie,
            this.BtnPredictVeteran});
            this.BtnPredict.Name = "BtnPredict";
            this.BtnPredict.Size = new System.Drawing.Size(102, 19);
            this.BtnPredict.Text = "Predict Average";
            // 
            // BtnPredictRookie
            // 
            this.BtnPredictRookie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtRookieMinutes});
            this.BtnPredictRookie.Name = "BtnPredictRookie";
            this.BtnPredictRookie.Size = new System.Drawing.Size(251, 22);
            this.BtnPredictRookie.Text = "Predict Rookie Points By Minutes";
            this.BtnPredictRookie.Click += new System.EventHandler(this.BtnPredictRookie_Click);
            // 
            // txtRookieMinutes
            // 
            this.txtRookieMinutes.Name = "txtRookieMinutes";
            this.txtRookieMinutes.Size = new System.Drawing.Size(100, 23);
            this.txtRookieMinutes.Text = "Enter Minutes";
            // 
            // BtnPredictVeteran
            // 
            this.BtnPredictVeteran.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtPredictVeteran});
            this.BtnPredictVeteran.Name = "BtnPredictVeteran";
            this.BtnPredictVeteran.Size = new System.Drawing.Size(251, 22);
            this.BtnPredictVeteran.Text = "Predict Veteran Points By Minutes";
            this.BtnPredictVeteran.Click += new System.EventHandler(this.BtnPredictVeteran_Click);
            // 
            // txtPredictVeteran
            // 
            this.txtPredictVeteran.Name = "txtPredictVeteran";
            this.txtPredictVeteran.Size = new System.Drawing.Size(100, 23);
            this.txtPredictVeteran.Text = "Enter Minutes";
            // 
            // BtnViewLeagueLeadres
            // 
            this.BtnViewLeagueLeadres.Name = "BtnViewLeagueLeadres";
            this.BtnViewLeagueLeadres.Size = new System.Drawing.Size(128, 19);
            this.BtnViewLeagueLeadres.Text = "View League Leaders";
            this.BtnViewLeagueLeadres.Click += new System.EventHandler(this.BtnViewLeagueLeadres_Click);
            // 
            // BtnTextGeneral
            // 
            this.BtnTextGeneral.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnExportTxt,
            this.BtnReadText});
            this.BtnTextGeneral.Name = "BtnTextGeneral";
            this.BtnTextGeneral.Size = new System.Drawing.Size(38, 19);
            this.BtnTextGeneral.Text = "TXT";
            // 
            // BtnExportTxt
            // 
            this.BtnExportTxt.Name = "BtnExportTxt";
            this.BtnExportTxt.Size = new System.Drawing.Size(158, 22);
            this.BtnExportTxt.Text = "Export to txt file";
            this.BtnExportTxt.Click += new System.EventHandler(this.BtnExportTxt_Click);
            // 
            // BtnReadText
            // 
            this.BtnReadText.Name = "BtnReadText";
            this.BtnReadText.Size = new System.Drawing.Size(158, 22);
            this.BtnReadText.Text = "Read txt file";
            this.BtnReadText.Click += new System.EventHandler(this.BtnReadText_Click);
            // 
            // BtnEndSeason
            // 
            this.BtnEndSeason.Name = "BtnEndSeason";
            this.BtnEndSeason.Size = new System.Drawing.Size(79, 19);
            this.BtnEndSeason.Text = "End Season";
            this.BtnEndSeason.Click += new System.EventHandler(this.BtnEndSeason_Click);
            // 
            // BtnResetLeague
            // 
            this.BtnResetLeague.Name = "BtnResetLeague";
            this.BtnResetLeague.Size = new System.Drawing.Size(88, 19);
            this.BtnResetLeague.Text = "Reset League";
            this.BtnResetLeague.Click += new System.EventHandler(this.BtnResetLeague_Click);
            // 
            // dgvTeamsTable
            // 
            this.dgvTeamsTable.AllowUserToAddRows = false;
            this.dgvTeamsTable.AllowUserToDeleteRows = false;
            this.dgvTeamsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTeamsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamsTable.Enabled = false;
            this.dgvTeamsTable.Location = new System.Drawing.Point(0, 79);
            this.dgvTeamsTable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvTeamsTable.Name = "dgvTeamsTable";
            this.dgvTeamsTable.ReadOnly = true;
            this.dgvTeamsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTeamsTable.ShowEditingIcon = false;
            this.dgvTeamsTable.Size = new System.Drawing.Size(1040, 436);
            this.dgvTeamsTable.TabIndex = 1;
            this.dgvTeamsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeamsTable_CellContentClick);
            // 
            // tmr
            // 
            this.tmr.Interval = 3000;
            this.tmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLeagueName
            // 
            this.lblLeagueName.AutoSize = true;
            this.lblLeagueName.Location = new System.Drawing.Point(12, 39);
            this.lblLeagueName.Name = "lblLeagueName";
            this.lblLeagueName.Size = new System.Drawing.Size(92, 22);
            this.lblLeagueName.TabIndex = 2;
            this.lblLeagueName.Text = "Welcome";
            // 
            // BtnRefreshTable
            // 
            this.BtnRefreshTable.Location = new System.Drawing.Point(884, 36);
            this.BtnRefreshTable.Name = "BtnRefreshTable";
            this.BtnRefreshTable.Size = new System.Drawing.Size(144, 28);
            this.BtnRefreshTable.TabIndex = 3;
            this.BtnRefreshTable.Text = "Refresh Table";
            this.BtnRefreshTable.UseVisualStyleBackColor = true;
            this.BtnRefreshTable.Click += new System.EventHandler(this.BtnRefreshTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 515);
            this.Controls.Add(this.BtnRefreshTable);
            this.Controls.Add(this.lblLeagueName);
            this.Controls.Add(this.dgvTeamsTable);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnManageTeams;
        private System.Windows.Forms.ToolStripMenuItem BtnViewPlayers;
        private System.Windows.Forms.ToolStripMenuItem BtnPlayGame;
        private System.Windows.Forms.ToolStripMenuItem BtnTextGeneral;
        private System.Windows.Forms.ToolStripMenuItem BtnExportTxt;
        private System.Windows.Forms.ToolStripMenuItem BtnReadText;
        private System.Windows.Forms.ToolStripMenuItem BtnCreateLeague;
        private System.Windows.Forms.DataGridView dgvTeamsTable;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.ToolStripMenuItem BtnAddNewTeam;
        private System.Windows.Forms.ToolStripMenuItem BtnDeleteTeam;
        private System.Windows.Forms.ToolStripTextBox TxtTeamNameToDel;
        private System.Windows.Forms.ToolStripMenuItem BtnPlayersDictionary;
        private System.Windows.Forms.ToolStripMenuItem BtnPressConference;
        private System.Windows.Forms.ToolStripMenuItem BtnEndSeason;
        private System.Windows.Forms.ToolStripMenuItem BtnViewLeagueLeadres;
        private System.Windows.Forms.ToolStripMenuItem BtmGetPlayersRatingDictionary;
        private System.Windows.Forms.ToolStripMenuItem BtmGetPlayersJerseyDictionary;
        private System.Windows.Forms.ToolStripTextBox TxtPlayersNameGetRating;
        private System.Windows.Forms.ToolStripTextBox TxtPlayersNameGetJersey;
        private System.Windows.Forms.Label lblLeagueName;
        private System.Windows.Forms.Button BtnRefreshTable;
        private System.Windows.Forms.ToolStripMenuItem BtnResetLeague;
        private System.Windows.Forms.ToolStripMenuItem BtnPredict;
        private System.Windows.Forms.ToolStripMenuItem BtnPredictRookie;
        private System.Windows.Forms.ToolStripTextBox txtRookieMinutes;
        private System.Windows.Forms.ToolStripMenuItem BtnPredictVeteran;
        private System.Windows.Forms.ToolStripTextBox txtPredictVeteran;
    }
}

