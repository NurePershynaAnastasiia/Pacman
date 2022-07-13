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

        public static Level Initialize(int lvlNumber, Level level)
        {
            Level currentLevel = new Level();
            Field field;
            if (lvlNumber == 5)
                field = level.Field;
            else
                field = GetField(lvlNumber);
            Field fieldEnemies = new Field(field.Height, field.Width);
            List<Enemy> enemies = new List<Enemy>();
            Pacman pacman = new Pacman(0, 0, 0);

            //filling Field
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (field[i, j] is Wall)
                    {
                        fieldEnemies[i, j] = new Wall(i, j);
                    }
                    if (field[i, j] is Coin)
                    {
                        currentLevel.Points++;
                        fieldEnemies[i, j] = new Cell(i, j);
                    }
                    if (field[i, j] is Cell)
                    {
                        fieldEnemies[i, j] = new Cell(i, j);
                    }
                    if (field[i, j] is Energizer)
                    {
                        fieldEnemies[i, j] = new Cell(i, j);
                    }
                    if (field[i, j] is Pacman)
                    {
                        pacman = new Pacman(i, j, 0);
                        fieldEnemies[i, j] = new Cell(i, j);
                    }
                    if (field[i, j] is Enemy)
                    {
                        currentLevel.Points++;
                        fieldEnemies[i, j] = new Enemy(i, j);
                        field[i, j] = new Coin(i, j);
                        enemies.Add(new Enemy(i, j));
                    }
                }
            }
            return new Level(lvlNumber, field, fieldEnemies, pacman, enemies, currentLevel.Points);
        }

        public static Field GetField(int lvl)
        {
            Field field = new Field(40, 40);
            if (lvl == 4)
                field = RandomMap.GenerateLabyrinth();
            else
            {
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
                                field[i, j] = new Wall(i, j);
                            if (line[j] == '.')
                                field[i, j] = new Coin(i, j);
                            if (line[j] == ' ')
                                field[i, j] = new Cell(i, j);
                            if (line[j] == '@')
                                field[i, j] = new Energizer(i, j);
                            if (line[j] == 'o')
                                field[i, j] = new Pacman(i, j, 0);
                            if (line[j] == 'A')
                                field[i, j] = new Enemy(i, j);
                        }
                        i++;
                        line = reader.ReadLine();
                    }
                    field.Height = i;
                }
            }
            return field;    
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
            if (rnd.Next() % 20 != 0)
                return;
            int y = rnd.Next(1, field.Height - 1);
            int x = rnd.Next(1, field.Width - 1);

            if (field[y, x].getName() == "cell")
            {
                field[y, x] = new Bonus(y, x);
                Draw(new Bonus(y, x));
            }
        }
    }
}
