using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Elements
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
        abstract public void Draw();
        abstract public bool isObstacle();
        abstract public bool isEaten();
    }
}
