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
    public class Pacman : Element
    {
        public Pacman(int x, int y, int design)
        {
            this.X = x;
            this.Y = y;
            this.Design = design;
        }
        public int Design
        {
            get; set;
        }
        public override int X { get; set; }
        public override int Y { get; set; }
        public override void Draw()
        {
            switch (Design)
            {
                case 0:
                    Console.Write('o');
                    break;
                case 1:
                    Console.Write('O');
                    break;
                case 2:
                    Console.Write('Q');
                    break;
                case 3:
                    Console.Write('G');
                    break;
                default:
                    Console.Write('o');
                    break;
            };

        }
        public override bool isObstacle()
        {
            return false;
        }
        public override bool isEaten()
        {
            return false;
        }
        public override void Action(Game game) { }
    }
}
