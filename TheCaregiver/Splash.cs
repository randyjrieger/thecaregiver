using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCaregiver
{
    public enum GameMode
    {
        None = 0,
        New = 1,
        Load = 2
    }

    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        { 

            NewCharacter m = new NewCharacter();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox m = new AboutBox();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameBoard m = new GameBoard(GameMode.Load, null);
            m.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
