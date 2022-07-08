using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace CodeBase.GameProcess
{
    public class Level
    {
        public Level(int number, Field field, Field fieldEnemies, Pacman pacman, List<Enemy> enemies, int points)
        {
            Pacman = pacman;
            Field = field;
            FieldEnemies = fieldEnemies;
            Enemies = enemies;
            Number = number;
            Points = points;
        }

        public Level() { }

        public Field Field { get; set; }

        public Field FieldEnemies { get; set; }

        public List<Enemy> Enemies { get; set; }

        public Pacman Pacman { get; set; }

        public int Number { get; set; }

        public int Points { get; set; }
    }
}
