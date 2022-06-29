using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGUI
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(int generalScore)
        {
            InitializeComponent();
            this.Size = new Size(800, 870);
            generalScoreLabel.Text = "General Score: " + generalScore.ToString();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
