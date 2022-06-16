using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;
using Pacman01.GameProcess;

namespace Pacman01.Elements
{
    public class Field
    {
        public Element[,] map = new Element[50, 50];
        private int scaredTime = 0, height, width;

        public Field(int height, int width)
        {
            this.width = width;
            this.height = height;
        }
        public Element this[int i, int j]
        {
            get => map[i, j];
            set => map[i, j] = value;
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public bool Scared
        {
            get; set;
        }
        public int ScaredTime
        {
            get { return scaredTime; }
            set { scaredTime = value; }
        }
        public int Score
        {
            get; set;
        }
        public bool GameOver
        {
            get; set;
        }
       
    }
}
