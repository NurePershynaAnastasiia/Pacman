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
    public partial class MenuForm : Form
    {
        public Game game { get; set; }
        public MenuForm(Game game)
        {
            InitializeComponent();
            this.Size = new Size(800, 870);
            this.game = game;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseLevelForm chooseLevelForm = new ChooseLevelForm(game);
            chooseLevelForm.Show();
        }
        private void InstructionsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructionsForm instructionsForm = new InstructionsForm(game);
            instructionsForm.Show();
        }
        private void ShopBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm(game);
            shopForm.Show();
        }
    }
}
