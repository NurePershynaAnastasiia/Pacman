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
    public class GuiEngine
    {
        public static char direction = ' ';

        public static void Playing(Game game, GameFunctions.Draw draw, GameFunctions.DrawStats drawStats, GameForm gameForm)
        {
            CurrentLevel currentLevel = game.CurrentLevel;
            currentLevel.Pacman.Design = game.Design;
            char keyPressed = GuiEngine.direction;
            if (keyPressed == 'p')
                gameForm.pauseLabel.Show();
            else
            {
                gameForm.pauseLabel.Hide();
                PacmanMoves.Step(game, keyPressed, draw, drawStats);//pacman makes its step
                foreach (Enemy enemy in currentLevel.Enemies) //all the enemies make their step
                    EnemyMoves.Step(game, enemy, draw);
            }

            if (game.Finished)
            {
                gameForm.timerGame.Stop();
                gameForm.Hide();
                GameOverForm gameOverForm = new GameOverForm(game.GeneralScore);
                gameOverForm.Show();
            }
            if (currentLevel.Field.Score == currentLevel.Points)
            {
                gameForm.timerGame.Stop();
                gameForm.Hide();
                VictoryForm victoryForm = new VictoryForm(game);
                victoryForm.Show();
            }

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
                case "pacman": currentObj = DefineTexturePacman(element); break;
                case "enemy": currentObj = DefineTextureEnemy(element); break;
                case "cell": currentObj = Resources.cell; break;
                case "energizer": currentObj = Resources.energizer; break;
                default: currentObj = Resources.cell; break;
            }
            return currentObj;
        }
        public static Bitmap DefineTextureEnemy(Element element)
        {
            Bitmap currentObj;
            Enemy enemy = (Enemy)element;
            switch (element.Direction)
            {
                case 'r': currentObj = Resources.enemy_right; break;
                case 'l': currentObj = Resources.enemy_left; break;
                case 'u': currentObj = Resources.enemy_up; break;
                case 'd': currentObj = Resources.enemy_down; break;
                default: currentObj = Resources.enemy_left; break;
            }
            if (enemy.Scared || enemy.Eaten)
                currentObj = Resources.enemy_scared;
            if (enemy.TimeEaten == 18 || enemy.TimeEaten == 19)
                currentObj = Resources.enemy_scared2;
            return currentObj;
        }
        public static Bitmap DefineTexturePacman(Element element)
        {
            Bitmap currentObj;
            Pacman pacman = (Pacman)element;

            switch (pacman.Design)
            {
                case 1: currentObj = Resources.pacman1; break;
                case 2: currentObj = Resources.pacman2; break;
                default: currentObj = Resources.pacman0; break;
            }

            switch (element.Direction)
            {
                case 'l': currentObj.RotateFlip(RotateFlipType.Rotate180FlipY); break;
                case 'u': currentObj.RotateFlip(RotateFlipType.Rotate90FlipY); break;
                case 'd': currentObj.RotateFlip(RotateFlipType.Rotate270FlipY); break;
                default: break;
            }
     
            return currentObj;
        }

    }
}
