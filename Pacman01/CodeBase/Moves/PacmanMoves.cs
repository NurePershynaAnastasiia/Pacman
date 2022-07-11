using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.GameProcess;

namespace CodeBase.Moves
{
    public class PacmanMoves
    {
        public static void FieldScared(Field field)
        {
            if (field.Scared)
                field.ScaredTime--;
            if (field.ScaredTime == 0)
            {
                field.Scared = false;
                field.ScaredTime = 10;
            }
        }

        public static void Step(Game game, char dir, GameFunctions.Draw draw, GameFunctions.DrawStats drawStats)
        {
            Level currentLevel = game.CurrentLevel;
            Pacman pacman = currentLevel.Pacman;
            pacman.Direction = dir;
            FieldScared(currentLevel.Field);

            //empty cell on the place where pacman was
            currentLevel.Field[pacman.X, pacman.Y] = new Cell(pacman.X, pacman.Y);
            draw(currentLevel.Field[pacman.X, pacman.Y]);
            
            if (!currentLevel.Field[pacman.X + CommonMoves.CoordsUpdate(dir).x, pacman.Y + CommonMoves.CoordsUpdate(dir).y].isObstacle())
            {
                pacman.X += CommonMoves.CoordsUpdate(dir).x;
                pacman.Y += CommonMoves.CoordsUpdate(dir).y;
                CommonMoves.ThorMapStep(currentLevel.Field, pacman);
            }
            currentLevel.FieldEnemies[pacman.X, pacman.Y].Action(game);
            if (game.Finished)
                return;
            currentLevel.Field[pacman.X, pacman.Y].Action(game);

            //pacman on its new place
            currentLevel.Field[pacman.X, pacman.Y] = pacman;
            draw(currentLevel.Field[pacman.X, pacman.Y]);

            drawStats(game);
        }
    }
}
