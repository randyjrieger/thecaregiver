namespace TheCaregiver.Dialogs
{
    partial class Inventory
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
            this.inventoryPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.inventoryPanel.Location = new System.Drawing.Point(13, 13);
            this.inventoryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(357, 341);
            this.inventoryPanel.TabIndex = 5;
            // 
            // lblFoodCnt
            // 
            this.lblFoodCnt.AutoSize = true;
            this.lblFoodCnt.Location = new System.Drawing.Point(99, 51);
            this.lblFoodCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodCnt.Name = "lblFoodCnt";
            this.lblFoodCnt.Size = new System.Drawing.Size(13, 13);
            this.lblFoodCnt.TabIndex = 8;
            this.lblFoodCnt.Text = "0";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(46, 51);
            this.lblFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(34, 13);
            this.lblFood.TabIndex = 7;
            this.lblFood.Text = "Food:";
            // 
            // lblCoinCnt
            // 
            this.lblCoinCnt.AutoSize = true;
            this.lblCoinCnt.Location = new System.Drawing.Point(99, 36);
            this.lblCoinCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoinCnt.Name = "lblCoinCnt";
            this.lblCoinCnt.Size = new System.Drawing.Size(13, 13);
            this.lblCoinCnt.TabIndex = 6;
            this.lblCoinCnt.Text = "0";
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Location = new System.Drawing.Point(46, 36);
            this.lblCoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(31, 13);
            this.lblCoin.TabIndex = 5;
            this.lblCoin.Text = "Coin:";
            // 
            // lblFishCnt
            // 
            this.lblFishCnt.AutoSize = true;
            this.lblFishCnt.Location = new System.Drawing.Point(99, 91);
            this.lblFishCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFishCnt.Name = "lblFishCnt";
            this.lblFishCnt.Size = new System.Drawing.Size(13, 13);
            this.lblFishCnt.TabIndex = 4;
            this.lblFishCnt.Text = "0";
            // 
            // lblFish
            // 
            this.lblFish.AutoSize = true;
            this.lblFish.Location = new System.Drawing.Point(46, 91);
            this.lblFish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFish.Name = "lblFish";
            this.lblFish.Size = new System.Drawing.Size(29, 13);
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
            this.btnInvClose.Text = "&Close";
            this.btnInvClose.UseVisualStyleBackColor = true;
            this.btnInvClose.Click += new System.EventHandler(this.btnInvClose_Click);
            // 
            // lblWoodCnt
            // 
            this.lblWoodCnt.AutoSize = true;
            this.lblWoodCnt.Location = new System.Drawing.Point(99, 76);
            this.lblWoodCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWoodCnt.Name = "lblWoodCnt";
            this.lblWoodCnt.Size = new System.Drawing.Size(13, 13);
            this.lblWoodCnt.TabIndex = 1;
            this.lblWoodCnt.Text = "0";
            // 
            // lblWood
            // 
            this.lblWood.AutoSize = true;
            this.lblWood.Location = new System.Drawing.Point(46, 76);
            this.lblWood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(39, 13);
            this.lblWood.TabIndex = 0;
            this.lblWood.Text = "Wood:";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 365);
            this.Controls.Add(this.inventoryPanel);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.inventoryPanel.ResumeLayout(false);
            this.inventoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inventoryPanel;
        private System.Windows.Forms.Label lblFoodCnt;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblCoinCnt;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label lblFishCnt;
        private System.Windows.Forms.Label lblFish;
        private System.Windows.Forms.Button btnInvClose;
        private System.Windows.Forms.Label lblWoodCnt;
        private System.Windows.Forms.Label lblWood;
    }
}