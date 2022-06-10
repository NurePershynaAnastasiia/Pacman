using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Utilities
{
    public class Level
    {
        public Level(string path, string pathOutput, int points, Utility.Coords pacmanCoords, int numberOfEnemies, int height, int width)
        {
            this.path = path;
            this.points = points;
            this.pacmanCoords = pacmanCoords;
            this.numberOfEnemies = numberOfEnemies;
            this.height = height;
            this.width = width;
            this.pathOutput = pathOutput;
        }
        public int height
        {
            get; set;
        }
        public int width
        {
            get; set;
        }
        public string path
        {
            get; set;
        }
        public string pathOutput
        {
            get; set;
        }
        public int points
        {
            get; set;
        }
        public int numberOfEnemies
        {
            get; set;
        }
        public Utility.Coords pacmanCoords
        {
            get; set;
        }

    }

}
