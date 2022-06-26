using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Utilities;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace PacmanGUI
{
    public static class GuiEngine
    {
        public static char direction = ' ';
        public static void Playing(Game game, GameFunctions.Draw draw, GameFunctions.DrawStats drawStats)
        {
            CurrentLevel currentLevel = game.CurrentLevel;
            //keyPressed = Pause(keyPressed, game.CurrentLevel.Field); //checking if "P" is pressed => game on Pause

            PacmanMoves.Step(game, GuiEngine.direction, draw, drawStats);//pacman makes its step
            foreach (Enemy enemy in currentLevel.Enemies) //all the enemies make their step
                EnemyMoves.Step(game, enemy, EnemyMoves.RandomDir(currentLevel.FieldEnemies, enemy), draw);

            /*if (currentLevel.Field.Score == currentLevel.Points)
                VictoryAction(game);
            else
                Interface.GameOver();*/
        }
        public static char GetDirection (KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: GuiEngine.direction = 'u'; break;
                case Keys.S: GuiEngine.direction = 'd'; break;
                case Keys.A: GuiEngine.direction = 'l'; break;
                case Keys.D: GuiEngine.direction = 'r'; break;
                case Keys.P: GuiEngine.direction = 'p'; break;
                default: direction = ' '; break;
            }
            return GuiEngine.direction;
        }
        public static Bitmap DefineTexture (Element element)
        {
            Bitmap currentObj;
            switch (element.Name())
            {
                case "coin": currentObj = Resources.coin; break;
                case "wall": currentObj = Resources.wall; break;
                case "pacman": currentObj = Resources.pacman0; break;
                case "enemy": currentObj = Resources.enemy; break;
                case "cell": currentObj = Resources.cell; break;
                case "energizer": currentObj = Resources.energizer; break;
                default: currentObj = Resources.cell; break;
            }
            return currentObj;
        }
       
    }
}
