using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.GameProcess;

namespace PacmanGUI
{
    public static class Shop
    {
        public static bool EnoughPointsCheck(int design, int points)
        {
            if (GameFunctions.DesignInfo(design).price <= points)
                return true;
            return false;
        }

        public static void NotEnoughPointsProcess(Button Btn)
        {
            Btn.Enabled = false;
            Btn.Font = new Font("Lucida Console", 12);
            Btn.Text = "Not enough points";
            Btn.BackColor = Color.IndianRed;
        }

        public static void EnoughPointsProcess(Button Btn, int design, Game game, Label pointsLabel)
        {
            Btn.Enabled = false;
            Btn.Text = "Bought";
            Btn.BackColor = Color.DarkSlateBlue;
            game.Design = design;
            game.GeneralScore -= GameFunctions.DesignInfo(design).price;
            pointsLabel.Text = "Points: " + game.GeneralScore.ToString();
        }

        public static void AlreadyBoughtProcess(Button Btn)
        {
            Btn.Enabled = false;
            Btn.Font = new Font("Lucida Console", 14);
            Btn.Text = "Already Bought";
            Btn.BackColor = Color.DarkSlateBlue;
        }

    }
}
