using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Elements
{
    public class Coin : Element
    {
        public void Clear()
        {
            Console.Write("");
        }
        public override void Draw()
        {
            Console.Write('.');
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
