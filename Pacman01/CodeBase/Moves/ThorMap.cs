using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;

namespace CodeBase.Moves
{
    public class ThorMap
    {
        public static void Step(Field field, Element element)
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
