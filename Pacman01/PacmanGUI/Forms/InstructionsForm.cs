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
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
            this.Size = new Size(800, 850);
            BackBtn.Click += new EventHandler(BackBtn_Click);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

    }
}
