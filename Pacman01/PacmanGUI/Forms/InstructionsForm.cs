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
    public partial class InstructionsForm : Form
    {
        public Game game { get; set; }
        public InstructionsForm(Game game)
        {
            InitializeComponent();
            this.Size = new Size(800, 820);
            this.game = game;
            BackBtn.Click += new EventHandler(BackBtn_Click);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm(game);
            menuForm.Show();
        }

        private void InstructionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
