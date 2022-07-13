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
    public partial class LevelEditorForm : Form
    {
        public Game game { get; set; }
        public string currentElement { get; set; }
        public LevelEditorForm(Game game)
        {
            InitializeComponent();
            this.Size = new Size(1300, 870);
            this.game = game;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            var bitmapImage = new Bitmap(pictureBox.BackgroundImage, new Size(50, 50));
            Cursor = new Cursor(bitmapImage.GetHicon());
            currentElement = pictureBox.Tag.ToString();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            game = LevelEditor.GenerateField(this, (int)HeightNumericUpDown.Value, (int)WidthNumericUpDown.Value, game);
        }

        private void LevelEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void FieldBox_Click(object sender, EventArgs e)
        {
            game = LevelEditor.AddElement(sender, game, currentElement);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuForm(game).Show();
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            Cursor = DefaultCursor;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameForm(game, 5).Show();
        }
    }
}
