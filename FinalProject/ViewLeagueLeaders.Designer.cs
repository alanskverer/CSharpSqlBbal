namespace FinalProject
{
    partial class ViewLeagueLeadersLoad
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
            this.lblChooseCategory = new System.Windows.Forms.Label();
            this.cmbChooseCategory = new System.Windows.Forms.ComboBox();
            this.BtnSortLeaders = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblChooseCategory
            // 
            this.lblChooseCategory.AutoSize = true;
            this.lblChooseCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblChooseCategory.Location = new System.Drawing.Point(350, 33);
            this.lblChooseCategory.Name = "lblChooseCategory";
            this.lblChooseCategory.Size = new System.Drawing.Size(143, 19);
            this.lblChooseCategory.TabIndex = 0;
            this.lblChooseCategory.Text = "Choose Category";
            // 
            // cmbChooseCategory
            // 
            this.cmbChooseCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbChooseCategory.FormattingEnabled = true;
            this.cmbChooseCategory.Location = new System.Drawing.Point(354, 71);
            this.cmbChooseCategory.Name = "cmbChooseCategory";
            this.cmbChooseCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbChooseCategory.Size = new System.Drawing.Size(139, 27);
            this.cmbChooseCategory.TabIndex = 1;
            this.cmbChooseCategory.Text = "Categories";
            // 
            // BtnSortLeaders
            // 
            this.BtnSortLeaders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnSortLeaders.Location = new System.Drawing.Point(69, 59);
            this.BtnSortLeaders.Name = "BtnSortLeaders";
            this.BtnSortLeaders.Size = new System.Drawing.Size(125, 33);
            this.BtnSortLeaders.TabIndex = 2;
            this.BtnSortLeaders.Text = "View Leaders";
            this.BtnSortLeaders.UseVisualStyleBackColor = true;
            this.BtnSortLeaders.Click += new System.EventHandler(this.BtnSortLeaders_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(726, 297);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // ViewLeagueLeadersLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnSortLeaders);
            this.Controls.Add(this.cmbChooseCategory);
            this.Controls.Add(this.lblChooseCategory);
            this.Name = "ViewLeagueLeadersLoad";
            this.Text = "ViewLeagueLeaders";
            this.Load += new System.EventHandler(this.ViewLeagueLeadersLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseCategory;
        private System.Windows.Forms.ComboBox cmbChooseCategory;
        private System.Windows.Forms.Button BtnSortLeaders;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}