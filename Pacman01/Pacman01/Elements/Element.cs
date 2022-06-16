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
    public abstract class Element
    {
        abstract public int X
        {
            get; set;
        }
        abstract public int Y
        {
            get; set;
        }
        abstract public void Action(Game game);
        abstract public void Draw();
        abstract public bool isObstacle();
        abstract public bool isEaten();
    }
}
