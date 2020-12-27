namespace TheCaregiver
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.lblReality = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.ActionWindow = new System.Windows.Forms.RichTextBox();
            this.CommandArea = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Daytimer = new System.Windows.Forms.Timer(this.components);
            this.CombatTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlDevSettings = new System.Windows.Forms.Panel();
            this.chkDevSetting_HasSeed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveDevSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDevSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ActionWindow);
            this.panel1.Controls.Add(this.CommandArea);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(654, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 647);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(270, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click_1);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnCharacter);
            this.panel3.Controls.Add(this.lblReality);
            this.panel3.Controls.Add(this.btnInventory);
            this.panel3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(2, 621);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 26);
            this.panel3.TabIndex = 3;
            // 
            // btnCharacter
            // 
            this.btnCharacter.Location = new System.Drawing.Point(150, -2);
            this.btnCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.btnCharacter.Name = "btnCharacter";
            this.btnCharacter.Size = new System.Drawing.Size(46, 26);
            this.btnCharacter.TabIndex = 0;
            this.btnCharacter.TabStop = false;
            this.btnCharacter.Text = "Stats";
            this.btnCharacter.UseVisualStyleBackColor = true;
            // 
            // lblReality
            // 
            this.lblReality.AutoSize = true;
            this.lblReality.Location = new System.Drawing.Point(4, 5);
            this.lblReality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReality.Name = "lblReality";
            this.lblReality.Size = new System.Drawing.Size(31, 15);
            this.lblReality.TabIndex = 1;
            this.lblReality.Text = "label1";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(204, -1);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(42, 26);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.TabStop = false;
            this.btnInventory.Text = "Inv";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // ActionWindow
            // 
            this.ActionWindow.BackColor = System.Drawing.Color.Black;
            this.ActionWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActionWindow.Font = new System.Drawing.Font("Tw Cen MT", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionWindow.ForeColor = System.Drawing.Color.Silver;
            this.ActionWindow.Location = new System.Drawing.Point(0, 29);
            this.ActionWindow.Margin = new System.Windows.Forms.Padding(4);
            this.ActionWindow.Name = "ActionWindow";
            this.ActionWindow.ReadOnly = true;
            this.ActionWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ActionWindow.ShortcutsEnabled = false;
            this.ActionWindow.Size = new System.Drawing.Size(271, 506);
            this.ActionWindow.TabIndex = 2;
            this.ActionWindow.TabStop = false;
            this.ActionWindow.Text = "";
            // 
            // CommandArea
            // 
            this.CommandArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CommandArea.Enabled = false;
            this.CommandArea.Location = new System.Drawing.Point(1, 533);
            this.CommandArea.Margin = new System.Windows.Forms.Padding(4);
            this.CommandArea.Multiline = true;
            this.CommandArea.Name = "CommandArea";
            this.CommandArea.Size = new System.Drawing.Size(269, 92);
            this.CommandArea.TabIndex = 1;
            this.CommandArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandArea_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(34, 167);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 115);
            this.panel4.TabIndex = 0;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 300;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(0, 652);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 119);
            this.panel2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.CausesValidation = false;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(924, 111);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // Daytimer
            // 
            this.Daytimer.Interval = 1000;
            // 
            // CombatTimer
            // 
            this.CombatTimer.Interval = 300;
            this.CombatTimer.Tick += new System.EventHandler(this.CombatTimer_Tick);
            // 
            // pnlDevSettings
            // 
            this.pnlDevSettings.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlDevSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDevSettings.Controls.Add(this.chkDevSetting_HasSeed);
            this.pnlDevSettings.Controls.Add(this.label1);
            this.pnlDevSettings.Controls.Add(this.btnSaveDevSettings);
            this.pnlDevSettings.Location = new System.Drawing.Point(116, 113);
            this.pnlDevSettings.Name = "pnlDevSettings";
            this.pnlDevSettings.Size = new System.Drawing.Size(460, 186);
            this.pnlDevSettings.TabIndex = 3;
            // 
            // chkDevSetting_HasSeed
            // 
            this.chkDevSetting_HasSeed.AutoSize = true;
            this.chkDevSetting_HasSeed.Location = new System.Drawing.Point(30, 23);
            this.chkDevSetting_HasSeed.Name = "chkDevSetting_HasSeed";
            this.chkDevSetting_HasSeed.Size = new System.Drawing.Size(77, 19);
            this.chkDevSetting_HasSeed.TabIndex = 2;
            this.chkDevSetting_HasSeed.Text = "Has Seed";
            this.chkDevSetting_HasSeed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developer Settings";
            // 
            // btnSaveDevSettings
            // 
            this.btnSaveDevSettings.Location = new System.Drawing.Point(344, 144);
            this.btnSaveDevSettings.Name = "btnSaveDevSettings";
            this.btnSaveDevSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDevSettings.TabIndex = 0;
            this.btnSaveDevSettings.Text = "&Save";
            this.btnSaveDevSettings.UseVisualStyleBackColor = true;
            this.btnSaveDevSettings.Click += new System.EventHandler(this.btnSaveDevSettings_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 761);
            this.Controls.Add(this.pnlDevSettings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pirates of Nazidar/The Caregiver";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResizeEnd += new System.EventHandler(this.GameBoard_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.GameBoard_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameBoard_KeyDown);
            this.Resize += new System.EventHandler(this.GameBoard_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlDevSettings.ResumeLayout(false);
            this.pnlDevSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer Daytimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CommandArea;
        private System.Windows.Forms.RichTextBox ActionWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Label lblReality;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Timer CombatTimer;
        private System.Windows.Forms.Panel pnlDevSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveDevSettings;
        private System.Windows.Forms.CheckBox chkDevSetting_HasSeed;
    }
}

