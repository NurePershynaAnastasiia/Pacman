using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace PacmanGUI
{
    public partial class VictoryForm : Form
    {
        public Game game { get; set; }

        public VictoryForm(Game game)
        {
            InitializeComponent();
            this.Size = new Size(800, 870);
            generalScoreLabel.Text = "General Score: " + game.GeneralScore.ToString();
            this.game = game;
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm(game);
            menuForm.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VictoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
