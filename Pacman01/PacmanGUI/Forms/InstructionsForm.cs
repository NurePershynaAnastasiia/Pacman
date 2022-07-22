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
    public partial class InstructionsForm : Form
    {
        public Game game { get; set; }

        public InstructionsForm(Game game)
        {
            this.Size = new Size(800, 870);
            this.game = game;
            InitializeComponent();
            LanguageChanger.Translate(this, game.Language);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuForm(game).Show();
        }

        private void InstructionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
