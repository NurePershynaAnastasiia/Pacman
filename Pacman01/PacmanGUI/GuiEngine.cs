using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;
using CodeBase.SoundEngine;

namespace PacmanGUI
{
    public class GuiEngine
    {
        public static char direction = ' ';

        public static void Playing(Game game, GameFunctions.Draw draw, GameFunctions.DrawStats drawStats, GameForm gameForm)
        {
            Level currentLevel = game.CurrentLevel;
            currentLevel.Pacman.Design = game.Design;
            char keyPressed = direction;
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
                LevelFinished(game, gameForm, "pacman_death.wav", true);
            if (currentLevel.Field.Score == currentLevel.Points)
                LevelFinished(game, gameForm, "pacman_victory.wav", false);
        }

        public static void LevelFinished(Game game, GameForm gameForm, string soundName, bool lost)
        {
            AudioPlaybackEngine.Instance.PlaySound(new CachedSound(soundName));
            gameForm.timerGame.Stop();
            gameForm.Hide();
            if (lost)
                new GameOverForm(game).Show();
            else
                new VictoryForm(game).Show();
        }

        public static void DrawField(PaintEventArgs e, Game game)
        {
            Field field = game.CurrentLevel.Field;
            Field fieldEnemies = game.CurrentLevel.FieldEnemies;
            Graphics g = e.Graphics;
            int cellSize = BiggerCells(game.CurrentLevel.Number);
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    Bitmap currentObj;
                    if (fieldEnemies[i, j].Name() == "enemy")
                        currentObj = Resources.enemy_left;
                    else
                        currentObj = DefineTexture(field[i, j]);

                    g.DrawImage(currentObj, new Rectangle(j * cellSize, i * cellSize, cellSize, cellSize));
                }
            }
        }

        public static void GetDirection (KeyEventArgs e)
        {
            Dictionary<Keys, char> keyInfo = new Dictionary<Keys, char>();
            keyInfo.Add(Keys.W, 'u');
            keyInfo.Add(Keys.S, 'd');
            keyInfo.Add(Keys.A, 'l');
            keyInfo.Add(Keys.D, 'r');
            keyInfo.Add(Keys.P, 'p');

            direction = keyInfo[e.KeyCode];
        }

        public static Bitmap DefineTexture(Element element)
        {
            Dictionary<string, Bitmap> textureInfo = new Dictionary<string, Bitmap>();
            textureInfo.Add("coin", Resources.coin);
            textureInfo.Add("wall", Resources.wall);
            textureInfo.Add("cell", Resources.cell);
            textureInfo.Add("energizer", Resources.energizer);
            if (element.Name() == "pacman")
                textureInfo.Add("pacman", DefineTexturePacman(element));
            if (element.Name() == "enemy")
                textureInfo.Add("enemy", DefineTextureEnemy(element));

            return textureInfo[element.Name()];
        }

        public static Bitmap DefineTextureEnemy(Element element)
        {
            Bitmap currentObj;
            Enemy enemy = (Enemy)element;

            Dictionary<char, Bitmap> textureEnemyInfo = new Dictionary<char, Bitmap>();
            textureEnemyInfo.Add('r', Resources.enemy_right);
            textureEnemyInfo.Add('l', Resources.enemy_left);
            textureEnemyInfo.Add('u', Resources.enemy_up); 
            textureEnemyInfo.Add('d', Resources.enemy_down);

            currentObj = textureEnemyInfo[enemy.Direction];
            if (enemy.isScared || enemy.isEaten)
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
                case 3: currentObj = Resources.pacman3; break;
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

        public static int BiggerCells(int lvl)
        {
            if (lvl == 1) return 50;
            if (lvl == 2) return 40;
            return 30;
        }

    }
}
