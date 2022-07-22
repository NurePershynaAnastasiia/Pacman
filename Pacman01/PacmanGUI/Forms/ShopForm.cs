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
            this.Size = new Size(800, 870);
            this.game = game;
            InitializeComponent();
            PointsNumberLabel.Text = game.GeneralScore.ToString();
            LanguageChanger.Translate(this, game.Language);
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            int design = Int32.Parse(Btn.Tag.ToString());
            if (Shop.EnoughPointsCheck(design, game.GeneralScore))
            {
                if (game.Design == design)
                    Shop.AlreadyBoughtProcess(Btn, game.Language);
                else
                    Shop.EnoughPointsProcess(Btn, design, game, this.PointsNumberLabel, game.Language);
            }
            else
                Shop.NotEnoughPointsProcess(Btn, game.Language);
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
