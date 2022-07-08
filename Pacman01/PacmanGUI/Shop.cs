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

        public static void NotEnoughPointsProcess(Button Btn, string lang)
        {
            Btn.Enabled = false;
            Btn.Font = new Font("Lucida Console", 12);
            if (lang == "eng")
                Btn.Text = "Not enough points";
            if (lang == "ukr")
                Btn.Text = "Недостатньо монет";
            Btn.BackColor = Color.IndianRed;
        }

        public static void EnoughPointsProcess(Button Btn, int design, Game game, Label pointsLabel, string lang)
        {
            Btn.Enabled = false;
            if (lang == "eng")
                Btn.Text = "Bought";
            if (lang == "ukr")
                Btn.Text = "Куплено";
            Btn.BackColor = Color.DarkSlateBlue;
            game.Design = design;
            game.GeneralScore -= GameFunctions.DesignInfo(design).price;
            pointsLabel.Text = game.GeneralScore.ToString();
        }

        public static void AlreadyBoughtProcess(Button Btn, string lang)
        {
            Btn.Enabled = false;
            Btn.Font = new Font("Lucida Console", 14);
            if (lang == "eng")
                Btn.Text = "Already Bought";
            if (lang == "ukr")
                Btn.Text = "Вже Куплено";
            
            Btn.BackColor = Color.DarkSlateBlue;
        }

    }
}
