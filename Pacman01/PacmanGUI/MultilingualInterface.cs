using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGUI
{
    public class MultilingualInterface
    {
        public struct Languages
        {
            public string UkrVer, EnVer;
            public Languages(string UkrVer, string EngVer)
            {
                this.UkrVer = UkrVer;
                this.EnVer = EngVer;    
            }
        }
        public static string MenuFormLang(string name, string lang)
        {
            Dictionary<string, Languages> Translation = new Dictionary<string, Languages>();
            Translation.Add("PlayBtn", new Languages("Грати", "Play"));
            Translation.Add("ShopBtn", new Languages("Магазин", "Shop"));
            Translation.Add("InstructionsBtn", new Languages("Інструкції", "Instructions"));
            Translation.Add("ExitBtn", new Languages("Вихід", "Exit"));
            Translation.Add("EngBtn", new Languages("Англ", "Eng"));
            Translation.Add("UkrBtn", new Languages("Укр", "Ukr"));

            if (lang == "eng")
                return Translation[name].EnVer;
            return Translation[name].UkrVer;
        }

        public static string ChooseLevelFormLang(string name, string lang)
        {
            Dictionary<string, Languages> Translation = new Dictionary<string, Languages>();
            Translation.Add("BackBtn", new Languages("Назад", "Back"));
            Translation.Add("Lvl1Btn", new Languages("Рівень 1", "Level 1"));
            Translation.Add("Lvl2Btn", new Languages("Рівень 2", "Level 2"));
            Translation.Add("Lvl3Btn", new Languages("Рівень 3", "Level 3"));
            Translation.Add("RandomMapBtn", new Languages("Рандомна мапа", "Random map"));

            if (lang == "eng")
                return Translation[name].EnVer;
            return Translation[name].UkrVer;
        }

        public static string InstructionsFormLang(string name, string lang)
        {
            Dictionary<string, Languages> Translation = new Dictionary<string, Languages>();
            Translation.Add("BackBtn", new Languages("Назад", "Back"));
            Translation.Add("labelPacman", new Languages("Пакмен (гравець), що\r\nконтролюється кнопками WASD", "PacMan (player) controlled \r\nwith WASD keys"));
            Translation.Add("labelGhost", new Languages("Привид (ворог),\r\nякого Пакмен\r\nмає уникати", "Ghost (enemy)\r\nwhich PacMan \r\nhas to avoid"));
            Translation.Add("labelGhostScared", new Languages("Наляканий Привид\r\n(нешкідливий\r\nворог)", "Scared Ghost\r\n(harmless\r\nenemy)"));
            Translation.Add("labelEnergizer1", new Languages("Енерджайзер, який Пакман може з'їсти,\r\nщоб Вороги перейшли в Наляканий Режим", "Energizer which PacMan can eat to \r\nturn Ghosts into Scared mode\r\n"));
            Translation.Add("labelEnergizer2", new Languages("Коли Привиди в Наляканому Режимі,\r\nПакмен може \"з'їсти\" іх, щоб\r\nнейтралізувати на деякий час ", "When Ghosts are in Scared mode,\r\nPacMan can \"eat\" them to neutralize\r\nfor some time"));
            Translation.Add("labelCoin", new Languages("Монета, яку\r\nПакмен має з'їсти,\r\nщоб підвищити\r\nрахунок", "Coin, which \r\nPacMan has to \r\neat to \r\nearn Points"));
            Translation.Add("labelWall", new Languages("Стіна\r\n(непроникна\r\nперешкода\r\nдля Пакмена\r\nта Ворогів", "Wall\r\n(impenetrable\r\nobstacle for\r\nPacMan and\r\nEnemies)"));


            if (lang == "eng")
                return Translation[name].EnVer;
            return Translation[name].UkrVer;
        }

        public static string ShopFormLang(string name, string lang)
        {
            Dictionary<string, Languages> Translation = new Dictionary<string, Languages>();
            Translation.Add("BackBtn", new Languages("Назад", "Back"));
            Translation.Add("Hipster1Label", new Languages("Пакмен-хіпстер", "Hipster Pacman"));
            Translation.Add("Hipster2Label", new Languages("Гарний молодий хіпстер\r\nу червоній шапці\r\n\r\nЦіна: 20 монет", "Good-looking young hipster \r\nguy in a red beanie\r\n\r\nPrice: 20 points"));
            Translation.Add("Sombrero1Label", new Languages("Пакмен у Сомбреро", "Pacman in Sombrero"));
            Translation.Add("Sombrero2Label", new Languages("Він просто занадто полюбляє начос\r\n\r\n\r\nЦіна: 50 монет", "He just likes nachos too much\r\n\r\n\r\nPrice: 50 points"));
            Translation.Add("Satan1Label", new Languages("Диявольський Пакмен", "Satanic Pacman"));
            Translation.Add("Satan2Label", new Languages("Навіть сам диявол\r\nбоїться привидів\r\n\r\nЦіна: 100 монет", "Even satan himself is scared \r\nof ghosts\r\n\r\nPrice: 100 points"));
            Translation.Add("pointsLabel", new Languages("Монети:", "Points:"));
            Translation.Add("Buy1Btn", new Languages("Купити", "Buy"));
            Translation.Add("Buy2Btn", new Languages("Купити", "Buy"));
            Translation.Add("Buy3Btn", new Languages("Купити", "Buy"));

            if (lang == "eng")
                return Translation[name].EnVer;
            return Translation[name].UkrVer;
        }

        public static string GameFormLang(string name, string lang)
        {
            Dictionary<string, Languages> Translation = new Dictionary<string, Languages>();
            Translation.Add("pauseLabel", new Languages("Пауза", "Pause"));
            Translation.Add("PressPauseLabel", new Languages("Натисність англійську P,\r\nщоб поставити на паузу", "Press P to Pause"));
            Translation.Add("scoreLabel", new Languages("Рахунок:", "Score:"));
            Translation.Add("generalScoreLabel", new Languages("Загальний рахунок:", "GeneralScore:"));

            if (lang == "eng")
                return Translation[name].EnVer;
            return Translation[name].UkrVer;
        }

        public static string GameOverFormLang(string name, string lang)
        {
            Dictionary<string, Languages> Translation = new Dictionary<string, Languages>();
            Translation.Add("ExitBtn", new Languages("Вихід", "Exit"));
            Translation.Add("generalScoreLabel", new Languages("Загальний рахунок: ", "General Score: "));

            if (lang == "eng")
                return Translation[name].EnVer;
            return Translation[name].UkrVer;
        }

        public static string VictoryFormLang(string name, string lang)
        {
            Dictionary<string, Languages> Translation = new Dictionary<string, Languages>();
            Translation.Add("ExitBtn", new Languages("Вихід", "Exit"));
            Translation.Add("BackToMenuBtn", new Languages("До Меню", "Back to Menu"));
            Translation.Add("generalScoreLabel", new Languages("Загальний рахунок: ", "General Score: "));

            if (lang == "eng")
                return Translation[name].EnVer;
            return Translation[name].UkrVer;
        }
    }
}
