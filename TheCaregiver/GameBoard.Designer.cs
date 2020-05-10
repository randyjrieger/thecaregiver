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
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.lblFoodCnt = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblCoinCnt = new System.Windows.Forms.Label();
            this.lblCoin = new System.Windows.Forms.Label();
            this.lblFishCnt = new System.Windows.Forms.Label();
            this.lblFish = new System.Windows.Forms.Label();
            this.btnInvClose = new System.Windows.Forms.Button();
            this.lblWoodCnt = new System.Windows.Forms.Label();
            this.lblWood = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbHealth = new System.Windows.Forms.ProgressBar();
            this.btnStatsClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntellect = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsight = new System.Windows.Forms.TextBox();
            this.txtLuck = new System.Windows.Forms.TextBox();
            this.txtAgility = new System.Windows.Forms.TextBox();
            this.txtCharisma = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CombatTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.inventoryPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
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
            this.btnCharacter.Click += new System.EventHandler(this.btnCharacter_Click);
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
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
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
            this.ActionWindow.Size = new System.Drawing.Size(273, 506);
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
            // inventoryPanel
            // 
            this.inventoryPanel.BackColor = System.Drawing.Color.Silver;
            this.inventoryPanel.Controls.Add(this.lblFoodCnt);
            this.inventoryPanel.Controls.Add(this.lblFood);
            this.inventoryPanel.Controls.Add(this.lblCoinCnt);
            this.inventoryPanel.Controls.Add(this.lblCoin);
            this.inventoryPanel.Controls.Add(this.lblFishCnt);
            this.inventoryPanel.Controls.Add(this.lblFish);
            this.inventoryPanel.Controls.Add(this.btnInvClose);
            this.inventoryPanel.Controls.Add(this.lblWoodCnt);
            this.inventoryPanel.Controls.Add(this.lblWood);
            this.inventoryPanel.Location = new System.Drawing.Point(134, 92);
            this.inventoryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(357, 341);
            this.inventoryPanel.TabIndex = 4;
            // 
            // lblFoodCnt
            // 
            this.lblFoodCnt.AutoSize = true;
            this.lblFoodCnt.Location = new System.Drawing.Point(99, 51);
            this.lblFoodCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodCnt.Name = "lblFoodCnt";
            this.lblFoodCnt.Size = new System.Drawing.Size(14, 15);
            this.lblFoodCnt.TabIndex = 8;
            this.lblFoodCnt.Text = "0";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(46, 51);
            this.lblFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(37, 15);
            this.lblFood.TabIndex = 7;
            this.lblFood.Text = "Food:";
            // 
            // lblCoinCnt
            // 
            this.lblCoinCnt.AutoSize = true;
            this.lblCoinCnt.Location = new System.Drawing.Point(99, 36);
            this.lblCoinCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoinCnt.Name = "lblCoinCnt";
            this.lblCoinCnt.Size = new System.Drawing.Size(14, 15);
            this.lblCoinCnt.TabIndex = 6;
            this.lblCoinCnt.Text = "0";
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Location = new System.Drawing.Point(46, 36);
            this.lblCoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(34, 15);
            this.lblCoin.TabIndex = 5;
            this.lblCoin.Text = "Coin:";
            // 
            // lblFishCnt
            // 
            this.lblFishCnt.AutoSize = true;
            this.lblFishCnt.Location = new System.Drawing.Point(99, 91);
            this.lblFishCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFishCnt.Name = "lblFishCnt";
            this.lblFishCnt.Size = new System.Drawing.Size(14, 15);
            this.lblFishCnt.TabIndex = 4;
            this.lblFishCnt.Text = "0";
            // 
            // lblFish
            // 
            this.lblFish.AutoSize = true;
            this.lblFish.Location = new System.Drawing.Point(46, 91);
            this.lblFish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFish.Name = "lblFish";
            this.lblFish.Size = new System.Drawing.Size(29, 15);
            this.lblFish.TabIndex = 3;
            this.lblFish.Text = "Fish:";
            // 
            // btnInvClose
            // 
            this.btnInvClose.Location = new System.Drawing.Point(216, 301);
            this.btnInvClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvClose.Name = "btnInvClose";
            this.btnInvClose.Size = new System.Drawing.Size(88, 26);
            this.btnInvClose.TabIndex = 2;
            this.btnInvClose.Text = "button2";
            this.btnInvClose.UseVisualStyleBackColor = true;
            this.btnInvClose.Click += new System.EventHandler(this.btnInvClose_Click);
            // 
            // lblWoodCnt
            // 
            this.lblWoodCnt.AutoSize = true;
            this.lblWoodCnt.Location = new System.Drawing.Point(99, 76);
            this.lblWoodCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWoodCnt.Name = "lblWoodCnt";
            this.lblWoodCnt.Size = new System.Drawing.Size(14, 15);
            this.lblWoodCnt.TabIndex = 1;
            this.lblWoodCnt.Text = "0";
            // 
            // lblWood
            // 
            this.lblWood.AutoSize = true;
            this.lblWood.Location = new System.Drawing.Point(46, 76);
            this.lblWood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(44, 15);
            this.lblWood.TabIndex = 0;
            this.lblWood.Text = "Wood:";
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.lblHealth);
            this.statsPanel.Controls.Add(this.label8);
            this.statsPanel.Controls.Add(this.pbHealth);
            this.statsPanel.Controls.Add(this.btnStatsClose);
            this.statsPanel.Controls.Add(this.label7);
            this.statsPanel.Controls.Add(this.txtIntellect);
            this.statsPanel.Controls.Add(this.label6);
            this.statsPanel.Controls.Add(this.label5);
            this.statsPanel.Controls.Add(this.label4);
            this.statsPanel.Controls.Add(this.label3);
            this.statsPanel.Controls.Add(this.label2);
            this.statsPanel.Controls.Add(this.label1);
            this.statsPanel.Controls.Add(this.txtInsight);
            this.statsPanel.Controls.Add(this.txtLuck);
            this.statsPanel.Controls.Add(this.txtAgility);
            this.statsPanel.Controls.Add(this.txtCharisma);
            this.statsPanel.Controls.Add(this.txtStr);
            this.statsPanel.Controls.Add(this.txtName);
            this.statsPanel.Location = new System.Drawing.Point(134, 92);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(357, 338);
            this.statsPanel.TabIndex = 5;
            this.statsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statsPanel_Paint);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(82, 109);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(28, 15);
            this.lblHealth.TabIndex = 32;
            this.lblHealth.Text = "x/y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
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
            this.btnStatsClose.Location = new System.Drawing.Point(249, 268);
            this.btnStatsClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatsClose.Name = "btnStatsClose";
            this.btnStatsClose.Size = new System.Drawing.Size(88, 26);
            this.btnStatsClose.TabIndex = 28;
            this.btnStatsClose.Text = "button1";
            this.btnStatsClose.UseVisualStyleBackColor = true;
            this.btnStatsClose.Click += new System.EventHandler(this.btnStatsClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 301);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Intellect:";
            // 
            // txtIntellect
            // 
            this.txtIntellect.Location = new System.Drawing.Point(84, 298);
            this.txtIntellect.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntellect.Name = "txtIntellect";
            this.txtIntellect.Size = new System.Drawing.Size(42, 21);
            this.txtIntellect.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Insight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Luck:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Agility:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Charisma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Strength:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // txtInsight
            // 
            this.txtInsight.Location = new System.Drawing.Point(84, 268);
            this.txtInsight.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsight.Name = "txtInsight";
            this.txtInsight.Size = new System.Drawing.Size(42, 21);
            this.txtInsight.TabIndex = 19;
            // 
            // txtLuck
            // 
            this.txtLuck.Location = new System.Drawing.Point(84, 238);
            this.txtLuck.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuck.Name = "txtLuck";
            this.txtLuck.Size = new System.Drawing.Size(42, 21);
            this.txtLuck.TabIndex = 18;
            // 
            // txtAgility
            // 
            this.txtAgility.Location = new System.Drawing.Point(84, 208);
            this.txtAgility.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgility.Name = "txtAgility";
            this.txtAgility.Size = new System.Drawing.Size(42, 21);
            this.txtAgility.TabIndex = 17;
            // 
            // txtCharisma
            // 
            this.txtCharisma.Location = new System.Drawing.Point(84, 178);
            this.txtCharisma.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharisma.Name = "txtCharisma";
            this.txtCharisma.Size = new System.Drawing.Size(42, 21);
            this.txtCharisma.TabIndex = 16;
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(84, 148);
            this.txtStr.Margin = new System.Windows.Forms.Padding(4);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(42, 21);
            this.txtStr.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(116, 21);
            this.txtName.TabIndex = 14;
            // 
            // CombatTimer
            // 
            this.CombatTimer.Interval = 300;
            this.CombatTimer.Tick += new System.EventHandler(this.CombatTimer_Tick);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.inventoryPanel);
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
            this.SizeChanged += new System.EventHandler(this.GameBoard_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameBoard_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.inventoryPanel.ResumeLayout(false);
            this.inventoryPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer Daytimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel inventoryPanel;
        private System.Windows.Forms.Label lblWoodCnt;
        private System.Windows.Forms.Label lblWood;
        private System.Windows.Forms.Button btnInvClose;
        private System.Windows.Forms.Label lblFishCnt;
        private System.Windows.Forms.Label lblFish;
        private System.Windows.Forms.Label lblCoinCnt;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label lblFoodCnt;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIntellect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsight;
        private System.Windows.Forms.TextBox txtLuck;
        private System.Windows.Forms.TextBox txtAgility;
        private System.Windows.Forms.TextBox txtCharisma;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnStatsClose;
        private System.Windows.Forms.TextBox CommandArea;
        private System.Windows.Forms.RichTextBox ActionWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Label lblReality;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.ProgressBar pbHealth;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label8;
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
    }
}

