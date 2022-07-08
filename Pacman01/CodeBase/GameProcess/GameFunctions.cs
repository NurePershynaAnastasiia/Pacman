using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.Moves;
using CodeBase.GameProcess;
using CodeBase.Properties;
using System.IO;
using System.Reflection;

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
            using (Stream stream = assembly.GetManifestResourceStream("CodeBase.Resources." + Utility.LevelInfo(lvl).path))
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
    }
}
