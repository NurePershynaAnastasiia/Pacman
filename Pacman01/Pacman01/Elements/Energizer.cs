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
    public class Energizer : Element
    {
        public override void Draw()
        {
            Console.Write('@');
        }
        public override bool isObstacle()
        {
            return false;
        }
        public override bool isEaten()
        {
            return false;
        }
        public override int X
        {
            get; set;
        }
        public override int Y
        {
            get; set;
        }
        public override void Action(Game game)
        {
            game.CurrentLevel.Field.Scared = true;

        }
    }
}
