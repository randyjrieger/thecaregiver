using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCaregiver.Player1;

namespace TheCaregiver
{
    public partial class NewCharacter : Form
    {
        public int TotalPoints { get; set; }
        public int MaxPoints { get; set; }
        public NewCharacter()
        {
            InitializeComponent();
        }

        private void NewCharacter_Load(object sender, EventArgs e)
        {
            MaxPoints = 23;

            txtStr.Text = "5";
            txtAgi.Text = "5";
            txtCon.Text = "5";
            txtluc.Text = "5";

            TotalPoints = 20;
            UpdatePointsLeft();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            var passValidation = true;
            lblValidateError.Visible = false;

            txtName.ForeColor = SystemColors.ControlText;
            grpSpecies.ForeColor = SystemColors.ControlText;
            grpGender.ForeColor = SystemColors.ControlText;
            grpAbilities.ForeColor = SystemColors.ControlText;

            if (!(this.rbMale.Checked || this.rbFemale.Checked || this.rbOther.Checked))
            {
                passValidation = false;
                grpGender.ForeColor = Color.OrangeRed;
                lblValidateError.Text = "I think you forgot something.";
                lblValidateError.Visible = true;
            }

            if (!(this.rbBlueElf.Checked || this.rbHuman.Checked))
            {
                passValidation = false;
                grpSpecies.ForeColor = Color.OrangeRed;
                lblValidateError.Text = "I think you forgot something.";
                lblValidateError.Visible = true;
            }

            if (String.IsNullOrEmpty(txtName.Text))
            {
                passValidation = false;
                lblName.ForeColor = Color.OrangeRed;
                lblValidateError.Text = "I think you forgot something.";
                lblValidateError.Visible = true;
            }

            if (TotalPoints != MaxPoints)
            {
                passValidation = false;
                grpAbilities.ForeColor = Color.OrangeRed;
                lblValidateError.Text = "You Have More Ability Points To Use.";
                lblValidateError.Visible = true;
            }


            if (passValidation)
            {
                lblValidateError.Visible = false;

                if (txtName.Text.Trim() == "")
                {
                    return;
                }

                Player p = new Player
                {
                    Name = txtName.Text,
                    Attribute_Strength = Convert.ToInt16(txtStr.Text),
                    Attribute_Agility = Convert.ToInt16(txtAgi.Text),
                    Attribute_Constitution = Convert.ToInt16(txtCon.Text),
                    Attribute_Luck = Convert.ToInt16(txtluc.Text)
                };

                if (rbMale.Checked)
                {
                    p.GenderValue = Player.Gender.Male;
                }
                else if (rbFemale.Checked)
                {
                    p.GenderValue = Player.Gender.Female;
                }
                else
                {
                    p.GenderValue = Player.Gender.Other;
                }

                if (rbBlueElf.Checked)
                {
                    p.SpeciesValue = Player.Species.BlueElf;
                }
                else
                {
                    p.SpeciesValue = Player.Species.Human;
                }

                GameBoard m = new GameBoard(GameMode.New, txtName.Text);
                m.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CalcPoints() < 23)
            {
                var ability = Convert.ToInt16(txtStr.Text);
                txtStr.Text = (++ability).ToString();
                TotalPoints++;
                UpdatePointsLeft();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CalcPoints() < 23)
            {
                var ability = Convert.ToInt16(txtAgi.Text);
                txtAgi.Text = (++ability).ToString();
                TotalPoints++;
                UpdatePointsLeft();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CalcPoints() < 23)
            {
                var ability = Convert.ToInt16(txtCon.Text);
                txtCon.Text = (++ability).ToString();
                TotalPoints++;
                UpdatePointsLeft();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CalcPoints() < 23)
            {
                var ability = Convert.ToInt16(txtluc.Text);
                txtluc.Text = (++ability).ToString();
                TotalPoints++;
                UpdatePointsLeft();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var ability = Convert.ToInt16(txtStr.Text);
            if (ability - 1 >= 5)
            {
                txtStr.Text = (--ability).ToString();
                TotalPoints--;
                UpdatePointsLeft();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ability = Convert.ToInt16(txtAgi.Text);
            if (ability - 1 >= 5)
            {
                txtAgi.Text = (--ability).ToString();
                TotalPoints--;
                UpdatePointsLeft();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var ability = Convert.ToInt16(txtCon.Text);
            if (ability - 1 >= 5)
            {
                txtCon.Text = (--ability).ToString();
                TotalPoints--;
                UpdatePointsLeft();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var ability = Convert.ToInt16(txtluc.Text);
            if (ability - 1 >= 5)
            {
                txtluc.Text = (--ability).ToString();
                TotalPoints--;
                UpdatePointsLeft();
            }
        }

        private void UpdatePointsLeft()
        {
            if (TotalPoints == 23)
            {
                lblPointsLeft.Text = "You have used all available points for your characteristics.";
            }
            else
            {
                lblPointsLeft.Text = "You have " + (MaxPoints - TotalPoints) + " more points you can add to your characteristics.";
            }
        }

        private int CalcPoints()
        {
            return Convert.ToInt16(txtStr.Text) + Convert.ToInt16(txtAgi.Text) + Convert.ToInt16(txtCon.Text) + Convert.ToInt16(txtluc.Text);
        }
    }
}
