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
    public partial class ChooseLevelForm : Form
    {
        public ChooseLevelForm()
        {
            InitializeComponent();
            this.Size = new Size(800, 850);
        }
        public void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void Lvl1Btn_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.Lvl1Background;
        }
        private void Lvl1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(1);
            gameForm.Show();
        }
        private void Lvl2Btn_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.Lvl2Background;
        }
        private void Lvl2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(2);
            gameForm.Show();
        }
        private void Lvl3Btn_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Resources.Lvl3Background;
        }
        private void Lvl3Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(3);
            gameForm.Show();
        }
        private void LvlBtn_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = null;
        }
    }
}
