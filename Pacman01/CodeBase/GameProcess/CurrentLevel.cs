using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace CodeBase.GameProcess
{
    public class CurrentLevel
    {
        public CurrentLevel(int level, Field field, Field fieldEnemies, Pacman pacman, List<Enemy> enemies, int points)
        {
            Pacman = pacman;
            Field = field;
            FieldEnemies = fieldEnemies;
            Enemies = enemies;
            Level = level;
            Points = points;
        }

        public CurrentLevel() { }

        public Field Field { get; set; }

        public Field FieldEnemies { get; set; }

        public List<Enemy> Enemies { get; set; }

        public Pacman Pacman { get; set; }

        public int Level { get; set; }

        public int Points { get; set; }
    }
}
