namespace FinalProject
{
    partial class CreateLeague
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeagueName = new System.Windows.Forms.TextBox();
            this.txtNumOfTeams = new System.Windows.Forms.TextBox();
            this.BtnCreateLeague = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(54, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "League Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Teams:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(232, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please fill up the information below to create a league";
            // 
            // txtLeagueName
            // 
            this.txtLeagueName.Location = new System.Drawing.Point(238, 160);
            this.txtLeagueName.Name = "txtLeagueName";
            this.txtLeagueName.Size = new System.Drawing.Size(185, 20);
            this.txtLeagueName.TabIndex = 4;
            // 
            // txtNumOfTeams
            // 
            this.txtNumOfTeams.Location = new System.Drawing.Point(238, 233);
            this.txtNumOfTeams.Name = "txtNumOfTeams";
            this.txtNumOfTeams.Size = new System.Drawing.Size(185, 20);
            this.txtNumOfTeams.TabIndex = 5;
            // 
            // BtnCreateLeague
            // 
            this.BtnCreateLeague.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCreateLeague.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnCreateLeague.Location = new System.Drawing.Point(176, 378);
            this.BtnCreateLeague.Name = "BtnCreateLeague";
            this.BtnCreateLeague.Size = new System.Drawing.Size(200, 41);
            this.BtnCreateLeague.TabIndex = 6;
            this.BtnCreateLeague.Text = "Create League";
            this.BtnCreateLeague.UseVisualStyleBackColor = false;
            this.BtnCreateLeague.Click += new System.EventHandler(this.BtnCreateLeague_Click);
            // 
            // CreateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 472);
            this.Controls.Add(this.BtnCreateLeague);
            this.Controls.Add(this.txtNumOfTeams);
            this.Controls.Add(this.txtLeagueName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateLeague";
            this.Text = "CreateLeague";
            this.Load += new System.EventHandler(this.CreateLeague_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeagueName;
        private System.Windows.Forms.TextBox txtNumOfTeams;
        private System.Windows.Forms.Button BtnCreateLeague;
    }
}