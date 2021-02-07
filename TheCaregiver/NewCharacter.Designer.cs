namespace TheCaregiver
{
    partial class NewCharacter
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpAbilities = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtAgi = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtluc = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lblPointsLeft = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.grpSpecies = new System.Windows.Forms.GroupBox();
            this.rbHuman = new System.Windows.Forms.RadioButton();
            this.rbBlueElf = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValidateError = new System.Windows.Forms.Label();
            this.grpAbilities.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpSpecies.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // grpAbilities
            // 
            this.grpAbilities.Controls.Add(this.textBox6);
            this.grpAbilities.Controls.Add(this.label8);
            this.grpAbilities.Controls.Add(this.lblPointsLeft);
            this.grpAbilities.Controls.Add(this.button5);
            this.grpAbilities.Controls.Add(this.button6);
            this.grpAbilities.Controls.Add(this.button7);
            this.grpAbilities.Controls.Add(this.button8);
            this.grpAbilities.Controls.Add(this.button4);
            this.grpAbilities.Controls.Add(this.button3);
            this.grpAbilities.Controls.Add(this.button2);
            this.grpAbilities.Controls.Add(this.button1);
            this.grpAbilities.Controls.Add(this.txtluc);
            this.grpAbilities.Controls.Add(this.txtCon);
            this.grpAbilities.Controls.Add(this.txtAgi);
            this.grpAbilities.Controls.Add(this.txtStr);
            this.grpAbilities.Controls.Add(this.label6);
            this.grpAbilities.Controls.Add(this.label5);
            this.grpAbilities.Controls.Add(this.label4);
            this.grpAbilities.Controls.Add(this.label3);
            this.grpAbilities.Location = new System.Drawing.Point(32, 178);
            this.grpAbilities.Name = "grpAbilities";
            this.grpAbilities.Size = new System.Drawing.Size(392, 179);
            this.grpAbilities.TabIndex = 8;
            this.grpAbilities.TabStop = false;
            this.grpAbilities.Text = "Characteristics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Strength:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Agility:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Luck:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Constitution:";
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(104, 30);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(50, 20);
            this.txtStr.TabIndex = 7;
            // 
            // txtAgi
            // 
            this.txtAgi.Location = new System.Drawing.Point(104, 55);
            this.txtAgi.Name = "txtAgi";
            this.txtAgi.Size = new System.Drawing.Size(50, 20);
            this.txtAgi.TabIndex = 8;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(104, 79);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(50, 20);
            this.txtCon.TabIndex = 9;
            // 
            // txtluc
            // 
            this.txtluc.Location = new System.Drawing.Point(104, 105);
            this.txtluc.Name = "txtluc";
            this.txtluc.Size = new System.Drawing.Size(50, 20);
            this.txtluc.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Image = global::TheCaregiver.Properties.Resources.down;
            this.button5.Location = new System.Drawing.Point(202, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = global::TheCaregiver.Properties.Resources.down;
            this.button6.Location = new System.Drawing.Point(202, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 17;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Image = global::TheCaregiver.Properties.Resources.down;
            this.button7.Location = new System.Drawing.Point(202, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 23);
            this.button7.TabIndex = 16;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblPointsLeft
            // 
            this.lblPointsLeft.AutoSize = true;
            this.lblPointsLeft.Location = new System.Drawing.Point(20, 138);
            this.lblPointsLeft.Name = "lblPointsLeft";
            this.lblPointsLeft.Size = new System.Drawing.Size(359, 13);
            this.lblPointsLeft.TabIndex = 19;
            this.lblPointsLeft.Text = "You have x more points you can add to your characteristics, for a total of x.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(235, 30);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 95);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Higher strength means using heavier weapons and hitting harder, causing more dama" +
    "ge.";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(317, 363);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Start Journey";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbOther);
            this.grpGender.Controls.Add(this.rbFemale);
            this.grpGender.Controls.Add(this.rbMale);
            this.grpGender.Location = new System.Drawing.Point(32, 48);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(392, 61);
            this.grpGender.TabIndex = 11;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(178, 30);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(51, 17);
            this.rbOther.TabIndex = 13;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(95, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(10, 30);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // grpSpecies
            // 
            this.grpSpecies.Controls.Add(this.rbHuman);
            this.grpSpecies.Controls.Add(this.rbBlueElf);
            this.grpSpecies.Location = new System.Drawing.Point(32, 115);
            this.grpSpecies.Name = "grpSpecies";
            this.grpSpecies.Size = new System.Drawing.Size(392, 57);
            this.grpSpecies.TabIndex = 14;
            this.grpSpecies.TabStop = false;
            this.grpSpecies.Text = "Species";
            // 
            // rbHuman
            // 
            this.rbHuman.AutoSize = true;
            this.rbHuman.Location = new System.Drawing.Point(95, 19);
            this.rbHuman.Name = "rbHuman";
            this.rbHuman.Size = new System.Drawing.Size(59, 17);
            this.rbHuman.TabIndex = 15;
            this.rbHuman.TabStop = true;
            this.rbHuman.Text = "Human";
            this.rbHuman.UseVisualStyleBackColor = true;
            // 
            // rbBlueElf
            // 
            this.rbBlueElf.AutoSize = true;
            this.rbBlueElf.Location = new System.Drawing.Point(10, 19);
            this.rbBlueElf.Name = "rbBlueElf";
            this.rbBlueElf.Size = new System.Drawing.Size(61, 17);
            this.rbBlueElf.TabIndex = 14;
            this.rbBlueElf.TabStop = true;
            this.rbBlueElf.Text = "Blue Elf";
            this.rbBlueElf.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::TheCaregiver.Properties.Resources.down;
            this.button8.Location = new System.Drawing.Point(202, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 23);
            this.button8.TabIndex = 15;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Image = global::TheCaregiver.Properties.Resources.up;
            this.button4.Location = new System.Drawing.Point(169, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 23);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::TheCaregiver.Properties.Resources.up;
            this.button3.Location = new System.Drawing.Point(169, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::TheCaregiver.Properties.Resources.up;
            this.button2.Location = new System.Drawing.Point(169, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::TheCaregiver.Properties.Resources.up;
            this.button1.Location = new System.Drawing.Point(169, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValidateError
            // 
            this.lblValidateError.AutoSize = true;
            this.lblValidateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidateError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblValidateError.Location = new System.Drawing.Point(29, 368);
            this.lblValidateError.Name = "lblValidateError";
            this.lblValidateError.Size = new System.Drawing.Size(94, 13);
            this.lblValidateError.TabIndex = 21;
            this.lblValidateError.Text = "Validation Error";
            this.lblValidateError.Visible = false;
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 397);
            this.Controls.Add(this.lblValidateError);
            this.Controls.Add(this.grpSpecies);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.grpAbilities);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "NewCharacter";
            this.Text = "Who Are You?";
            this.Load += new System.EventHandler(this.NewCharacter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewCharacter_KeyDown);
            this.grpAbilities.ResumeLayout(false);
            this.grpAbilities.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpSpecies.ResumeLayout(false);
            this.grpSpecies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpAbilities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPointsLeft;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtluc;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtAgi;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox grpSpecies;
        private System.Windows.Forms.RadioButton rbHuman;
        private System.Windows.Forms.RadioButton rbBlueElf;
        private System.Windows.Forms.Label lblValidateError;
    }
}