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
    public partial class ShopForm : Form
    {
        public Game game { get; set; }

        public ShopForm(Game game)
        {
            InitializeComponent();
            this.Size = new Size(800, 870);
            this.game = game;
            pointsLabel.Text = "Points: " + game.GeneralScore.ToString();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            int design = Int32.Parse(Btn.Tag.ToString());
            if (Shop.EnoughPointsCheck(design, game.GeneralScore))
            {
                if (game.Design == design)
                    Shop.AlreadyBoughtProcess(Btn);
                else
                    Shop.EnoughPointsProcess(Btn, design, game, this.pointsLabel);
            }
            else
                Shop.NotEnoughPointsProcess(Btn);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuForm(game).Show();
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
