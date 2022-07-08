using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace CodeBase.Elements
{
    public class Pacman : Element
    {
        public Pacman(int x, int y, int design)
        {
            this.X = x;
            this.Y = y;
            this.Design = design;
        }

        public int Design { get; set; }

        public override int X { get; set; }

        public override int Y { get; set; }

        public override bool isObstacle()
        {
            return false;
        }

        public override void Action(Game game) { }

        public override string Name()
        {
            return "pacman";
        }

        public override char Direction { get; set; }
    }
}
