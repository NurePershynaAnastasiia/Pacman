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
    public class Wall : Element
    {
        public override int X { get; set; }

        public override int Y { get; set; }

        public override bool isObstacle()
        {
            return true;
        }

        public override void Action(Game game) { }

        public override string Name()
        {
            return "wall";
        }

        public override char Direction { get; set; }
    }
}
