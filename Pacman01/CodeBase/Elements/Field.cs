using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace CodeBase.Elements
{
    public class Field
    {
        public Element[,] map = new Element[50, 50];
        private int scaredTime = 10;

        public Field(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public Element this[int i, int j]
        {
            get => map[i, j];
            set => map[i, j] = value;
        }

        public int Height { get; set; }

        public int Width { get; set; }

        public bool isScared { get; set; }

        public int ScaredTime
        {
            get { return scaredTime; }
            set { scaredTime = value; }
        }

        public int Score { get; set; }
    }
}
