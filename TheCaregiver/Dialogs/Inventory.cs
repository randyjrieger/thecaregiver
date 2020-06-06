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
    public partial class Inventory : Form
    {
        public Inventory(Player player1)
        {
            InitializeComponent();

            lblCoinCnt.Text = player1.coin.ToString();
            lblFoodCnt.Text = player1.food.ToString();
            lblWoodCnt.Text = player1.wood.ToString();
            lblFishCnt.Text = player1.fish.ToString();
        }

        private void btnInvClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
