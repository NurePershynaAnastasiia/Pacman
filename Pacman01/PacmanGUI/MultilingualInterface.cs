using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGUI
{
    public class MultilingualInterface
    {
        public struct Translation
        {
            public string UkrVer, EnVer;

            public Translation(string UkrVer, string EngVer)
            {
                this.UkrVer = UkrVer;
                this.EnVer = EngVer;
            }

            public string GetTranslation(string lang)
            {
                if (lang == "eng")
                    return this.EnVer;
                return this.UkrVer;
            }
        }

        public struct TranslationImage
        {
            public Bitmap UkrVer, EnVer;

            public TranslationImage(Bitmap UkrVer, Bitmap EngVer)
            {
                this.UkrVer = UkrVer;
                this.EnVer = EngVer;
            }

            public Bitmap GetTranslation(string lang)
            {
                if (lang == "eng")
                    return this.EnVer;
                return this.UkrVer;
            }
        }

        public static Dictionary<string, Translation> DefineTranslation = new Dictionary<string, Translation>()
        {
            { "PlayBtn", new Translation("Грати", "Play") },
            { "ShopBtn", new Translation("Магазин", "Shop") },
            { "InstructionsBtn", new Translation("Інструкції", "Instructions") },
            { "ExitBtn", new Translation("Вихід", "Exit") },
            { "LevelEditorBtn", new Translation("Редактор Рівня", "Level Editor") },
            { "EngBtn", new Translation("Англ", "Eng") },
            { "UkrBtn", new Translation("Укр", "Ukr") },
            { "BackBtn", new Translation("Назад", "Back") },
            { "Lvl1Btn", new Translation("Рівень 1", "Level 1") },
            { "Lvl2Btn", new Translation("Рівень 2", "Level 2") },
            { "Lvl3Btn", new Translation("Рівень 3", "Level 3") },
            { "RandomMapBtn", new Translation("Рандомна мапа", "Random map") },
            { "labelPacman", new Translation("Пакмен (гравець),\r\nщо контролюється\r\nкнопками WASD", "PacMan (player)\r\ncontrolled with\r\nWASD keys") },
            { "labelGhost", new Translation("Привид (ворог),\r\nякого Пакмен\r\nмає уникати", "Ghost (enemy)\r\nwhich PacMan \r\nhas to avoid") },
            { "labelGhostScared", new Translation("Наляканий Привид\r\n(нешкідливий\r\nворог)", "Scared Ghost\r\n(harmless\r\nenemy)") },
            { "labelEnergizer1", new Translation("Енерджайзер, який Пакман може з'їсти,\r\nщоб Вороги перейшли в Наляканий Режим", "Energizer which PacMan can eat to \r\nturn Ghosts into Scared mode\r\n") },
            { "labelEnergizer2", new Translation("Коли Привиди в Наляканому Режимі,\r\nПакмен може \"з'їсти\" іх, щоб\r\nнейтралізувати на деякий час ", "When Ghosts are in Scared mode,\r\nPacMan can \"eat\" them to neutralize\r\nfor some time") },
            { "labelCoin", new Translation("Монета, яку\r\nПакмен має з'їсти,\r\nщоб підвищити\r\nрахунок", "Coin, which \r\nPacMan has to \r\neat to \r\nearn Points") },
            { "labelWall", new Translation("Стіна\r\n(непроникна\r\nперешкода\r\nдля Пакмена\r\nта Ворогів", "Wall\r\n(impenetrable\r\nobstacle for\r\nPacMan and\r\nEnemies)") },
            { "labelBonus", new Translation("Бонус (якщо з'їсти,\r\nдодає 5 монет\r\nдо Загального\r\nРахунку)", "Bonus (adds \r\n5 points to \r\nGeneral Score\r\nif eaten)") },
            { "Hipster1Label", new Translation("Пакмен-хіпстер", "Hipster Pacman") },
            { "Hipster2Label", new Translation("Гарний молодий хіпстер\r\nу червоній шапці\r\n\r\nЦіна: 20 монет", "Good-looking young hipster \r\nguy in a red beanie\r\n\r\nPrice: 20 points") },
            { "Sombrero1Label", new Translation("Пакмен у Сомбреро", "Pacman in Sombrero") },
            { "Sombrero2Label", new Translation("Він просто занадто полюбляє начос\r\n\r\n\r\nЦіна: 50 монет", "He just likes nachos too much\r\n\r\n\r\nPrice: 50 points") },
            { "Satan1Label", new Translation("Диявольський Пакмен", "Satanic Pacman") },
            { "Satan2Label", new Translation("Навіть сам диявол\r\nбоїться привидів\r\n\r\nЦіна: 100 монет", "Even satan himself is scared \r\nof ghosts\r\n\r\nPrice: 100 points") },
            { "pointsLabel", new Translation("Монети:", "Points:") },
            { "Buy1Btn", new Translation("Купити", "Buy") },
            { "Buy2Btn", new Translation("Купити", "Buy") },
            { "Buy3Btn", new Translation("Купити", "Buy") },
            { "pauseLabel", new Translation("Пауза", "Pause") },
            { "PressPauseLabel", new Translation("Натисність англійську P,\r\nщоб поставити на паузу", "Press P to Pause") },
            { "scoreLabel", new Translation("Рахунок:", "Score:") },
            { "generalScoreLabel", new Translation("Загальний рахунок:", "GeneralScore:") },
            { "BackToMenuBtn", new Translation("До Меню", "Back to Menu") },
            { "CreateBtn", new Translation("Створити", "Create") },
            { "GameElementsLabel", new Translation("Ігрові Елементи", "Game Elements") },
            { "FieldSizeLabel", new Translation("Розмір Поля", "Field Size") },
            { "HeightLabel", new Translation("Висота", "Height") },
            { "WidthLabel", new Translation("Ширина", "Width") }
        };

        public static Dictionary<string, TranslationImage> DefineTranslationImage = new Dictionary<string, TranslationImage>()
        {
            { "chooseLevelTitlePictureBox", new TranslationImage(Resources.textChooseLevelUkr, Resources.textChooseLevelEng) },
            { "shopTitlePictureBox", new TranslationImage(Resources.textShopUkr, Resources.textShopEng) },
            { "instructionsTitlePictureBox", new TranslationImage(Resources.textInstructionsUkr, Resources.textInstructionsEng) },
            { "gameOverTitlePictureBox", new TranslationImage(Resources.textGameOverUkr, Resources.textGameOverEng) },
            { "victoryTitlePictureBox", new TranslationImage(Resources.textVictoryUkr, Resources.textVictoryEng) }
        };
    }
}
