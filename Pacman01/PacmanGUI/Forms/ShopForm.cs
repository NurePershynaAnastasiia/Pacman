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

        public bool EnoughPointsCheck (int design, int points)
        {
            if (GameFunctions.DesignInfo(design).price <= points)
                return true;
            return false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm(game);
            menuForm.Show();
        }

        public void NotEnoughPointsAction(Button Btn)
        {
            Btn.Enabled = false;
            Btn.Font = new Font("Lucida Console", 12);
            Btn.Text = "Not enough points";
            Btn.BackColor = Color.IndianRed;
        }

        public void EnoughPointsAction(Button Btn, int design)
        {
            Btn.Enabled = false;
            Btn.Text = "Bought";
            Btn.BackColor = Color.DarkSlateBlue;
            game.Design = design;
            game.GeneralScore -= GameFunctions.DesignInfo(design).price;
            pointsLabel.Text = "Points: " + game.GeneralScore.ToString();
        }

        public void AlreadyBoughtAction(Button Btn)
        {
            Btn.Enabled = false;
            Btn.Font = new Font("Lucida Console", 14);
            Btn.Text = "Already Bought";
            Btn.BackColor = Color.DarkSlateBlue;
        }

        private void Buy1Btn_Click(object sender, EventArgs e)
        {
            if (EnoughPointsCheck(1, game.GeneralScore))
            {
                if (game.Design == 1)
                    AlreadyBoughtAction(Buy1Btn);
                else
                    EnoughPointsAction(Buy1Btn, 1);
            }
            else
                NotEnoughPointsAction(Buy1Btn);
        }

        private void Buy2Btn_Click(object sender, EventArgs e)
        {
            if (EnoughPointsCheck(2, game.GeneralScore))
            {
                if (game.Design == 2)
                    AlreadyBoughtAction(Buy2Btn);
                else
                    EnoughPointsAction(Buy2Btn, 2);
            }
            else
                NotEnoughPointsAction(Buy2Btn);
        }

        private void Buy3Btn_Click(object sender, EventArgs e)
        {
            if (EnoughPointsCheck(3, game.GeneralScore))
            {
                if (game.Design == 3)
                    AlreadyBoughtAction(Buy3Btn);
                else
                    EnoughPointsAction(Buy3Btn, 3);
            }
            else
                NotEnoughPointsAction(Buy3Btn);
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
