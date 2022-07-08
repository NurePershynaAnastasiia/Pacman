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
    public partial class MenuForm : Form
    {
        public Game game { get; set; }

        public MenuForm(Game game)
        {
            this.Size = new Size(800, 870);
            this.game = game;
            InitializeComponent();
            LanguageChanger.Menu(this, game.Language);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChooseLevelForm(game).Show();
        }

        private void InstructionsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InstructionsForm(game).Show();
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShopForm(game).Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EngBtn_Click(object sender, EventArgs e)
        {
            game.Language = "eng";
            LanguageChanger.Menu(this, "eng");
        }

        private void UkrBtn_Click(object sender, EventArgs e)
        {
            game.Language = "ukr";
            LanguageChanger.Menu(this, "ukr");
        }
    }
}
