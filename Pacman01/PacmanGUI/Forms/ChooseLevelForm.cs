using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase.Utilities;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace PacmanGUI
{
    public partial class ChooseLevelForm : Form
    {
        public Game game { get; set; }
        public ChooseLevelForm(Game game)
        {
            InitializeComponent();
            this.Size = new Size(800, 870);
            this.game = game;
        }
        public void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm(game);
            menuForm.Show();
        }

        private void Lvl1Btn_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.Lvl1Background;
        }
        private void Lvl1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(game, 1);
            gameForm.Show();
        }
        private void Lvl2Btn_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.Lvl2Background;
        }
        private void Lvl2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(game, 2);
            gameForm.Show();
        }
        private void Lvl3Btn_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.Lvl3Background;
        }
        private void Lvl3Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(game, 3);
            gameForm.Show();
        }
        private void LvlBtn_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = null;
        }

        private void ChooseLevelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
