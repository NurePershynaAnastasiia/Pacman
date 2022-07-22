using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;


namespace PacmanGUI
{
    public partial class GameForm : Form
    {
        public int lvl { get; set; }

        public Game game { get; set; }

        public GameForm(Game game, int lvl)
        {
            this.Size = new Size(1300, 870);
            this.lvl = lvl;
            this.game = game;
            InitializeComponent();
            pauseLabel.Hide();
            LanguageChanger.Translate(this, game.Language);
            resetGame();
        }

        public void resetGame()
        {
            game.CurrentLevel = GameFunctions.Initialize(lvl, game.CurrentLevel);//Game = CurrentLevel + Design + GeneralScore + Finished
            game.CurrentLevel.Pacman.Design = game.Design;
            timerGame.Start();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            GuiEngine.Playing(game, Draw, DrawStats, this);
        }
        public void Draw(Element element)
        {
            Graphics g = pictureBoxField.CreateGraphics();
            int cellSize = GuiEngine.BiggerCells(lvl, game.CurrentLevel.Field);
            g.DrawImage(GuiEngine.DefineTexture(element), new Rectangle(element.Y * cellSize, element.X * cellSize, cellSize, cellSize));
        }

        public void DrawStats(Game game)
        {
            LanguageChanger.ScoreLabelsHandler(scoreLabel, generalScoreLabel, game.Language);
            Level currentLevel = game.CurrentLevel;
            scoreLabel.Text += currentLevel.Field.Score.ToString();
            generalScoreLabel.Text += game.GeneralScore.ToString();
        }

        public void pictureBoxField_Paint(object sender, PaintEventArgs e)
        {
            GuiEngine.DrawField(e, game);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            GuiEngine.GetDirection(e);
        }

    }
}
