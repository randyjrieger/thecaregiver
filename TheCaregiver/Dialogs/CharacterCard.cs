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


            txtName.Text = player1.Name;
            txtStr.Text = player1.Attribute_Strength.ToString();
            txtCharisma.Text = player1.Attribute_Charisma.ToString();
            txtAgility.Text = player1.Attribute_Agility.ToString();
            txtIntellect.Text = player1.Attribute_Intellect.ToString();
            txtLuck.Text = player1.Attribute_Luck.ToString();
            txtInsight.Text = player1.Attribute_Insight.ToString();
        }

        private void btnStatsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
