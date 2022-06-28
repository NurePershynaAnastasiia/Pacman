using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.GameProcess;

namespace CodeBase.Moves
{
    public class EnemyMoves
    {
        public static bool CycleCheck(char dir, char prev)
        {
            if (prev == 'u' && dir == 'd') return false;
            if (prev == 'd' && dir == 'u') return false;
            if (prev == 'l' && dir == 'r') return false;
            if (prev == 'r' && dir == 'l') return false;
            return true;
        }

        public static void RandomDir(Field field, Enemy enemy)
        {
            char direction = 'u';
            Random rnd = new Random();
            int dir = rnd.Next();

            while (field[enemy.X + Utility.CoordsUpdate(direction).x, enemy.Y + Utility.CoordsUpdate(direction).y].isObstacle() || !CycleCheck(direction, enemy.Prev))
            {
                dir++;
                switch (dir % 4)
                {
                    case 0:
                        direction = 'u';
                        break;
                    case 1:
                        direction = 'd';
                        break;
                    case 2:
                        direction = 'r';
                        break;
                    case 3:
                        direction = 'l';
                        break;
                }

            }
            enemy.Prev = direction;
            enemy.Direction = direction;
        }

        public static void EnemyStatus(Enemy enemy, Field field)
        {
            if (enemy.Eaten)
                enemy.TimeEaten++;
            if (enemy.TimeEaten == 20)
            {
                enemy.Eaten = false;
                enemy.TimeEaten = 0;
            }

            if (field.Scared)
                enemy.Scared = true;
            else
                enemy.Scared = false;

            if (field[enemy.X, enemy.Y] is Pacman && field.Scared)
                enemy.Eaten = true;
        }

        public static void Step(Game game, Enemy enemy, GameFunctions.Draw draw)
        {
            if (game.Finished)
                return;
            CurrentLevel currentLevel = game.CurrentLevel;
            EnemyStatus(enemy, currentLevel.Field);
            RandomDir(currentLevel.Field, enemy);

            if (!enemy.Eaten)
            {
                currentLevel.FieldEnemies[enemy.X, enemy.Y] = new Cell(enemy.X, enemy.Y);
                draw(currentLevel.Field[enemy.X, enemy.Y]);

                enemy.X += Utility.CoordsUpdate(enemy.Direction).x;
                enemy.Y += Utility.CoordsUpdate(enemy.Direction).y;
                ThorMap.Step(currentLevel.Field, enemy);

                draw(enemy);

                if (currentLevel.Field[enemy.X, enemy.Y] is Pacman && !currentLevel.Field.Scared)
                    game.Finished = true;
                if (currentLevel.Field[enemy.X, enemy.Y] is Pacman && currentLevel.Field.Scared)
                    enemy.Eaten = true;

                currentLevel.FieldEnemies[enemy.X, enemy.Y] = enemy;
            }
            else if (!(currentLevel.Field[enemy.X, enemy.Y] is Pacman))
                draw(enemy);
        }
    }
}
