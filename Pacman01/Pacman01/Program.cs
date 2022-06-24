using System;
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

                ConsoleEngine.Playing(game, Draw, DrawStats);
            }
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







