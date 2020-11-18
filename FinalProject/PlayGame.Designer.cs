namespace FinalProject
{
    partial class PlayGame
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
            this.cmbHomeTeam = new System.Windows.Forms.ComboBox();
            this.cmbAwayTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblHomeTeamPoints = new System.Windows.Forms.Label();
            this.lblAwayTeamPoints = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblGameInProgress = new System.Windows.Forms.Label();
            this.lblPlayersPoints = new System.Windows.Forms.Label();
            this.lblFirstHomePlayerScore = new System.Windows.Forms.Label();
            this.lblSecondHomePlayerScore = new System.Windows.Forms.Label();
            this.lblFirstAwayPlayerScore = new System.Windows.Forms.Label();
            this.lblSecondAwayPlayerScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHomeTeam
            // 
            this.cmbHomeTeam.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbHomeTeam.FormattingEnabled = true;
            this.cmbHomeTeam.Location = new System.Drawing.Point(361, 40);
            this.cmbHomeTeam.Name = "cmbHomeTeam";
            this.cmbHomeTeam.Size = new System.Drawing.Size(133, 26);
            this.cmbHomeTeam.TabIndex = 0;
            this.cmbHomeTeam.Text = "Choose Team";
            this.cmbHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cmbHomeTeam_SelectedIndexChanged);
            // 
            // cmbAwayTeam
            // 
            this.cmbAwayTeam.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbAwayTeam.FormattingEnabled = true;
            this.cmbAwayTeam.Location = new System.Drawing.Point(890, 40);
            this.cmbAwayTeam.Name = "cmbAwayTeam";
            this.cmbAwayTeam.Size = new System.Drawing.Size(132, 26);
            this.cmbAwayTeam.TabIndex = 1;
            this.cmbAwayTeam.Text = "Choose Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(692, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnStartGame.Location = new System.Drawing.Point(643, 64);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(121, 34);
            this.BtnStartGame.TabIndex = 3;
            this.BtnStartGame.Text = "Start Game";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinalScore.Location = new System.Drawing.Point(276, 552);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(101, 19);
            this.lblFinalScore.TabIndex = 4;
            this.lblFinalScore.Text = "Final Score:";
            // 
            // lblHomeTeamPoints
            // 
            this.lblHomeTeamPoints.AutoSize = true;
            this.lblHomeTeamPoints.Font = new System.Drawing.Font("Arial", 12F);
            this.lblHomeTeamPoints.Location = new System.Drawing.Point(478, 553);
            this.lblHomeTeamPoints.Name = "lblHomeTeamPoints";
            this.lblHomeTeamPoints.Size = new System.Drawing.Size(129, 18);
            this.lblHomeTeamPoints.TabIndex = 5;
            this.lblHomeTeamPoints.Text = "homeTeamPoints";
            // 
            // lblAwayTeamPoints
            // 
            this.lblAwayTeamPoints.AutoSize = true;
            this.lblAwayTeamPoints.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAwayTeamPoints.Location = new System.Drawing.Point(860, 553);
            this.lblAwayTeamPoints.Name = "lblAwayTeamPoints";
            this.lblAwayTeamPoints.Size = new System.Drawing.Size(126, 18);
            this.lblAwayTeamPoints.TabIndex = 6;
            this.lblAwayTeamPoints.Text = "awayTeamPoints";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblGameInProgress
            // 
            this.lblGameInProgress.AutoSize = true;
            this.lblGameInProgress.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGameInProgress.Location = new System.Drawing.Point(640, 110);
            this.lblGameInProgress.Name = "lblGameInProgress";
            this.lblGameInProgress.Size = new System.Drawing.Size(134, 18);
            this.lblGameInProgress.TabIndex = 7;
            this.lblGameInProgress.Text = "Game In Progress";
            // 
            // lblPlayersPoints
            // 
            this.lblPlayersPoints.AutoSize = true;
            this.lblPlayersPoints.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayersPoints.Location = new System.Drawing.Point(137, 606);
            this.lblPlayersPoints.Name = "lblPlayersPoints";
            this.lblPlayersPoints.Size = new System.Drawing.Size(240, 19);
            this.lblPlayersPoints.TabIndex = 9;
            this.lblPlayersPoints.Text = "Players Points For This Game:";
            // 
            // lblFirstHomePlayerScore
            // 
            this.lblFirstHomePlayerScore.AutoSize = true;
            this.lblFirstHomePlayerScore.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFirstHomePlayerScore.Location = new System.Drawing.Point(478, 606);
            this.lblFirstHomePlayerScore.Name = "lblFirstHomePlayerScore";
            this.lblFirstHomePlayerScore.Size = new System.Drawing.Size(169, 18);
            this.lblFirstHomePlayerScore.TabIndex = 10;
            this.lblFirstHomePlayerScore.Text = "first home  player score";
            this.lblFirstHomePlayerScore.Click += new System.EventHandler(this.lblFirstHomePlayerScore_Click);
            // 
            // lblSecondHomePlayerScore
            // 
            this.lblSecondHomePlayerScore.AutoSize = true;
            this.lblSecondHomePlayerScore.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSecondHomePlayerScore.Location = new System.Drawing.Point(478, 635);
            this.lblSecondHomePlayerScore.Name = "lblSecondHomePlayerScore";
            this.lblSecondHomePlayerScore.Size = new System.Drawing.Size(195, 18);
            this.lblSecondHomePlayerScore.TabIndex = 11;
            this.lblSecondHomePlayerScore.Text = "second  home player score";
            // 
            // lblFirstAwayPlayerScore
            // 
            this.lblFirstAwayPlayerScore.AutoSize = true;
            this.lblFirstAwayPlayerScore.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFirstAwayPlayerScore.Location = new System.Drawing.Point(860, 607);
            this.lblFirstAwayPlayerScore.Name = "lblFirstAwayPlayerScore";
            this.lblFirstAwayPlayerScore.Size = new System.Drawing.Size(162, 18);
            this.lblFirstAwayPlayerScore.TabIndex = 12;
            this.lblFirstAwayPlayerScore.Text = "first away player score";
            // 
            // lblSecondAwayPlayerScore
            // 
            this.lblSecondAwayPlayerScore.AutoSize = true;
            this.lblSecondAwayPlayerScore.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSecondAwayPlayerScore.Location = new System.Drawing.Point(860, 635);
            this.lblSecondAwayPlayerScore.Name = "lblSecondAwayPlayerScore";
            this.lblSecondAwayPlayerScore.Size = new System.Drawing.Size(188, 18);
            this.lblSecondAwayPlayerScore.TabIndex = 13;
            this.lblSecondAwayPlayerScore.Text = "second away player score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(429, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 28);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(561, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 28);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(676, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 28);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(803, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 28);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(912, 144);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 28);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(345, 138);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(385, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Home Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(917, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Away Team";
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSecondAwayPlayerScore);
            this.Controls.Add(this.lblFirstAwayPlayerScore);
            this.Controls.Add(this.lblSecondHomePlayerScore);
            this.Controls.Add(this.lblFirstHomePlayerScore);
            this.Controls.Add(this.lblPlayersPoints);
            this.Controls.Add(this.lblGameInProgress);
            this.Controls.Add(this.lblAwayTeamPoints);
            this.Controls.Add(this.lblHomeTeamPoints);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAwayTeam);
            this.Controls.Add(this.cmbHomeTeam);
            this.Controls.Add(this.pictureBox6);
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHomeTeam;
        private System.Windows.Forms.ComboBox cmbAwayTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label lblHomeTeamPoints;
        private System.Windows.Forms.Label lblAwayTeamPoints;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblGameInProgress;
        private System.Windows.Forms.Label lblPlayersPoints;
        private System.Windows.Forms.Label lblFirstHomePlayerScore;
        private System.Windows.Forms.Label lblSecondHomePlayerScore;
        private System.Windows.Forms.Label lblFirstAwayPlayerScore;
        private System.Windows.Forms.Label lblSecondAwayPlayerScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}