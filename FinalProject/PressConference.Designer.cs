namespace FinalProject
{
    partial class PressConference
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbChoosePlayer = new System.Windows.Forms.ComboBox();
            this.btnInterview = new System.Windows.Forms.Button();
            this.lblPlayersAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerSays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(321, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbChoosePlayer
            // 
            this.cmbChoosePlayer.FormattingEnabled = true;
            this.cmbChoosePlayer.Location = new System.Drawing.Point(1164, 82);
            this.cmbChoosePlayer.Name = "cmbChoosePlayer";
            this.cmbChoosePlayer.Size = new System.Drawing.Size(164, 21);
            this.cmbChoosePlayer.TabIndex = 1;
            this.cmbChoosePlayer.Text = "Choose Player";
            // 
            // btnInterview
            // 
            this.btnInterview.Location = new System.Drawing.Point(1164, 109);
            this.btnInterview.Name = "btnInterview";
            this.btnInterview.Size = new System.Drawing.Size(164, 43);
            this.btnInterview.TabIndex = 2;
            this.btnInterview.Text = "Interview";
            this.btnInterview.UseVisualStyleBackColor = true;
            this.btnInterview.Click += new System.EventHandler(this.btnInterview_Click);
            // 
            // lblPlayersAnswer
            // 
            this.lblPlayersAnswer.AutoSize = true;
            this.lblPlayersAnswer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayersAnswer.Location = new System.Drawing.Point(252, 528);
            this.lblPlayersAnswer.Name = "lblPlayersAnswer";
            this.lblPlayersAnswer.Size = new System.Drawing.Size(145, 24);
            this.lblPlayersAnswer.TabIndex = 3;
            this.lblPlayersAnswer.Text = "Player answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1196, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Player";
            // 
            // lblPlayerSays
            // 
            this.lblPlayerSays.AutoSize = true;
            this.lblPlayerSays.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayerSays.Location = new System.Drawing.Point(252, 483);
            this.lblPlayerSays.Name = "lblPlayerSays";
            this.lblPlayerSays.Size = new System.Drawing.Size(124, 24);
            this.lblPlayerSays.TabIndex = 5;
            this.lblPlayerSays.Text = "Player Says";
            // 
            // PressConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblPlayerSays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayersAnswer);
            this.Controls.Add(this.btnInterview);
            this.Controls.Add(this.cmbChoosePlayer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PressConference";
            this.Text = "PressConference";
            this.Load += new System.EventHandler(this.PressConference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbChoosePlayer;
        private System.Windows.Forms.Button btnInterview;
        private System.Windows.Forms.Label lblPlayersAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerSays;
    }
}