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
    public partial class ShopForm : Form
    {
        public Game game { get; set; }
        public ShopForm(Game game)
        {
            InitializeComponent();
            this.Size = new Size(800, 870);
            this.game = game;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm(game);
            menuForm.Show();
        }
    }
}
