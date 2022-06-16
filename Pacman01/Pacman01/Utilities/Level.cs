using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;
using Pacman01.GameProcess;

namespace Pacman01.Utilities
{
    public class Level
    {
        public Level(string path, string pathOutput)
        {
            this.path = path;
            this.pathOutput = pathOutput;
        }
        public string path
        {
            get; set;
        }
        public string pathOutput
        {
            get; set;
        }

    }

}
