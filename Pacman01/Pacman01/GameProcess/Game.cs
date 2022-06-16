using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;

namespace Pacman01.GameProcess
{
    public class Game
    {
        public Game(CurrentLevel CurrentLevel, int GeneralScore, int Design)
        {
            this.CurrentLevel = CurrentLevel;
            this.GeneralScore = GeneralScore;
            this.Design = Design;
        }
        public CurrentLevel CurrentLevel { get; set; }
        public int GeneralScore { get; set; }
        public int Design { get; set; }
        public bool Finished { get; set; }

    }
}
