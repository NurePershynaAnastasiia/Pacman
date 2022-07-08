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
    public class Enemy : Element
    {
        private char prev = 'u';

        public Enemy(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public char Prev 
        {
            get { return prev; }
            set { prev = value; }
        }

        public int TimeEaten { get; set; }

        public override int X { get; set; }

        public override int Y { get; set; }

        public bool isEaten { get; set; }

        public bool isScared { get; set; }

        public override bool isObstacle()
        {
            return false;
        }

        public override void Action(Game game)
        {
            if (!game.CurrentLevel.Field.Scared && !this.isEaten)
                game.Finished = true;
            else
                this.isEaten = true;
        }

        public override string Name()
        {
            return "enemy";
        }

        public override char Direction { get; set; }
    }
}
