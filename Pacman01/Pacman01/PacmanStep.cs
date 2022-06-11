using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class PacmanStep
    {
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
        public static bool ThorMapCheck(Elements.Field field, Utilities.Utility.Coords pacmanCoords)
        {
            if (pacmanCoords.y < 0 || pacmanCoords.y > field.Width || pacmanCoords.x < 0 || pacmanCoords.x > field.Height)
                return true;
            return false;
        }

        public static void ThorMapStep(Elements.Field field, Elements.Pacman pacman)
        {
            if (pacman.Y < 0)
                pacman.Y = field.Width - 1;
            if (pacman.Y == field.Width)
                pacman.Y = 0;
            if (pacman.X < 0)
                pacman.X = field.Height - 1;
            if (pacman.X == field.Height)
                pacman.X = 0;
        }

        public static void StepPacmanCheck(Elements.Field field, Elements.Field fieldEnemies, Elements.Pacman pacman)
        {
            if (field[pacman.X, pacman.Y] is Elements.Coin)
                field.Score++;
            if (field[pacman.X, pacman.Y] is Elements.Energizer)
                field.Scared = true;
            if (fieldEnemies[pacman.X, pacman.Y] is Elements.Enemy && !field.Scared)
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

            if (ThorMapCheck(field, new Utilities.Utility.Coords(pacman.X + Utilities.Utility.CoordsUpdate(dir).x, pacman.Y + Utilities.Utility.CoordsUpdate(dir).y)))
            {
                pacman.X += Utilities.Utility.CoordsUpdate(dir).x;
                pacman.Y += Utilities.Utility.CoordsUpdate(dir).y;
                ThorMapStep(field, pacman);
            }
            else if (!(field[pacman.X + Utilities.Utility.CoordsUpdate(dir).x, pacman.Y + Utilities.Utility.CoordsUpdate(dir).y].isObstacle()))
            {
                pacman.X += Utilities.Utility.CoordsUpdate(dir).x;
                pacman.Y += Utilities.Utility.CoordsUpdate(dir).y;
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
