using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Elements
{
    public abstract class Element
    {
        abstract public void Draw();
        abstract public bool isObstacle();
        abstract public bool isEaten();
    }
}
