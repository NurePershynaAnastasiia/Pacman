using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;


namespace PacmanConsole
{
    public class ConsoleEngine
    {
        public static void Playing(Game game, GameFunctions.Draw draw, GameFunctions.DrawStats drawStats)
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            Level currentLevel = game.CurrentLevel;
            while (!game.Finished && currentLevel.Field.Score != currentLevel.Points)
            {
                keyPressed = Console.KeyAvailable == false ? keyPressed : Console.ReadKey(true);//checking if new key is pressed, if not - use the old one (inertia)
                if (keyPressed.Key == ConsoleKey.P)
                    keyPressed = SetPause(keyPressed, game.CurrentLevel.Field); //checking if "P" is pressed => game on Pause

                PacmanMoves.Step(game, GetDirection(keyPressed), draw, drawStats);//pacman makes its step
                Thread.Sleep(400);
                foreach (Enemy enemy in currentLevel.Enemies) //all the enemies make their step
                    EnemyMoves.Step(game, enemy, draw);
            }
            if (currentLevel.Field.Score == currentLevel.Points)
            {
                Interface.VictoryPrint(game.GeneralScore);
                ProcessVictory(game);
            }
            else
                Interface.GameOverPrint();
        }

        public static char GetDirection(ConsoleKeyInfo keyPressed)
        {
            Dictionary<ConsoleKey, char> directionInfo = new Dictionary<ConsoleKey, char>();
            directionInfo.Add(ConsoleKey.W, 'u');
            directionInfo.Add(ConsoleKey.S, 'd');
            directionInfo.Add(ConsoleKey.A, 'l');
            directionInfo.Add(ConsoleKey.D, 'r');
            directionInfo.Add(ConsoleKey.P, 'p');

            return directionInfo[keyPressed.Key];
        }

        public static void ShopPurchase(Game game)
        {
            bool done = false;
            Interface.ShopPrint(game.GeneralScore, GameFunctions.DesignInfo(game.Design).appearance);
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
                        Interface.ShopPrint(game.GeneralScore, GameFunctions.DesignInfo(game.Design).appearance);
                        continue;
                }

                if (game.GeneralScore >= GameFunctions.DesignInfo(chosenDesign).price)
                {
                    done = true;
                    game.GeneralScore -= GameFunctions.DesignInfo(chosenDesign).price;
                    Interface.ShopPrint(game.GeneralScore, GameFunctions.DesignInfo(chosenDesign).appearance);
                    Console.WriteLine("Purchase was successfully made. Returning to the game...");
                    Thread.Sleep(3000);
                }
                else
                {
                    Interface.ShopPrint(game.GeneralScore, GameFunctions.DesignInfo(game.Design).appearance);
                    Console.WriteLine("You do not have enough money for this purchase :(");
                }

            } while (keyPressed.Key != ConsoleKey.D4 || !done);

            game.Design = chosenDesign;
        }

        public static void ProcessVictory(Game game)
        {
            ConsoleKeyInfo keyPressed1 = Console.ReadKey();
            if (keyPressed1.Key == ConsoleKey.N)
            {
                game.Finished = true;
                return;
            }
            if (keyPressed1.Key == ConsoleKey.Y)
                return;
            else if (keyPressed1.Key == ConsoleKey.S)//shop
                ShopPurchase(game);
        }

        public static ConsoleKeyInfo SetPause(ConsoleKeyInfo keyPressed, Field field)
        {
            while (keyPressed.Key == ConsoleKey.P)
            {
                Console.SetCursorPosition(30, field.Height + 2);
                Console.Write("Paused");
                keyPressed = Console.ReadKey(true);
                Console.SetCursorPosition(30, field.Height + 2);
                Console.Write("      ");
            }
            return keyPressed;
        }
    }
}
