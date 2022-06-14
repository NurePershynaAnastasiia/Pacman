using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Moves
{
    public class ThorMap
    {
        public static bool ThorMapCheck(Elements.Field field, Utilities.Utility.Coords pacmanCoords)
        {
            if (pacmanCoords.y == 0 || pacmanCoords.y == field.Width - 1 || pacmanCoords.x == 0 || pacmanCoords.x == field.Height - 1)
                return true;
            return false;
        }

        public static void ThorMapStep(Elements.Field field, Elements.Element element)
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

    }
}
