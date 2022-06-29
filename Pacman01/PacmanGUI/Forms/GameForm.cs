using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase.Utilities;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;


namespace PacmanGUI
{
    public partial class GameForm : Form
    {
        public Field field, fieldEnemies;
        int lvl = 1;
        public Game game { get; set; }

        public GameForm(Game game, int lvl)
        {
            InitializeComponent();
            this.Size = new Size(1300, 870);
            this.lvl = lvl;
            this.game = game;
            pauseLabel.Hide();
            resetGame();
        }
        private void resetGame()
        {
            CurrentLevel currentLevel = GameFunctions.Initialize(lvl);
            field = currentLevel.Field;
            fieldEnemies = currentLevel.FieldEnemies;
            game = new Game(currentLevel, game.GeneralScore, game.Design);//Game = CurrentLevel + Design + GeneralScore + Finished

            timerGame.Start();
        }
        private void MainGameTimer(object sender, EventArgs e)
        {
            GuiEngine.Playing(game, Draw, DrawStats, this);
        }
        public void pictureBoxField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    Bitmap currentObj;
                    if (fieldEnemies[i, j].Name() == "enemy" && !field.Scared)
                        currentObj = Resources.enemy_left;
                    else
                        currentObj = GuiEngine.DefineTexture(field[i, j]);
                    
                    g.DrawImage(currentObj, new Rectangle(j + (30 * j), i + (30 * i), 30, 30));
                }
            }
        }
        public void Draw(Element element)
        {
            Graphics g = pictureBoxField.CreateGraphics();
            g.DrawImage(GuiEngine.DefineTexture(element), new Rectangle(element.Y + (30 * element.Y), element.X + (30 * element.X), 30, 30));
            //pictureBoxField.Refresh();
        }
        public void DrawStats(Game game)
        {
            CurrentLevel currentLevel = game.CurrentLevel;
            scoreLabel.Text = "Score: " + (currentLevel.Field.Score).ToString();
            generalScoreLabel.Text = "General score: " + game.GeneralScore.ToString();
        }
        public void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            GuiEngine.GetDirection(e);
        }

    }
}
