using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGUI
{
    public static class LanguageChanger
    {
        public static void Menu(MenuForm menuForm, string lang)
        {
            foreach (Control control in menuForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.MenuFormLang(control.Name, lang);

            }
        }

        public static void ChooseLevel(ChooseLevelForm chooseLevelForm, string lang)
        {
            foreach (Control control in chooseLevelForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.ChooseLevelFormLang(control.Name, lang);
                    
            }
        }
        public static void Instructions(InstructionsForm instructionsForm, string lang)
        {
            foreach (Control control in instructionsForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.InstructionsFormLang(control.Name, lang);

            }
        }

        public static void Shop(ShopForm shopForm, string lang)
        {
            foreach (Control control in shopForm.Controls)
            {
                if ((control is Button || control is Label) && control.Name != "PointsNumberLabel")
                    control.Text = MultilingualInterface.ShopFormLang(control.Name, lang);

            }
        }

        public static void Game(GameForm gameForm, string lang)
        {
            foreach (Control control in gameForm.Controls)
            {
                if ((control is Button || control is Label) && control.Name != "scoreNumberLabel" && control.Name != "generalScoreNumberLabel")
                    control.Text = MultilingualInterface.GameFormLang(control.Name, lang);

            }
        }

        public static void GameOver(GameOverForm gameOverForm, string lang)
        {
            foreach (Control control in gameOverForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.GameOverFormLang(control.Name, lang);

            }
        }

        public static void Victory(VictoryForm victoryForm, string lang)
        {
            foreach (Control control in victoryForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.VictoryFormLang(control.Name, lang);

            }
        }
    }
}
