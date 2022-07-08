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
            new MenuForm(game).Show();
        }

        private void LvlBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Button Btn = (Button)sender;
            int lvl = Int32.Parse(Btn.Tag.ToString());
            new GameForm(game, lvl).Show();
        }

        private void LvlBtn_MouseHover(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            int lvl = Int32.Parse(Btn.Tag.ToString());

            Dictionary <int, Bitmap> backgroundInfo = new Dictionary<int, Bitmap>();
            backgroundInfo.Add(1, Resources.Lvl1Background);
            backgroundInfo.Add(2, Resources.Lvl2Background);
            backgroundInfo.Add(3, Resources.Lvl3Background);
            this.pictureBox2.Image = backgroundInfo[lvl];
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
