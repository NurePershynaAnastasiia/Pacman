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
    public static class Utility
    {
        public struct Coords
        {
            public int x, y;
            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static Coords CoordsUpdate(char direction)
        {
            switch (direction)
            {
                case 'd':
                    return new Coords(1, 0);
                case 'u':
                    return new Coords(-1, 0);
                case 'r':
                    return new Coords(0, 1);
                case 'l':
                    return new Coords(0, -1);
                default:
                    return new Coords(0, 0);
            }
        }
        public static Design DesignInfo(int key)
        {
            Dictionary<int, Design> designInfo = new Dictionary<int, Design>();
            designInfo.Add(0, new Design(appearace: 'o', price: 0));
            designInfo.Add(1, new Design(appearace: 'O', price: 20));
            designInfo.Add(2, new Design(appearace: 'Q', price: 50));
            designInfo.Add(3, new Design(appearace: 'G', price: 100));

            return designInfo[key];
        }

        public static Level LevelInfo(int lvl)
        {
            Dictionary<int, Level> levelInfo = new Dictionary<int, Level>();
            levelInfo.Add(1, new Level(path: "lvl1.txt", pathOutput: "lvl1Output.txt"));
            levelInfo.Add(2, new Level(path: "lvl2.txt", pathOutput: "lvl2Output.txt"));
            levelInfo.Add(3, new Level(path: "lvl3.txt", pathOutput: "lvl3Output.txt"));

            return levelInfo[lvl];
        }
    }
}

