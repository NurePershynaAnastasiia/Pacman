using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Moves
{
    public class EnemyStep
    {
        public static bool CycleCheck(char dir, char prev)
        {
            if (prev == 'u' && dir == 'd') return false;
            if (prev == 'd' && dir == 'u') return false;
            if (prev == 'l' && dir == 'r') return false;
            if (prev == 'r' && dir == 'l') return false;
            return true;
        }

        public static char RandomDir(Elements.Field field, Elements.Enemy enemy)
        {
            char direction = 'u';
            Random rnd = new Random();
            int dir = rnd.Next();

            while (field[enemy.X + Utilities.Utility.CoordsUpdate(direction).x, enemy.Y + Utilities.Utility.CoordsUpdate(direction).y].isObstacle() || !CycleCheck(direction, enemy.Prev))
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

        public static void EnemyStatus(Elements.Enemy enemy, Elements.Field field)
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

        public static void StepEnemy(Elements.Enemy enemy, Elements.Field field, Elements.Field fieldEnemies, char dir, int lvl)
        {
            EnemyStatus(enemy, field);

            if (!(field[enemy.X, enemy.Y] is Elements.Pacman))
            {
                Console.SetCursorPosition(enemy.Y, enemy.X);
                enemy.Draw();
            }

            if (!enemy.Eaten)
            {
                Console.SetCursorPosition(enemy.Y, enemy.X);
                field[enemy.X, enemy.Y].Draw();
                fieldEnemies[enemy.X, enemy.Y] = new Elements.Cell();

                enemy.X += Utilities.Utility.CoordsUpdate(dir).x;
                enemy.Y += Utilities.Utility.CoordsUpdate(dir).y;

                if (ThorMap.ThorMapCheck(field, new Utilities.Utility.Coords(enemy.X, enemy.Y)))
                    ThorMap.ThorMapStep(field, enemy);

                Console.SetCursorPosition(enemy.Y, enemy.X);
                enemy.Draw();

                if (field[enemy.X, enemy.Y] is Elements.Pacman && !field.Scared)
                    field.GameOver = true;
                if (field[enemy.X, enemy.Y] is Elements.Pacman && field.Scared)
                    enemy.Eaten = true;


              
                fieldEnemies[enemy.X, enemy.Y] = enemy;
            }
        }
    }
}
