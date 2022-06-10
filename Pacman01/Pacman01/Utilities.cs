using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman04
{
    public static class Utilities
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

        public class Level
        {
            public Level(string path, int points, Coords pacmanCoords, int numberOfEnemies, int height, int width)
            {
                this.path = path;
                this.points = points;
                this.pacmanCoords = pacmanCoords;
                this.numberOfEnemies = numberOfEnemies;
                this.height = height;
                this.width = width;
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
            public int points
            {
                get; set;
            }
            public int numberOfEnemies
            {
                get; set;
            }
            public Coords pacmanCoords
            {
                get; set;
            }
           
        }

        public class Design
        {
            public Design (char appearace, int price)
            {
                this.appearance = appearace;
                this.price = price;
            }
            public char appearance
            {
                get; set;
            }
            public int price
            {
                get; set;
            }
        }

        public static Design DesignInfo (int key)
        {
            Dictionary<int, Utilities.Design> designInfo = new Dictionary<int, Utilities.Design>();
            designInfo.Add(0, new Utilities.Design(appearace: 'o', price: 0));
            designInfo.Add(1, new Utilities.Design(appearace: 'O', price: 20));
            designInfo.Add(2, new Utilities.Design(appearace: 'Q', price: 50));
            designInfo.Add(3, new Utilities.Design(appearace: 'G', price: 100));

            return designInfo[key];
        }

        public static Level LevelInfo (int lvl)
        {
            Dictionary<int, Utilities.Level> levelInfo = new Dictionary<int, Utilities.Level>();
            levelInfo.Add(1, new Utilities.Level(path: "lvl1.txt", points: 49, pacmanCoords: new Utilities.Coords(3, 6), numberOfEnemies: 2, height: 7, width: 17));
            levelInfo.Add(2, new Utilities.Level(path: "lvl2.txt", points: 97, pacmanCoords: new Utilities.Coords(1, 14), numberOfEnemies: 3, height: 9, width: 29));
            levelInfo.Add(3, new Utilities.Level(path: "lvl3.txt", points: 207, pacmanCoords: new Utilities.Coords(6, 18), numberOfEnemies: 4, height: 12, width: 38));

            return levelInfo[lvl];
        }
    }
}

