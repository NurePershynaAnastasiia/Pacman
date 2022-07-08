using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace CodeBase.Elements
{
    public abstract class Element
    {
        abstract public int X { get; set; }
        abstract public int Y { get; set; }
        abstract public char Direction { get; set; }
        abstract public void Action(Game game);
        abstract public bool isObstacle();
        abstract public string Name();
    }
}
