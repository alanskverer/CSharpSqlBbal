namespace FinalProject
{
    partial class lblSelectATeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.BtnShowPlayers = new System.Windows.Forms.Button();
            this.lblFirstPlayerDetails = new System.Windows.Forms.Label();
            this.lblSecondPlayerDetails = new System.Windows.Forms.Label();
            this.lblFirstPlayerStats = new System.Windows.Forms.Label();
            this.lblSeondPlayerStats = new System.Windows.Forms.Label();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select a Team";
            // 
            // cmbTeams
            // 
            this.cmbTeams.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(317, 35);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(165, 27);
            this.cmbTeams.TabIndex = 1;
            // 
            // BtnShowPlayers
            // 
            this.BtnShowPlayers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnShowPlayers.Location = new System.Drawing.Point(8, 25);
            this.BtnShowPlayers.Name = "BtnShowPlayers";
            this.BtnShowPlayers.Size = new System.Drawing.Size(146, 37);
            this.BtnShowPlayers.TabIndex = 2;
            this.BtnShowPlayers.Text = "Show Players";
            this.BtnShowPlayers.UseVisualStyleBackColor = true;
            this.BtnShowPlayers.Click += new System.EventHandler(this.BtnShowPlayers_Click);
            // 
            // lblFirstPlayerDetails
            // 
            this.lblFirstPlayerDetails.AutoSize = true;
            this.lblFirstPlayerDetails.Font = new System.Drawing.Font("Arial", 8.5F);
            this.lblFirstPlayerDetails.Location = new System.Drawing.Point(7, 130);
            this.lblFirstPlayerDetails.Name = "lblFirstPlayerDetails";
            this.lblFirstPlayerDetails.Size = new System.Drawing.Size(63, 15);
            this.lblFirstPlayerDetails.TabIndex = 3;
            this.lblFirstPlayerDetails.Text = "first player";
            // 
            // lblSecondPlayerDetails
            // 
            this.lblSecondPlayerDetails.AutoSize = true;
            this.lblSecondPlayerDetails.Font = new System.Drawing.Font("Arial", 8.5F);
            this.lblSecondPlayerDetails.Location = new System.Drawing.Point(7, 203);
            this.lblSecondPlayerDetails.Name = "lblSecondPlayerDetails";
            this.lblSecondPlayerDetails.Size = new System.Drawing.Size(84, 15);
            this.lblSecondPlayerDetails.TabIndex = 4;
            this.lblSecondPlayerDetails.Text = "second player";
            // 
            // lblFirstPlayerStats
            // 
            this.lblFirstPlayerStats.AutoSize = true;
            this.lblFirstPlayerStats.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFirstPlayerStats.Location = new System.Drawing.Point(7, 419);
            this.lblFirstPlayerStats.Name = "lblFirstPlayerStats";
            this.lblFirstPlayerStats.Size = new System.Drawing.Size(93, 15);
            this.lblFirstPlayerStats.TabIndex = 5;
            this.lblFirstPlayerStats.Text = "first player stats";
            // 
            // lblSeondPlayerStats
            // 
            this.lblSeondPlayerStats.AutoSize = true;
            this.lblSeondPlayerStats.Font = new System.Drawing.Font("Arial", 9F);
            this.lblSeondPlayerStats.Location = new System.Drawing.Point(7, 474);
            this.lblSeondPlayerStats.Name = "lblSeondPlayerStats";
            this.lblSeondPlayerStats.Size = new System.Drawing.Size(114, 15);
            this.lblSeondPlayerStats.TabIndex = 6;
            this.lblSeondPlayerStats.Text = "second player stats";
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblGeneralInfo.Location = new System.Drawing.Point(344, 82);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(101, 19);
            this.lblGeneralInfo.TabIndex = 7;
            this.lblGeneralInfo.Text = "General Info";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStats.Location = new System.Drawing.Point(364, 335);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(48, 19);
            this.lblStats.TabIndex = 8;
            this.lblStats.Text = "Stats";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(572, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectATeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblGeneralInfo);
            this.Controls.Add(this.lblSeondPlayerStats);
            this.Controls.Add(this.lblFirstPlayerStats);
            this.Controls.Add(this.lblSecondPlayerDetails);
            this.Controls.Add(this.lblFirstPlayerDetails);
            this.Controls.Add(this.BtnShowPlayers);
            this.Controls.Add(this.cmbTeams);
            this.Controls.Add(this.label1);
            this.Name = "lblSelectATeam";
            this.Text = "ViewPlayers";
            this.Load += new System.EventHandler(this.lblSelectATeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Button BtnShowPlayers;
        private System.Windows.Forms.Label lblFirstPlayerDetails;
        private System.Windows.Forms.Label lblSecondPlayerDetails;
        private System.Windows.Forms.Label lblFirstPlayerStats;
        private System.Windows.Forms.Label lblSeondPlayerStats;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}