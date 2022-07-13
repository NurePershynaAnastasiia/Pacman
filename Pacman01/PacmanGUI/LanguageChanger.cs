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
            if (lang == "eng")
            {
                menuForm.EngBtn.Enabled = false;
                menuForm.EngBtn.BackColor = Color.Firebrick;
                menuForm.UkrBtn.BackColor = Color.Tomato;
                menuForm.UkrBtn.Enabled = true;
            }
            if (lang == "ukr")
            {
                menuForm.UkrBtn.Enabled = false;
                menuForm.UkrBtn.BackColor = Color.Firebrick;
                menuForm.EngBtn.BackColor = Color.Tomato;
                menuForm.EngBtn.Enabled = true;
            }
            foreach (Control control in menuForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.MenuFormLang(control.Name, lang);
            }
        }

        public static void ChooseLevel(ChooseLevelForm chooseLevelForm, string lang)
        {
            if (lang == "eng")
                chooseLevelForm.titlePictureBox.BackgroundImage = Resources.textChooseLevelEng;
            if (lang == "ukr")
                chooseLevelForm.titlePictureBox.BackgroundImage = Resources.textChooseLevelUkr;
            foreach (Control control in chooseLevelForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.ChooseLevelFormLang(control.Name, lang);
            }
        }
        public static void Instructions(InstructionsForm instructionsForm, string lang)
        {
            if (lang == "eng")
                instructionsForm.titlePictureBox.BackgroundImage = Resources.textInstructionsEng;
            if (lang == "ukr")
                instructionsForm.titlePictureBox.BackgroundImage = Resources.textInstructionsUkr;
            foreach (Control control in instructionsForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.InstructionsFormLang(control.Name, lang);
            }
        }

        public static void Shop(ShopForm shopForm, string lang)
        {
            if (lang == "eng")
                shopForm.titlePictureBox.BackgroundImage = Resources.textShopEng;
            if (lang == "ukr")
                shopForm.titlePictureBox.BackgroundImage = Resources.textShopUkr;
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
            if (lang == "eng")
                gameOverForm.titlePictureBox.BackgroundImage = Resources.textGameOverEng;
            if (lang == "ukr")
                gameOverForm.titlePictureBox.BackgroundImage = Resources.textGameOverUkr;
            foreach (Control control in gameOverForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.GameOverFormLang(control.Name, lang);
            }
        }

        public static void Victory(VictoryForm victoryForm, string lang)
        {
            if (lang == "eng")
                victoryForm.titlePictureBox.BackgroundImage = Resources.textVictoryEng;
            if (lang == "ukr")
                victoryForm.titlePictureBox.BackgroundImage = Resources.textVictoryUkr;
            foreach (Control control in victoryForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.VictoryFormLang(control.Name, lang);
            }
        }

        public static void LevelEditor(LevelEditorForm levelEditorForm, string lang)
        {
            foreach (Control control in levelEditorForm.Controls)
            {
                if (control is Button || control is Label)
                    control.Text = MultilingualInterface.LevelEditorFormLang(control.Name, lang);
            }
        }
    }
}
