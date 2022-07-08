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
            Game game = new Game(new Level(), 0, 0);//Game = CurrentLevel + Design + GeneralScore + Finished
            Interface.Intro();
            Interface.Instructions();

            //CodeBase.GameProces.RandomMapGenerator.GenerateMap();

            while (!game.Finished)
            {
                int lvl = Interface.ChooseLevel();
                Console.Clear();
                game.CurrentLevel = GameFunctions.Initialize(lvl);
                Interface.DrawField(Utility.LevelInfo(lvl).pathOutput, game.GeneralScore);

                ConsoleEngine.Playing(game, Draw, DrawStats);
            }
        }
       
        public static void Draw(Element element)
        {
            Console.SetCursorPosition(element.Y, element.X);
            string name = element.Name();
 
            if (name == "pacman")
                DrawPacman((Pacman)element);
            else if (name == "enemy")
                DrawEnemy((Enemy)element);
            else
            {
                Dictionary<string, char> textureInfo = new Dictionary<string, char>();
                textureInfo.Add("cell", ' ');
                textureInfo.Add("coin", '.');
                textureInfo.Add("wall", '#');
                textureInfo.Add("energizer", '@');

                Console.Write(textureInfo[name]);
            }

        }
        public static void DrawPacman(Pacman pacman)
        {
            Dictionary<int, char> pacmanTextureInfo = new Dictionary<int, char>();
            pacmanTextureInfo.Add(0, 'o');
            pacmanTextureInfo.Add(1, 'O');
            pacmanTextureInfo.Add(2, 'Q');
            pacmanTextureInfo.Add(3, 'G');

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(pacmanTextureInfo[pacman.Design]);
            Console.ResetColor();
        }

        public static void DrawEnemy(Enemy enemy)
        {
            char enemyTexture = 'A';
            if (enemy.isEaten || enemy.isScared)
                enemyTexture = 'V';

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(enemyTexture);
            Console.ResetColor();
        }

        public static void DrawStats(Game game)
        {
            Level currentLevel = game.CurrentLevel;
            Console.SetCursorPosition(7, currentLevel.Field.Height);
            Console.Write(currentLevel.Field.Score);
            Console.SetCursorPosition(15, currentLevel.Field.Height + 1);
            Console.Write(game.GeneralScore);
        }
    }
}







