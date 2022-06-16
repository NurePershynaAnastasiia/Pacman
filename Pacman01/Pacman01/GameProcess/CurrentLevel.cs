using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;
using Pacman01.GameProcess;

namespace Pacman01.GameProcess
{
    public class CurrentLevel
    {
        public CurrentLevel(int level, Field field, Field fieldEnemies, Pacman pacman, List<Enemy> enemies, int points)
        {
            this.Pacman = pacman;
            this.Field = field;
            this.FieldEnemies = fieldEnemies;
            this.Enemies = enemies;
            this.Level = level;
            this.Points = points;
        }
        public CurrentLevel() {}
        public Field Field { get; set; }
        public Field FieldEnemies { get; set; }
        public List<Enemy> Enemies { get; set; }
        public Pacman Pacman { get; set; }
        public int Level { get; set; }
        public int Points { get; set; }
    }
}
