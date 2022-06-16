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
    public class GameFunctions
    {

        public static void Playing(Game game)
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            while (!game.CurrentLevel.Field.GameOver)
            {
                CurrentLevel currentLevel = game.CurrentLevel;
                keyPressed = (Console.KeyAvailable == false) ? keyPressed : Console.ReadKey(true);//checking if new key is pressed, if not - use the old one (inertia)
                char key = PacmanMoves.GetDirection(keyPressed);
                if (key == 'p') //pause
                {
                    keyPressed = Pause(game.CurrentLevel.Field);
                }

                PacmanMoves.Step(game, key);//pacman makes its step
                if (currentLevel.Field.GameOver)
                {
                    Interface.GameOver();
                    game.Finished = true;
                }
                foreach (Enemy enemy in currentLevel.Enemies) //all the enemies make their step
                {
                    EnemyMoves.Step(currentLevel, enemy, EnemyMoves.RandomDir(currentLevel.FieldEnemies, enemy));
                    if (currentLevel.Field.GameOver)
                    {
                        Interface.GameOver();
                        game.Finished = true;
                    }
                }

                if (currentLevel.Field.Score == currentLevel.Points)
                {
                    game.GeneralScore += currentLevel.Field.Score;
                    Interface.Victory(game.GeneralScore);
                    ConsoleKeyInfo keyPressed1 = Console.ReadKey();
                    if (keyPressed1.Key == ConsoleKey.N)
                        return;
                    else if (keyPressed1.Key == ConsoleKey.S)//shop
                        ShopPurchase(game);
                }

            }
        }
        public static ConsoleKeyInfo Pause(Field field)
        {
            Console.SetCursorPosition(30, field.Height + 2);
            Console.Write("Paused");
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.SetCursorPosition(30, field.Height + 2);
            Console.Write("      ");
            return key;
        }
        public static CurrentLevel Initialize(int lvl)
        {
            CurrentLevel currentLevel = new CurrentLevel();
            Field field = new Field(40, 40);
            Field fieldEnemies = new Field(40, 40);
            List <Enemy> enemies = new List<Enemy> ();
            Pacman pacman = new Pacman(0, 0, 0);
            int i = 0;
            //filling Field
            using (StreamReader reader = new StreamReader(Utility.LevelInfo(lvl).path))
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
                            field[i, j] = new Coin();
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == ' ')
                        {
                            field[i, j] = new Cell();
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == '@')
                        {
                            field[i, j] = new Energizer();
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == 'o')
                        {
                            pacman = new Pacman(i, j, 0);
                            field[i, j] = pacman;
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == 'A')
                        {
                            field[i, j] = new Coin();
                            fieldEnemies[i, j] = new Enemy(i, j);
                            enemies.Add(new Enemy(i, j));
                        }
                    }
                    i++;
                    line = reader.ReadLine();
                }
                field.Height = i;
            }
            return new CurrentLevel(lvl, field, fieldEnemies, pacman, enemies, currentLevel.Points);
        }
        public static void ShopPurchase(Game game)
        {
            bool done = false;
            Interface.Shop(game.GeneralScore, Utility.DesignInfo(game.Design).appearance);
            int chosenDesign = game.Design;

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey();
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        chosenDesign = 1;
                        break;
                    case ConsoleKey.D2:
                        chosenDesign = 2;
                        break;
                    case ConsoleKey.D3:
                        chosenDesign = 3;
                        break;
                    case ConsoleKey.D9: //пасхалка на добавление монет
                        game.GeneralScore += 10;
                        Interface.Shop(game.GeneralScore, Utility.DesignInfo(game.Design).appearance);
                        continue;
                }

                if (game.GeneralScore >= Utility.DesignInfo(chosenDesign).price)
                {
                    done = true;
                    game.GeneralScore -= Utility.DesignInfo(chosenDesign).price;
                    Interface.Shop(game.GeneralScore, Utility.DesignInfo(chosenDesign).appearance);
                    Console.WriteLine("Purchase was successfully made. Returning to the game...");
                    Thread.Sleep(3000);
                }
                else
                {
                    Interface.Shop(game.GeneralScore, Utility.DesignInfo(game.Design).appearance);
                    Console.WriteLine("You do not have enough money for this purchase :(");
                }

            } while (keyPressed.Key != ConsoleKey.D4 || !done);

            game.Design = chosenDesign;
        }
    }
}
