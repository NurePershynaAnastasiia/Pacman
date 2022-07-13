using CodeBase.GameProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase.Elements
{
    public class Bonus : Element
    {
        public Bonus(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override int X { get; set; }

        public override int Y { get; set; }

        public override void Action(Game game)
        {
            game.GeneralScore += 5;
        }

        public override bool isObstacle()
        {
            return false;
        }

        public override string getName()
        {
            return "bonus";
        }
    }
}
