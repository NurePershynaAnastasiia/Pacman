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
        public int TimeEaten
        {
            get; set;
        }
        public override int X
        {
            get; set;
        }
        public override int Y
        {
            get; set;
        }
        public bool Eaten
        {
            get; set;
        }
        public bool Scared
        {
            get; set;
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (this.Eaten || this.Scared)
                Console.Write('V');
            else
                Console.Write('A');
            Console.ResetColor();
        }
        public override bool isObstacle()
        {
            return false;
        }

        public override bool isEaten()
        {
            if (this.Eaten)
                return true;
            return false;
        }
        public override void Action(Game game)
        {
            if (!game.CurrentLevel.Field.Scared)
                game.Finished = true;
            else
                this.Eaten = true;
        }
    }
}
