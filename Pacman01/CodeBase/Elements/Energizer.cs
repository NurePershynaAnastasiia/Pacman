using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;
using CodeBase.SoundEngine;

namespace CodeBase.Elements
{
    public class Energizer : Element
    {
        public Energizer(int x, int y)
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
            game.CurrentLevel.Field.Scared = true;
            game.CurrentLevel.Field.ScaredTime += 10;

            AudioPlaybackEngine.Instance.PlaySound(new CachedSound("pacman_energizer.wav"));
        }

        public override string getName()
        {
            return "energizer";
        }
    }
}
