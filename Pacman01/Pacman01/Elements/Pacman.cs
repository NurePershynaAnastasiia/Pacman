using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Elements
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
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }
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


    }
}
