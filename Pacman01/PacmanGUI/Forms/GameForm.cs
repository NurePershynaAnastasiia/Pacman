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
            InitializeComponent();
            this.Size = new Size(1300, 870);
            this.lvl = lvl;
            this.game = game;
            pauseLabel.Hide();
            resetGame();
        }

        public void resetGame()
        {
            Level currentLevel = GameFunctions.Initialize(lvl);
            game = new Game(currentLevel, game.GeneralScore, game.Design);//Game = CurrentLevel + Design + GeneralScore + Finished

            timerGame.Start();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            GuiEngine.Playing(game, Draw, DrawStats, this);
        }
        public void Draw(Element element)
        {
            Graphics g = pictureBoxField.CreateGraphics();
            int cellSize = GuiEngine.BiggerCells(lvl);
            g.DrawImage(GuiEngine.DefineTexture(element), new Rectangle(element.Y * cellSize, element.X * cellSize, cellSize, cellSize));
        }

        public void DrawStats(Game game)
        {
            Level currentLevel = game.CurrentLevel;
            scoreLabel.Text = "Score: " + (currentLevel.Field.Score).ToString();
            generalScoreLabel.Text = "General score: " + game.GeneralScore.ToString();
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
