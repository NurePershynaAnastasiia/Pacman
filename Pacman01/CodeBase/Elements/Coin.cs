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
    public class Coin : Element
    {
        public Coin(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Clear()
        {
            Console.Write("");
        }
        public override void Draw()
        {
            Console.Write('.');
        }
        public override bool isObstacle()
        {
            return false;
        }
        public override bool isEaten()
        {
            return false;
        }
        public override int X
        {
            get; set;
        }
        public override int Y
        {
            get; set;
        }
        public override void Action(Game game)
        {
            game.CurrentLevel.Field.Score++;
            game.GeneralScore++;
        }
        public override string Name()
        {
            return "coin";
        }
    }
}
