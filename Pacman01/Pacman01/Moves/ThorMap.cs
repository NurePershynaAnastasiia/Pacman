using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;
using Pacman01.GameProcess;

namespace Pacman01.Moves
{
    public class ThorMap
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

    }
}
