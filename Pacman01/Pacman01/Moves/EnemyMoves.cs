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

        public static char RandomDir(Field field, Enemy enemy)
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
            return direction;
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

            if (field[enemy.X, enemy.Y] is Elements.Pacman && field.Scared)
                enemy.Eaten = true;
        }

        public static void Step(Game game, Enemy enemy, char dir)
        {
            if (game.Finished)
                return;
            CurrentLevel currentLevel = game.CurrentLevel;
            EnemyStatus(enemy, currentLevel.Field);
            Console.SetCursorPosition(enemy.Y, enemy.X);

            if (!enemy.Eaten)
            {
                currentLevel.FieldEnemies[enemy.X, enemy.Y] = new Cell();
                currentLevel.Field[enemy.X, enemy.Y].Draw();

                enemy.X += Utility.CoordsUpdate(dir).x;
                enemy.Y += Utility.CoordsUpdate(dir).y;
                ThorMap.Step(currentLevel.Field, enemy);

                Console.SetCursorPosition(enemy.Y, enemy.X);
                enemy.Draw();

                if (currentLevel.Field[enemy.X, enemy.Y] is Pacman && !currentLevel.Field.Scared)
                    game.Finished= true;
                if (currentLevel.Field[enemy.X, enemy.Y] is Pacman && currentLevel.Field.Scared)
                    enemy.Eaten = true;

                currentLevel.FieldEnemies[enemy.X, enemy.Y] = enemy;
            }
            else if (!(currentLevel.Field[enemy.X, enemy.Y] is Pacman))
                enemy.Draw();
        }
    }
}
