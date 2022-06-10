using System;


namespace Pacman04
{
    public static class Program
    {
        public abstract class Element
        {
            abstract public void Draw();
            abstract public bool isObstacle();
        }
        public class Pacman : Element
        {
            public Pacman(int x, int y, int design)
            {
                this.X = x;
                this.Y = y;
                this.Design = design;
            }
            public int Design
            {
                get; set;
            }
            public int X
            {
                get; set;
            }
            public int Y
            {
                get; set;
            }
            public override void Draw()
            {
                switch (Design)
                {
                    case 0:
                        Console.Write('o');
                        break;
                    case 1:
                        Console.Write('O');
                        break;
                    case 2:
                        Console.Write('Q');
                        break;
                    case 3:
                        Console.Write('G');
                        break;
                    default:
                        Console.Write('o');
                        break;
                };

            }
            public override bool isObstacle()
            {
                return false;
            }


        }
        public class Enemy : Element
        {
            private int timeEaten = 0;
            private char prev = 'u';
            private bool eaten = false;
            public Enemy(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public char Prev
            {
                get { return prev; }
                set { prev = value; }
            }
            public int TimeEaten
            {
                get; set;
            }
            public int X
            {
                get; set;
            }
            public int Y
            {
                get; set;
            }
            public bool Eaten
            {
                get; set;
            }
            public bool Scared
            {
                get; set;
            }
            public override void Draw()
            {
                if (this.Eaten || this.Scared)
                    Console.Write('V');
                else
                    Console.Write('A');
            }
            public override bool isObstacle()
            {
                return false;
            }
        }
        public class Wall : Element
        {
            public override void Draw()
            {
                Console.Write('#');
            }
            public override bool isObstacle()
            {
                return true;
            }

        }
        public class Coin : Element
        {
            public void Clear()
            {
                Console.Write("");
            }
            public override void Draw()
            {
                Console.Write('.');
            }
            public override bool isObstacle()
            {
                return false;
            }
        }
        public class Cell : Element
        {
            public override void Draw()
            {
                Console.Write(' ');
            }
            public override bool isObstacle()
            {
                return false;
            }
        }
        public class Energizer : Element
        {
            public override void Draw()
            {
                Console.Write('@');
            }
            public override bool isObstacle()
            {
                return false;
            }
        }

        public class Field
        {
            public Element[,] map = new Element[50, 50];
            private int scaredTime = 0, height, width;

            public Field(int height, int width)
            {
                this.width = width;
                this.height = height;
            }
            public Element this[int i, int j]
            {
                get => map[i, j];
                set => map[i, j] = value;
            }
            public int Height
            {
                get { return height; }
                set { height = value; }
            }
            public int Width
            {
                get { return width; }
                set { width = value; }
            }
            public bool Scared
            {
                get; set;
            }
            public int ScaredTime
            {
                get { return scaredTime; }
                set { scaredTime = value; }
            }
            public int Score
            {
                get; set;
            }
            public bool GameOver
            {
                get; set;
            }
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;


            int design = 0, generalScore = 0;

            while (true)
            {

                int lvl = Interface.Choose_level();

                Field field = new Field(Utilities.LevelInfo(lvl).height, Utilities.LevelInfo(lvl).width);
                Field fieldEnemies = new Field(Utilities.LevelInfo(lvl).height, Utilities.LevelInfo(lvl).width);
                Pacman pacman = new Pacman(Utilities.LevelInfo(lvl).pacmanCoords.x, Utilities.LevelInfo(lvl).pacmanCoords.y, design);

                Enemy[] enemies = new Enemy[Utilities.LevelInfo(lvl).numberOfEnemies];

                Start(field, fieldEnemies, Utilities.LevelInfo(lvl).path, enemies, lvl);

                DrawField(field, fieldEnemies, generalScore);

                ConsoleKeyInfo key_pressed = Console.ReadKey(true);
                while (true)
                {

                    key_pressed = (Console.KeyAvailable == false) ? key_pressed : Console.ReadKey(true);
                    //direction pacman
                    char dir = 'r';
                    if (key_pressed.Key == ConsoleKey.W) dir = 'u';
                    if (key_pressed.Key == ConsoleKey.S) dir = 'd';
                    if (key_pressed.Key == ConsoleKey.A) dir = 'l';
                    if (key_pressed.Key == ConsoleKey.D) dir = 'r';

                    StepPacman(pacman, field, fieldEnemies, dir, generalScore, lvl);
                    if (field.GameOver)
                    {
                        Interface.Game_over();
                        return;
                    }

                    for (int i = 0; i < Utilities.LevelInfo(lvl).numberOfEnemies; i++)
                    {
                        StepEnemy(enemies[i], field, fieldEnemies, randomDir(fieldEnemies, enemies[i]), lvl);
                        if (field.GameOver)
                        {
                            Interface.Game_over();
                            return;
                        }
                    }

                    if (field.Score == 10/*levelInfo[lvl].points*/)
                    {
                        generalScore += field.Score;
                        Interface.Victory(generalScore);
                        ConsoleKeyInfo key_pressed1 = Console.ReadKey();
                        if (key_pressed1.Key == ConsoleKey.N)
                            return;
                        else if (key_pressed1.Key == ConsoleKey.S)
                            design = Shop_purchase(ref generalScore, design);
                        break;
                    }
                }
            }
        }

        static int Shop_purchase(ref int generalScore, int design)
        {

            Interface.Shop(generalScore, Utilities.DesignInfo(design).appearance);
            ConsoleKeyInfo key_pressed = Console.ReadKey();
            int chosenDesign = design;

            while (key_pressed.Key != ConsoleKey.D4)
            {
                if (key_pressed.Key == ConsoleKey.D1)
                    chosenDesign = 1;
                if (key_pressed.Key == ConsoleKey.D2)
                    chosenDesign = 2;
                if (key_pressed.Key == ConsoleKey.D3)
                    chosenDesign = 3;

                if (generalScore >= Utilities.DesignInfo(design).price)
                {
                    generalScore -= Utilities.DesignInfo(design).price;
                    Interface.Shop(generalScore, Utilities.DesignInfo(design).appearance);
                    Console.WriteLine("Purchase was successfully made. Returning to the game...");
                    Thread.Sleep(3000);
                    return chosenDesign;
                }
                else
                {
                    Interface.Shop(generalScore, Utilities.DesignInfo(design).appearance);
                    Console.WriteLine("You do not have enough money for this purchase :(");
                }
                key_pressed = Console.ReadKey();
            }

            return chosenDesign;
        }
        public static bool Cycle_check(char dir, char prev)
        {
            if (prev == 'u' && dir == 'd') return false;
            if (prev == 'd' && dir == 'u') return false;
            if (prev == 'l' && dir == 'r') return false;
            if (prev == 'r' && dir == 'l') return false;
            return true;
        }

        public static char randomDir(Field field, Enemy enemy)
        {
            char direction = 'u';
            Random rnd = new Random();
            int dir = rnd.Next();

            while (field[enemy.X + Utilities.CoordsUpdate(direction).x, enemy.Y + Utilities.CoordsUpdate(direction).y].isObstacle() || !Cycle_check(direction, enemy.Prev))
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
        static void StepPacman(Pacman pacman, Field field, Field fieldEnemies, char dir, int generalScore, int lvl)
        {
            if (field.Scared)
                field.ScaredTime++;
            if (field.ScaredTime == 10)
            {
                field.Scared = false;
                field.ScaredTime = 0;
            }

            Console.SetCursorPosition(pacman.Y, pacman.X);
            Cell cell = new Cell();
            cell.Draw();
            field[pacman.X, pacman.Y] = new Cell();

            if (pacman.Y + Utilities.CoordsUpdate(dir).y < 0 || pacman.Y + Utilities.CoordsUpdate(dir).y > 37)
            {
                if (pacman.X + Utilities.CoordsUpdate(dir).x == 6 && pacman.Y + Utilities.CoordsUpdate(dir).y == -1)
                    pacman.Y = 37;
                else if (pacman.X + Utilities.CoordsUpdate(dir).x == 6 && pacman.Y + Utilities.CoordsUpdate(dir).y == 38)
                    pacman.Y = 0;
                if (field[pacman.X, pacman.Y] is Coin)
                    field.Score++;
            }
            else if (!(field[pacman.X + Utilities.CoordsUpdate(dir).x, pacman.Y + Utilities.CoordsUpdate(dir).y].isObstacle()))
            {

                if (field[pacman.X + Utilities.CoordsUpdate(dir).x, pacman.Y + Utilities.CoordsUpdate(dir).y] is Coin)
                    field.Score++;
                if (field[pacman.X + Utilities.CoordsUpdate(dir).x, pacman.Y + Utilities.CoordsUpdate(dir).y] is Energizer)
                    field.Scared = true;
                if (fieldEnemies[pacman.X + Utilities.CoordsUpdate(dir).x, pacman.Y + Utilities.CoordsUpdate(dir).y] is Enemy && !field.Scared)
                    field.GameOver = true;

                pacman.X += Utilities.CoordsUpdate(dir).x;
                pacman.Y += Utilities.CoordsUpdate(dir).y;

            }
            Console.SetCursorPosition(pacman.Y, pacman.X);
            pacman.Draw();
            field[pacman.X, pacman.Y] = pacman;



            Console.SetCursorPosition(7, field.Height);
            Console.Write(field.Score);
            Console.SetCursorPosition(15, field.Height + 1);
            Console.Write(field.Score + generalScore);
            Thread.Sleep(300);

        }

        static void StepEnemy(Enemy enemy, Field field, Field fieldEnemies, char dir, int lvl)
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

            if (!(field[enemy.X, enemy.Y] is Pacman))
            {
                Console.SetCursorPosition(enemy.Y, enemy.X);
                enemy.Draw();
            }

            if (!enemy.Eaten)
            {
                Console.SetCursorPosition(enemy.Y, enemy.X);
                field[enemy.X, enemy.Y].Draw();
                Console.SetCursorPosition(enemy.Y + Utilities.CoordsUpdate(dir).y, enemy.X + Utilities.CoordsUpdate(dir).x);
                enemy.Draw();

                if (field[enemy.X + Utilities.CoordsUpdate(dir).x, enemy.Y + Utilities.CoordsUpdate(dir).y] is Pacman && !field.Scared)
                    field.GameOver = true;
                if (field[enemy.X + Utilities.CoordsUpdate(dir).x, enemy.Y + Utilities.CoordsUpdate(dir).y] is Pacman && field.Scared)
                    enemy.Eaten = true;


                fieldEnemies[enemy.X, enemy.Y] = new Cell();
                enemy.X += Utilities.CoordsUpdate(dir).x;
                enemy.Y += Utilities.CoordsUpdate(dir).y;
                fieldEnemies[enemy.X, enemy.Y] = enemy;

            }


        }
        static void DrawField(Field field, Field fieldEnemies, int generalScore)
        {
            Console.Clear();
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (fieldEnemies[i, j] is Enemy) fieldEnemies[i, j].Draw();
                    else field[i, j].Draw();
                }
                Console.WriteLine();
            }
            Console.WriteLine("Score: " + field.Score + "   coins");
            Console.WriteLine("General score: " + (generalScore + field.Score) + "   coins");
            Thread.Sleep(250);
        }

        static void Start(Field field, Field fieldEnemies, string path, Enemy[] enemies, int lvl)
        {
            //filling Field
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int enemyNumber = 0;
                for (int i = 0; i < field.Height; i++)
                {
                    line = reader.ReadLine();
                    for (int j = 0; j < field.Width; j++)
                    {
                        if (line[j] == '#')
                        {
                            field[i, j] = new Wall();
                            fieldEnemies[i, j] = new Wall();
                        }
                        if (line[j] == '.')
                        {
                            field[i, j] = new Coin();
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == ' ')
                        {
                            field[i, j] = new Cell();
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == '@')
                        {
                            field[i, j] = new Energizer();
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == 'o')
                        {
                            field[i, j] = new Pacman(i, j, 0);
                            fieldEnemies[i, j] = new Cell();
                        }
                        if (line[j] == 'A')
                        {
                            field[i, j] = new Coin();
                            fieldEnemies[i, j] = new Enemy(i, j);
                            enemies[enemyNumber] = new Enemy(i, j);
                            enemyNumber++;
                        }
                    }
                }
                if (lvl == 3)
                {
                    fieldEnemies[6, 0] = new Wall();
                    fieldEnemies[6, 37] = new Wall();
                }
            }
        }

    }
}







