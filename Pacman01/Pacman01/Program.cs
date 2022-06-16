using System;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;
using Pacman01.GameProcess;



namespace Pacman01
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
     
               GameFunctions.Playing(game);
            }
        }
    }
}


        
    


    
