namespace TheCaregiver.Dialogs
{
    partial class CharacterCard
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
            this.statsPanel = new System.Windows.Forms.Panel();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbHealth = new System.Windows.Forms.ProgressBar();
            this.btnStatsClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLuck = new System.Windows.Forms.TextBox();
            this.txtAgility = new System.Windows.Forms.TextBox();
            this.txtConstitution = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.lblHealth);
            this.statsPanel.Controls.Add(this.label8);
            this.statsPanel.Controls.Add(this.pbHealth);
            this.statsPanel.Controls.Add(this.btnStatsClose);
            this.statsPanel.Controls.Add(this.label5);
            this.statsPanel.Controls.Add(this.label4);
            this.statsPanel.Controls.Add(this.lblConstitution);
            this.statsPanel.Controls.Add(this.label2);
            this.statsPanel.Controls.Add(this.label1);
            this.statsPanel.Controls.Add(this.txtLuck);
            this.statsPanel.Controls.Add(this.txtAgility);
            this.statsPanel.Controls.Add(this.txtConstitution);
            this.statsPanel.Controls.Add(this.txtStr);
            this.statsPanel.Controls.Add(this.txtName);
            this.statsPanel.Location = new System.Drawing.Point(13, 13);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(346, 280);
            this.statsPanel.TabIndex = 6;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(82, 109);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(22, 13);
            this.lblHealth.TabIndex = 32;
            this.lblHealth.Text = "x/y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Health:";
            // 
            // pbHealth
            // 
            this.pbHealth.Location = new System.Drawing.Point(21, 76);
            this.pbHealth.MarqueeAnimationSpeed = 1;
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.Size = new System.Drawing.Size(316, 23);
            this.pbHealth.TabIndex = 29;
            // 
            // btnStatsClose
            // 
            this.btnStatsClose.Location = new System.Drawing.Point(249, 241);
            this.btnStatsClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatsClose.Name = "btnStatsClose";
            this.btnStatsClose.Size = new System.Drawing.Size(88, 26);
            this.btnStatsClose.TabIndex = 28;
            this.btnStatsClose.Text = "&Close";
            this.btnStatsClose.UseVisualStyleBackColor = true;
            this.btnStatsClose.Click += new System.EventHandler(this.btnStatsClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Luck:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Agility:";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Location = new System.Drawing.Point(18, 181);
            this.lblConstitution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(65, 13);
            this.lblConstitution.TabIndex = 22;
            this.lblConstitution.Text = "Constitution:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Strength:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // txtLuck
            // 
            this.txtLuck.Location = new System.Drawing.Point(84, 238);
            this.txtLuck.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuck.Name = "txtLuck";
            this.txtLuck.Size = new System.Drawing.Size(42, 20);
            this.txtLuck.TabIndex = 18;
            // 
            // txtAgility
            // 
            this.txtAgility.Location = new System.Drawing.Point(84, 208);
            this.txtAgility.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgility.Name = "txtAgility";
            this.txtAgility.Size = new System.Drawing.Size(42, 20);
            this.txtAgility.TabIndex = 17;
            // 
            // txtConstitution
            // 
            this.txtConstitution.Location = new System.Drawing.Point(84, 178);
            this.txtConstitution.Margin = new System.Windows.Forms.Padding(4);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.Size = new System.Drawing.Size(42, 20);
            this.txtConstitution.TabIndex = 16;
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(84, 148);
            this.txtStr.Margin = new System.Windows.Forms.Padding(4);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(42, 20);
            this.txtStr.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 14;
            // 
            // CharacterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 303);
            this.Controls.Add(this.statsPanel);
            this.Name = "CharacterCard";
            this.Text = "CharacterCard";
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pbHealth;
        private System.Windows.Forms.Button btnStatsClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLuck;
        private System.Windows.Forms.TextBox txtAgility;
        private System.Windows.Forms.TextBox txtConstitution;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtName;
    }
}