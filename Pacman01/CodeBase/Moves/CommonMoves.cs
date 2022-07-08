using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;

namespace CodeBase.Moves
{
    public class CommonMoves
    {
        public static void ThorMapStep(Field field, Element element)
        {
            if (element.Y == 0)
                element.Y = field.Width - 2;
            if (element.Y == field.Width - 1)
                element.Y = 1;
            if (element.X == 0)
                element.X = field.Height - 2;
            if (element.X == field.Height - 1)
                element.X = 1;
        }

        public struct Coords
        {
            public int x, y;
            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static Coords CoordsUpdate(char direction)
        {
            switch (direction)
            {
                case 'd':
                    return new Coords(1, 0);
                case 'u':
                    return new Coords(-1, 0);
                case 'r':
                    return new Coords(0, 1);
                case 'l':
                    return new Coords(0, -1);
                default:
                    return new Coords(0, 0);
            }
        }
    }
}
