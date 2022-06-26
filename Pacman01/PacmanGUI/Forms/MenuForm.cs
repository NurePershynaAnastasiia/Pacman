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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 850);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseLevelForm chooseLevelForm = new ChooseLevelForm();
            chooseLevelForm.Show();
        }
        private void InstructionsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructionsForm instructionsForm = new InstructionsForm();
            instructionsForm.Show();
        }
        private void ShopBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }
    }
}
