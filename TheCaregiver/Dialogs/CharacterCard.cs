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

namespace TheCaregiver.Dialogs
{
    public partial class CharacterCard : Form
    {
        public CharacterCard(Player player1)
        {
            InitializeComponent();

            statsPanel.Visible = true;

            pbHealth.Minimum = 0;
            pbHealth.Maximum = player1.HealthMax;
            pbHealth.Value = player1.Health;
            pbHealth.Style = ProgressBarStyle.Blocks;
            pbHealth.ForeColor = Color.LightCoral;
            lblHealth.Text = player1.Health + "/" + player1.HealthMax;
            txtGender.Text = player1.GenderValue.ToString();
            txtSpecies.Text = player1.SpeciesValue.ToString();

            txtName.Text = player1.Name;
            txtStr.Text = player1.Attribute_Strength.ToString();
            txtAgility.Text = player1.Attribute_Agility.ToString();
            txtLuck.Text = player1.Attribute_Luck.ToString();
            txtConstitution.Text = player1.Attribute_Constitution.ToString();
            
        }

        private void btnStatsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
