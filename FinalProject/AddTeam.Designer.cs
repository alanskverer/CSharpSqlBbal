namespace FinalProject
{
    partial class AddTeam
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnChooseColor = new System.Windows.Forms.Button();
            this.txtColorChosen = new System.Windows.Forms.TextBox();
            this.BtnDoneAdding = new System.Windows.Forms.Button();
            this.lbladdPlayers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.numericUpDownYearsInLeague = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJersey = new System.Windows.Forms.NumericUpDown();
            this.BtnAddPlayer = new System.Windows.Forms.Button();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxHumble = new System.Windows.Forms.CheckBox();
            this.lblPLayersLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearsInLeague)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJersey)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(102, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(593, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please fill up the information below to add a team to the league";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(99, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team Name:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(316, 117);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(185, 20);
            this.txtTeamName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(102, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team Color:";
            // 
            // BtnChooseColor
            // 
            this.BtnChooseColor.Location = new System.Drawing.Point(316, 156);
            this.BtnChooseColor.Name = "BtnChooseColor";
            this.BtnChooseColor.Size = new System.Drawing.Size(185, 31);
            this.BtnChooseColor.TabIndex = 9;
            this.BtnChooseColor.Text = "Choose Color";
            this.BtnChooseColor.UseVisualStyleBackColor = true;
            this.BtnChooseColor.Click += new System.EventHandler(this.BtnChooseColor_Click);
            // 
            // txtColorChosen
            // 
            this.txtColorChosen.Enabled = false;
            this.txtColorChosen.Location = new System.Drawing.Point(507, 162);
            this.txtColorChosen.Name = "txtColorChosen";
            this.txtColorChosen.Size = new System.Drawing.Size(24, 20);
            this.txtColorChosen.TabIndex = 10;
            // 
            // BtnDoneAdding
            // 
            this.BtnDoneAdding.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnDoneAdding.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnDoneAdding.Location = new System.Drawing.Point(307, 658);
            this.BtnDoneAdding.Name = "BtnDoneAdding";
            this.BtnDoneAdding.Size = new System.Drawing.Size(200, 41);
            this.BtnDoneAdding.TabIndex = 11;
            this.BtnDoneAdding.Text = "Done";
            this.BtnDoneAdding.UseVisualStyleBackColor = false;
            this.BtnDoneAdding.Click += new System.EventHandler(this.BtnDoneAdding_Click);
            // 
            // lbladdPlayers
            // 
            this.lbladdPlayers.AutoSize = true;
            this.lbladdPlayers.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbladdPlayers.Location = new System.Drawing.Point(300, 209);
            this.lbladdPlayers.Name = "lbladdPlayers";
            this.lbladdPlayers.Size = new System.Drawing.Size(158, 32);
            this.lbladdPlayers.TabIndex = 12;
            this.lbladdPlayers.Text = "Add Player";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(117, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Full Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(65, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Jersey Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(12, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Years In The League:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(151, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rating:";
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.Location = new System.Drawing.Point(316, 291);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(185, 20);
            this.TxtPlayerName.TabIndex = 17;
            // 
            // numericUpDownYearsInLeague
            // 
            this.numericUpDownYearsInLeague.Location = new System.Drawing.Point(316, 387);
            this.numericUpDownYearsInLeague.Name = "numericUpDownYearsInLeague";
            this.numericUpDownYearsInLeague.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownYearsInLeague.TabIndex = 21;
            this.numericUpDownYearsInLeague.ValueChanged += new System.EventHandler(this.numericUpDownYearsInLeague_ValueChanged_1);
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(316, 430);
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownRating.TabIndex = 22;
            // 
            // numericUpDownJersey
            // 
            this.numericUpDownJersey.Location = new System.Drawing.Point(316, 339);
            this.numericUpDownJersey.Name = "numericUpDownJersey";
            this.numericUpDownJersey.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownJersey.TabIndex = 23;
            // 
            // BtnAddPlayer
            // 
            this.BtnAddPlayer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAddPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnAddPlayer.Location = new System.Drawing.Point(307, 594);
            this.BtnAddPlayer.Name = "BtnAddPlayer";
            this.BtnAddPlayer.Size = new System.Drawing.Size(200, 41);
            this.BtnAddPlayer.TabIndex = 24;
            this.BtnAddPlayer.Text = "Add Player";
            this.BtnAddPlayer.UseVisualStyleBackColor = false;
            this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(316, 503);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(191, 21);
            this.cmbPosition.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(128, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Position:";
            // 
            // checkBoxHumble
            // 
            this.checkBoxHumble.AutoSize = true;
            this.checkBoxHumble.Location = new System.Drawing.Point(346, 550);
            this.checkBoxHumble.Name = "checkBoxHumble";
            this.checkBoxHumble.Size = new System.Drawing.Size(100, 17);
            this.checkBoxHumble.TabIndex = 27;
            this.checkBoxHumble.Text = "Humble Player?";
            this.checkBoxHumble.UseVisualStyleBackColor = true;
            // 
            // lblPLayersLeft
            // 
            this.lblPLayersLeft.AutoSize = true;
            this.lblPLayersLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPLayersLeft.Location = new System.Drawing.Point(303, 253);
            this.lblPLayersLeft.Name = "lblPLayersLeft";
            this.lblPLayersLeft.Size = new System.Drawing.Size(169, 19);
            this.lblPLayersLeft.TabIndex = 28;
            this.lblPLayersLeft.Text = "2 Players Left To Add";
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.lblPLayersLeft);
            this.Controls.Add(this.checkBoxHumble);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.BtnAddPlayer);
            this.Controls.Add(this.numericUpDownJersey);
            this.Controls.Add(this.numericUpDownRating);
            this.Controls.Add(this.numericUpDownYearsInLeague);
            this.Controls.Add(this.TxtPlayerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbladdPlayers);
            this.Controls.Add(this.BtnDoneAdding);
            this.Controls.Add(this.txtColorChosen);
            this.Controls.Add(this.BtnChooseColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            this.Load += new System.EventHandler(this.AddTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearsInLeague)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJersey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnChooseColor;
        private System.Windows.Forms.TextBox txtColorChosen;
        private System.Windows.Forms.Button BtnDoneAdding;
        private System.Windows.Forms.Label lbladdPlayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.NumericUpDown numericUpDownYearsInLeague;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.NumericUpDown numericUpDownJersey;
        private System.Windows.Forms.Button BtnAddPlayer;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxHumble;
        private System.Windows.Forms.Label lblPLayersLeft;
    }
}