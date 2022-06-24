﻿using System;
using System.Runtime.CompilerServices;
using CodeBase.Utilities;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace PacmanConsole
{
    public static class Program
    {
        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game game = new Game(new CurrentLevel(), 0, 0);//Game = CurrentLevel + Design + GeneralScore + Finished
            Interface.Intro();
            Interface.Instructions();

            while (!game.Finished)
            {
                int lvl = Interface.ChooseLevel();
                CurrentLevel currentLevel = GameFunctions.Initialize(lvl);
                game = new Game(currentLevel, game.GeneralScore, game.Design);
                Interface.DrawField(Utility.LevelInfo(lvl).pathOutput, game.GeneralScore);

                Playing(game, Draw, DrawStats);
            }
        }
        public static void Playing(Game game, GameFunctions.Draw draw, GameFunctions.DrawStats drawStats)
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            CurrentLevel currentLevel = game.CurrentLevel;
            while (!game.Finished && currentLevel.Field.Score != currentLevel.Points)
            {
                keyPressed = Console.KeyAvailable == false ? keyPressed : Console.ReadKey(true);//checking if new key is pressed, if not - use the old one (inertia)
                //keyPressed = Pause(keyPressed, game.CurrentLevel.Field); //checking if "P" is pressed => game on Pause

                PacmanMoves.Step(game, PacmanMoves.GetDirection(keyPressed), draw, drawStats);//pacman makes its step
                foreach (Enemy enemy in currentLevel.Enemies) //all the enemies make their step
                    EnemyMoves.Step(game, enemy, EnemyMoves.RandomDir(currentLevel.FieldEnemies, enemy), draw);
            }
            if (currentLevel.Field.Score == currentLevel.Points)
                VictoryAction(game);
            else
                Interface.GameOver();
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
        public static void VictoryAction(Game game)
        {
            Interface.Victory(game.GeneralScore);
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
        public static ConsoleKeyInfo Pause(ConsoleKeyInfo keyPressed, Field field)
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
        public static void Draw(Element element)
        {
            Console.SetCursorPosition(element.Y, element.X);
            element.Draw();
        }
        public static void DrawStats(Game game)
        {
            CurrentLevel currentLevel = game.CurrentLevel;
            Console.SetCursorPosition(7, currentLevel.Field.Height);
            Console.Write(currentLevel.Field.Score);
            Console.SetCursorPosition(15, currentLevel.Field.Height + 1);
            Console.Write(game.GeneralScore);
        }
    }
}







