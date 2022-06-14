using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Moves
{
    public class PacmanStep
    {
        public static char GetDirection(ConsoleKeyInfo key_pressed)
        {
            char dir = 'r'; //direction pacman
            if (key_pressed.Key == ConsoleKey.W)
                dir = 'u';
            if (key_pressed.Key == ConsoleKey.S)
                dir = 'd';
            if (key_pressed.Key == ConsoleKey.A)
                dir = 'l';
            if (key_pressed.Key == ConsoleKey.D)
                dir = 'r';
            if (key_pressed.Key == ConsoleKey.P)
                dir = 'p';
            return dir;
        }
        public static void FieldScared(Elements.Field field)
        {
            if (field.Scared)
                field.ScaredTime++;
            if (field.ScaredTime == 10)
            {
                field.Scared = false;
                field.ScaredTime = 0;
            }
        }
        
        public static void StepPacmanCheck(Elements.Field field, Elements.Field fieldEnemies, Elements.Pacman pacman)
        {
            if (field[pacman.X, pacman.Y] is Elements.Coin)
                field.Score++;
            if (field[pacman.X, pacman.Y] is Elements.Energizer)
                field.Scared = true;
            if (fieldEnemies[pacman.X, pacman.Y] is Elements.Enemy && !field.Scared && !fieldEnemies[pacman.X, pacman.Y].isEaten())
                field.GameOver = true;
        }
        public static void StepPacman(Elements.Pacman pacman, Elements.Field field, Elements.Field fieldEnemies, char dir, int generalScore, int lvl)
        {
            FieldScared(field);

            //empty cell on the place where pacman was
            Console.SetCursorPosition(pacman.Y, pacman.X);
            Elements.Cell cell = new Elements.Cell();
            cell.Draw();
            field[pacman.X, pacman.Y] = new Elements.Cell();

            if (!(field[pacman.X + Utilities.Utility.CoordsUpdate(dir).x, pacman.Y + Utilities.Utility.CoordsUpdate(dir).y].isObstacle()))
            {
                pacman.X += Utilities.Utility.CoordsUpdate(dir).x;
                pacman.Y += Utilities.Utility.CoordsUpdate(dir).y;
                if (ThorMap.ThorMapCheck(field, new Utilities.Utility.Coords(pacman.X, pacman.Y)))
                    ThorMap.ThorMapStep(field, pacman);
            }
            StepPacmanCheck(field, fieldEnemies, pacman);

            //pacman on its new place
            Console.SetCursorPosition(pacman.Y, pacman.X);
            pacman.Draw();
            field[pacman.X, pacman.Y] = pacman;

            Console.SetCursorPosition(7, field.Height);
            Console.Write(field.Score);
            Console.SetCursorPosition(15, field.Height + 1);
            Console.Write(field.Score + generalScore);
            Thread.Sleep(300);

        }
    }
}
