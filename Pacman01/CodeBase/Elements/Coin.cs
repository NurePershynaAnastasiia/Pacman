using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;
using CodeBase.SoundEngine;
using System.IO;
using System.Reflection;

namespace CodeBase.Elements
{
    public class Coin : Element
    {
        public Coin(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override int X { get; set; }

        public override int Y { get; set; }


        public override bool isObstacle()
        {
            return false;
        }

        public override void Action(Game game)
        {
            game.CurrentLevel.Field.Score++;
            game.GeneralScore++;

            AudioPlaybackEngine.Instance.PlaySound(new CachedSound("pacman_chomp.wav"));
        }

        public override string getName()
        {
            return "coin";
        }
    }
}
