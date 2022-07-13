using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace PacmanGUI
{
    public static class LevelEditor
    {
        public static Game GenerateField(LevelEditorForm levelEditorForm, int height, int width, Game game)
        {
            ClearField(levelEditorForm);
            game.CurrentLevel.Field = new Field(height, width);
            int x = 80, y = 80;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 50;
                    pictureBox.Height = 50;
                    pictureBox.Tag = "fieldCell";
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.Location = new Point(x + 50 * j, y + 50 * i);
                    pictureBox.Click += new System.EventHandler(levelEditorForm.FieldBox_Click);
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    if (i == 0 || j == 0 || i == height - 1 || j == width - 1)
                    {
                        pictureBox.BackgroundImage = Resources.wall;
                        pictureBox.Enabled = false;
                        game.CurrentLevel.Field[i, j] = new Wall(i, j);
                    }
                    else
                        game.CurrentLevel.Field[i, j] = new Cell(i, j);
                    levelEditorForm.Controls.Add(pictureBox);
                }
            }
            return game;
        }

        public static Game AddElement(object sender, Game game, string currentElement)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int x = (pictureBox.Location.Y - 80) / 50;
            int y = (pictureBox.Location.X - 80) / 50;
            switch (currentElement)
            {
                case "pacman":
                    if (!isPacmanPlaced(game.CurrentLevel.Field))
                    {
                        pictureBox.BackgroundImage = Resources.pacman0;
                        game.CurrentLevel.Field[x, y] = new Pacman(x, y, 0);
                    }
                    break;
                case "enemy":
                    pictureBox.BackgroundImage = Resources.enemy_right;
                    game.CurrentLevel.Field[x, y] = new Enemy(x, y);
                    break;
                case "coin":
                    pictureBox.BackgroundImage = Resources.coin;
                    game.CurrentLevel.Field[x, y] = new Coin(x, y);
                    break;
                case "energizer":
                    pictureBox.BackgroundImage = Resources.energizer;
                    game.CurrentLevel.Field[x, y] = new Energizer(x, y);
                    break;
                case "wall":
                    pictureBox.BackgroundImage = Resources.wall;
                    game.CurrentLevel.Field[x, y] = new Wall(x, y);
                    break;
            }
            return game;
        }

        public static bool isPacmanPlaced(Field field)
        {
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (field[i, j] is Pacman)
                        return true;
                }
            }
            return false;
        }

        public static void ClearField(LevelEditorForm levelEditorForm)
        {
            foreach (Control item in levelEditorForm.Controls.OfType<PictureBox>().ToList())
            {
                if (item.Tag == "fieldCell")
                    levelEditorForm.Controls.Remove(item);
            }
        }
    }
}
