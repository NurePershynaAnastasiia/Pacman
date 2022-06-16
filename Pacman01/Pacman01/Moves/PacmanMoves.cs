using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;
using Pacman01.GameProcess;

namespace Pacman01.Moves
{
    public class PacmanMoves
    {
        public static char GetDirection(ConsoleKeyInfo keyPressed)
        {
            char dir = 'r'; //direction pacman
            if (keyPressed.Key == ConsoleKey.W)
                dir = 'u';
            if (keyPressed.Key == ConsoleKey.S)
                dir = 'd';
            if (keyPressed.Key == ConsoleKey.A)
                dir = 'l';
            if (keyPressed.Key == ConsoleKey.D)
                dir = 'r';
            if (keyPressed.Key == ConsoleKey.P)
                dir = 'p';
            return dir;
        }
        public static void FieldScared(Field field)
        {
            if (field.Scared)
                field.ScaredTime++;
            if (field.ScaredTime == 10)
            {
                field.Scared = false;
                field.ScaredTime = 0;
            }
        }
        public static void Step(Game game, char dir)
        {
            CurrentLevel currentLevel = game.CurrentLevel;
            FieldScared(currentLevel.Field);

            //empty cell on the place where pacman was
            Console.SetCursorPosition(currentLevel.Pacman.Y, currentLevel.Pacman.X);
            Cell cell = new Cell();
            cell.Draw();
            currentLevel.Field[currentLevel.Pacman.X, currentLevel.Pacman.Y] = new Cell();

            if (!(currentLevel.Field[currentLevel.Pacman.X + Utility.CoordsUpdate(dir).x, currentLevel.Pacman.Y + Utility.CoordsUpdate(dir).y].isObstacle()))
            {
                currentLevel.Pacman.X += Utility.CoordsUpdate(dir).x;
                currentLevel.Pacman.Y += Utility.CoordsUpdate(dir).y;
                ThorMap.ThorMapStep(currentLevel.Field, currentLevel.Pacman);
            }
            currentLevel.FieldEnemies[currentLevel.Pacman.X, currentLevel.Pacman.Y].Action(game);
            if (game.Finished)
                return;
            currentLevel.Field[currentLevel.Pacman.X, currentLevel.Pacman.Y].Action(game);
            

            //pacman on its new place
            Console.SetCursorPosition(currentLevel.Pacman.Y, currentLevel.Pacman.X);
            currentLevel.Pacman.Draw();
            currentLevel.Field[currentLevel.Pacman.X, currentLevel.Pacman.Y] = currentLevel.Pacman;

            Console.SetCursorPosition(7, currentLevel.Field.Height);
            Console.Write(currentLevel.Field.Score);
            Console.SetCursorPosition(15, currentLevel.Field.Height + 1);
            Console.Write(currentLevel.Field.Score + game.GeneralScore);
            Thread.Sleep(300);

        }
    }
}
