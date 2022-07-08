using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace CodeBase.GameProcess
{
    public class Game
    {
        public Game(Level CurrentLevel, int GeneralScore, int Design)
        {
            this.CurrentLevel = CurrentLevel;
            this.GeneralScore = GeneralScore;
            this.Design = Design;
        }

        public Level CurrentLevel { get; set; }

        public int GeneralScore { get; set; }

        public int Design { get; set; }

        public bool Finished { get; set; }

    }
}
