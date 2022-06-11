using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Elements
{
    public class Cell : Element
    {
        public override void Draw()
        {
            Console.Write(' ');
        }
        public override bool isObstacle()
        {
            return false;
        }
        public override bool isEaten()
        {
            return false;
        }
    }
}
