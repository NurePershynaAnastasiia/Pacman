using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.Properties;
using System.IO;
using System.Reflection;
using CodeBase.GameProces;

namespace CodeBase.GameProcess
{
    public class GameFunctions
    {
        public delegate void Draw(Element element);
        public delegate void DrawStats(Game game);

       /* 
        public static char[,] GetArray(int lvl)
        {
            char[,] Map = new char[40, 40];
            int i = 0;
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("CodeBase.Resources." + Utility.LevelInfo(lvl).path))
            using (StreamReader reader = new StreamReader(stream))
            {
                string line = reader.ReadLine();
                //width = line.Length;
                while (line != null)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        Map[i, j] = line[j];
                    }
                    i++;
                    line = reader.ReadLine();
                }
                //height = i;
            }
            return Map;
        }
       */

        public static Level Initialize(int lvl)
        {
            Level currentLevel = new Level();
            Field field = new Field(40, 40);
            Field fieldEnemies = new Field(40, 40);
            List<Enemy> enemies = new List<Enemy>();
            Pacman pacman = new Pacman(0, 0, 0);

            //filling Field
            int i = 0;
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("CodeBase.Resources." + LevelInfo(lvl).path))
            using (StreamReader reader = new StreamReader(stream))
            {
                string line = reader.ReadLine();
                field.Width = line.Length;
                while (line != null)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == '#')
                        {
                            field[i, j] = new Wall();
                            fieldEnemies[i, j] = new Wall();
                        }
                        if (line[j] == '.')
                        {
                            currentLevel.Points++;
                            field[i, j] = new Coin(i, j);
                            fieldEnemies[i, j] = new Cell(i, j);
                        }
                        if (line[j] == ' ')
                        {
                            field[i, j] = new Cell(i, j);
                            fieldEnemies[i, j] = new Cell(i, j);
                        }
                        if (line[j] == '@')
                        {
                            field[i, j] = new Energizer(i, j);
                            fieldEnemies[i, j] = new Cell(i, j);
                        }
                        if (line[j] == 'o')
                        {
                            pacman = new Pacman(i, j, 0);
                            field[i, j] = pacman;
                            fieldEnemies[i, j] = new Cell(i, j);
                        }
                        if (line[j] == 'A')
                        {
                            currentLevel.Points++;
                            field[i, j] = new Coin(i, j);
                            fieldEnemies[i, j] = new Enemy(i, j);
                            enemies.Add(new Enemy(i, j));
                        }
                    }
                    i++;
                    line = reader.ReadLine();
                }
                field.Height = i;
            }
            return new Level(lvl, field, fieldEnemies, pacman, enemies, currentLevel.Points);
        }

        public static LevelInfo LevelInfo(int lvl)
        {
            Dictionary<int, LevelInfo> levelInfo = new Dictionary<int, LevelInfo>();
            levelInfo.Add(1, new LevelInfo(path: "lvl1.txt", pathOutput: "lvl1Output.txt"));
            levelInfo.Add(2, new LevelInfo(path: "lvl2.txt", pathOutput: "lvl2Output.txt"));
            levelInfo.Add(3, new LevelInfo(path: "lvl3.txt", pathOutput: "lvl3Output.txt"));
            //levelInfo.Add(4, new Level(path: "RandomLevel.txt", pathOutput: "RandomLevel.txt"));

            return levelInfo[lvl];
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

        public static void SpawnBonus (Field field, Draw Draw)
        {
            Random rnd = new Random();
            if (rnd.Next() % 5 != 0)
                return;
            int y = rnd.Next(1, field.Height);
            int x = rnd.Next(1, field.Width);

            if (field[y, x].Name() == "cell")
            {
                field[y, x] = new Bonus(y, x);
                Draw(new Bonus(y, x));
            }
        }
    }
}
