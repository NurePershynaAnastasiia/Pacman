using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGUI
{
    public static class LanguageChanger
    {
        public static void Translate(Form form, string lang)
        {
            foreach (Control control in form.Controls)
            {
                if ((control is Button || control is Label) && MultilingualInterface.DefineTranslation.ContainsKey(control.Name))
                    control.Text = MultilingualInterface.DefineTranslation[control.Name].GetTranslation(lang);

                if (control is PictureBox && MultilingualInterface.DefineTranslationImage.ContainsKey(control.Name))
                    control.BackgroundImage = MultilingualInterface.DefineTranslationImage[control.Name].GetTranslation(lang);
            }
        }

        public static void LanguageButtonsHandler(Button EngBtn, Button UkrBtn, string lang)
        {
            if (lang == "eng")
            {
                EngBtn.Enabled = false;
                EngBtn.BackColor = Color.Firebrick;
                UkrBtn.BackColor = Color.Tomato;
                UkrBtn.Enabled = true;
            }
            if (lang == "ukr")
            {
                EngBtn.Enabled = true;
                UkrBtn.BackColor = Color.Firebrick;
                EngBtn.BackColor = Color.Tomato;
                UkrBtn.Enabled = false;
            }
        }

        public static void ScoreLabelsHandler(Label scoreLabel, Label generalScoreLabel, string lang)
        {
            if (lang == "eng")
            {
                scoreLabel.Text = "Score: ";
                generalScoreLabel.Text = "General score: ";
            }
            if (lang == "ukr")
            {
                scoreLabel.Text = "Рахунок: ";
                generalScoreLabel.Text = "Загальний рахунок: ";
            }
        }
    }
}
