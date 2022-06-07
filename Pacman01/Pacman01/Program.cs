using System;

namespace Game_pacman
{
    class Game_pacman
    {
        abstract class Element
        {
            abstract public void Draw();
        }
        class Pacman : Element
        {
            private int x, y, time = 0, score = 0, design;
            private bool lost, scared = false;

            public Pacman(int x, int y, int design)
            {
                this.x = x;
                this.y = y;
                this.design = design;
            }
            public int Design
            {
                get { return design; }
                set { design = value; }
            }
            public int Score
            {
                get { return score; }
                set { score = value; }
            }
            public bool Lost
            {
                get { return lost; }
                set { lost = value; }
            }
            public bool Scared
            {
                get { return scared; }
                set { scared = value; }
            }

            public int Time
            {
                get { return time; }
                set { time = value; }
            }
            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public void Step(Element[,] Field, Element[,] Field_enemies, Dictionary<char, Coords> Coords_upd, char direction, Enemy enemy1, Enemy enemy2)
            {
                Field[x, y] = new Cell();

                string tmp = Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString();
                string tmp_enemy = Field_enemies[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString();

                if (tmp_enemy.Substring(tmp_enemy.IndexOf('+') + 1) == "Enemy")
                {
                    if (x + Coords_upd[direction].x == enemy1.X && y + Coords_upd[direction].y == enemy1.Y)
                    {
                        if (enemy1.Scared)
                        {
                            enemy1.Eaten = true;
                            enemy1.Scared = false;
                        }
                        else if (!enemy1.Eaten)
                        {
                            this.Lost = true;
                            Game_over();
                        }
                    }
                    if (x + Coords_upd[direction].x == enemy2.X && y + Coords_upd[direction].y == enemy2.Y)
                    {
                        if (enemy2.Scared)
                        {
                            enemy2.Eaten = true;
                            enemy2.Scared = false;
                        }
                        else if (!enemy2.Eaten)
                        {
                            this.Lost = true;
                            Game_over();
                        }
                    }

                }
                if (tmp.Substring(tmp.IndexOf('+') + 1) != "Wall")
                {
                    if (tmp.Substring(tmp.IndexOf('+') + 1) == "Energizer")
                        this.scared = true;
                    if (tmp.Substring(tmp.IndexOf('+') + 1) == "Coin")
                        this.score++;

                    this.x = x + Coords_upd[direction].x;
                    this.y = y + Coords_upd[direction].y;
                }
              
                if (this.scared)
                    this.Time++;
                if (this.Time == 10)
                {
                    this.Scared = false;
                    this.Time = 0;
                }

            }
            public override void Draw()
            {
                switch (design)
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

        }
        class Enemy : Element
        {
            private int x, y, eaten_time = 0;
            private bool lost;
            private bool scared = false, eaten = false;
            private char prev = ' ';

            public Enemy(int x, int y, bool lost = false)
            {
                this.x = x;
                this.y = y;
            }
            public bool Eaten
            {
                get { return eaten; }
                set { eaten = value; }
            }
            public int Eaten_time
            {
                get { return eaten_time; }
                set { eaten_time = value; }
            }

            public bool Scared
            {
                get { return scared; }
                set { scared = value; }
            }
            public bool Lost
            {
                get { return lost; }
                set { lost = value; }
            }
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public bool Cycle_check(char dir, char prev)
            {
                if (prev == 'u' && dir == 'd') return false;
                if (prev == 'd' && dir == 'u') return false;
                if (prev == 'l' && dir == 'r') return false;
                if (prev == 'r' && dir == 'l') return false;
                return true;
            }
            public void Step(Element[,] Field, Element[,] Field_enemies, Dictionary<char, Coords> Coords_upd, Pacman pacman)
            {
                if (!this.eaten)
                {
                    char direction = 'u';
                    string tmp = Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString();

                    Random rnd = new Random();
                    int dir = rnd.Next();

                    while (tmp.Substring(tmp.IndexOf('+') + 1) == "Wall" || !Cycle_check(direction, prev))
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
                        tmp = Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString();
                    }
                    this.prev = direction;

                    Field_enemies[x, y] = new Cell();

                
                    if (tmp.Substring(tmp.IndexOf('+') + 1) == "Pacman")
                    {
                        if (!this.scared && !this.eaten)
                        {
                            this.lost = true;
                            Game_over();
                        }
                        if (this.scared && !this.eaten)
                            this.eaten = true;
                    }
                    if (tmp.Substring(tmp.IndexOf('+') + 1) != "Wall")
                    {
                        this.x = x + Coords_upd[direction].x;
                        this.y = y + Coords_upd[direction].y;
                    }
                }
                else
                    this.eaten_time++;

                if (eaten_time == 10)
                {
                    eaten_time = 0;
                    this.eaten = false;
                }
                    
            }

            public override void Draw()
            { 
                if (this.scared || this.eaten)
                    Console.Write('V');
                else
                    Console.Write('A');
            }
        }
        class Wall : Element
        {
            public override void Draw()
            {
                Console.Write('#');
            }
        }
        class Coin : Element
        {
            public override void Draw()
            {
                Console.Write('.');
            }
        }
        class Cell : Element
        {
            public override void Draw()
            {
                Console.Write(' ');
            }
        }
        class Energizer : Element
        {
            public override void Draw()
            {
                Console.Write('@');
            }
        }

        public struct Coords
        {
            public int x, y;
            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            //Coords dictionary
            Dictionary<char, Coords> Coords_upd = new Dictionary<char, Coords>();
            Coords_upd.Add('u', new Coords(-1, 0));
            Coords_upd.Add('d', new Coords(1, 0));
            Coords_upd.Add('r', new Coords(0, 1));
            Coords_upd.Add('l', new Coords(0, -1));
            //Choosing level
            int lvl = Choose_level();
            int pac_x, pac_y, height, width, e1_x, e1_y, e2_x, e2_y;
            switch (lvl)
            {
                case 1:
                    height = 7; width = 17;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    e2_x = 5; e2_y = 1;
                    break;
                case 2:
                    height = 7; width = 17;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    e2_x = 5; e2_y = 1;
                    break;
                case 3:
                    height = 7; width = 13;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    e2_x = 5; e2_y = 1;
                    break;
                default:
                    height = 7; width = 13;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    e2_x = 5; e2_y = 1;
                    break;

            }

            int general_score = 0, design = 0;
            bool end_game = false;
            while (!end_game)
            {
                Element[,] Field = new Element[height, width];
                Element[,] Field_enemies = new Element[height, width];
                Pacman pacman = new Pacman(pac_x, pac_y, design);
                Enemy enemy1 = new Enemy(e1_x, e1_y);
                Enemy enemy2 = new Enemy(e2_x, e2_y);

                Start(Field, Field_enemies, lvl);
                Update(Field, Field_enemies, pacman, enemy1, enemy2, pacman.Score, general_score);

                ConsoleKeyInfo key_pressed = Console.ReadKey();

                while (!pacman.Lost && !enemy1.Lost && !enemy2.Lost)
                {

                    key_pressed = (Console.KeyAvailable == false) ? key_pressed : Console.ReadKey();
                    //direction pacman
                    char dir = 'r';
                    if (key_pressed.Key == ConsoleKey.W) dir = 'u';
                    if (key_pressed.Key == ConsoleKey.S) dir = 'd';
                    if (key_pressed.Key == ConsoleKey.A) dir = 'l';
                    if (key_pressed.Key == ConsoleKey.D) dir = 'r';

                    pacman.Step(Field, Field_enemies, Coords_upd, dir, enemy1, enemy2);

                    if (pacman.Lost || enemy1.Lost || enemy2.Lost)
                    {
                        Game_over();
                        end_game = true;
                    }
                    else Update(Field, Field_enemies, pacman, enemy1, enemy2, pacman.Score, general_score);

                    enemy1.Step(Field, Field_enemies, Coords_upd, pacman);
                    enemy2.Step(Field, Field_enemies, Coords_upd, pacman);

                    if (pacman.Lost || enemy1.Lost || enemy2.Lost)
                    {
                        Game_over();
                        end_game = true;
                    }
                    else Update(Field, Field_enemies, pacman, enemy1, enemy2, pacman.Score, general_score);

                    
                    if (pacman.Score == 48 && lvl == 1)
                    {
                        general_score += pacman.Score;
                        Victory(general_score);
                        ConsoleKeyInfo key_pressed1 = Console.ReadKey();
                        if (key_pressed1.Key == ConsoleKey.N) end_game = true;
                        else if (key_pressed1.Key == ConsoleKey.S) design = Shop_purchase(general_score, design);
                        break;
                    }
                }
            }
        }
            
        static int Choose_level()
        {
            Console.Clear();
            string path = "choose_level.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            int x = Console.Read();
            if (x - '0' >= 1 && x - '0' <= 3) return x - '0';
            else return 1;

        }
        static void Update(Element[,] Field, Element[,] Field_enemies, Pacman pacman, Enemy enemy1, Enemy enemy2, int score, int general_score)
        {
            Field[pacman.X, pacman.Y] = pacman;

            Field_enemies[enemy1.X, enemy1.Y] = enemy1;
            Field_enemies[enemy2.X, enemy2.Y] = enemy2;

            if (pacman.Scared)
            {
                if (!enemy1.Eaten) enemy1.Scared = true;
                if (!enemy2.Eaten) enemy2.Scared = true;
            }
            else
            {
                enemy1.Scared = false;
                enemy2.Scared = false;
            }

            Draw(Field, Field_enemies, score, general_score);
        }
        static void Draw(Element[,] Field, Element[,] Field_enemies, int score, int general_score)
        {
            Console.Clear();
            Console.WriteLine(); Console.WriteLine(); 

            for (int i = 0; i < Field.GetLength(0); i++)
            {
                Console.Write("                                             ");
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    string tmp = Field_enemies[i, j].ToString();
                    string tmp1 = Field[i, j].ToString();
                    if (tmp.Substring(tmp.IndexOf('+') + 1) == "Enemy" && tmp1.Substring(tmp.IndexOf('+') + 1) != "Pacman") Field_enemies[i, j].Draw();
                    else Field[i, j].Draw();
                }
                Console.WriteLine();
            }
            Console.WriteLine("Score:" + score + " coins");
            Console.WriteLine("General score:" + (general_score + score) + " coins");
            Thread.Sleep(250);
        }

        static void Start(Element[,] Field, Element[,] Field_enemies, int lvl)
        {
            //filling the field 
            string path, path_enemies;
            switch (lvl)
            {
                case 1:
                    path = "lvl1.txt";
                    path_enemies = "lvl1_enemies.txt";
                    break;
                case 2:
                    path = "lvl1.txt";
                    path_enemies = "lvl1_enemies.txt";
                    break;
                case 3:
                    path = "lvl3.txt";
                    path_enemies = "lvl1_enemies.txt";
                    break;
                default:
                    path = "lvl1.txt";
                    path_enemies = "lvl1_enemies.txt";
                    break;

            }
            //filling Field
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == '#') Field[i, j] = new Wall();
                        if (line[j] == '.') Field[i, j] = new Coin();
                        if (line[j] == ' ') Field[i, j] = new Cell();
                        if (line[j] == '@') Field[i, j] = new Energizer();
                        if (line[j] == 'o') Field[i, j] = new Pacman(i, j, 0);
                    }
                    i++;
                }
            }
            //Filling Field_enemies
            using (StreamReader reader = new StreamReader(path_enemies))
            {
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == '#') Field_enemies[i, j] = new Wall();
                        if (line[j] == ' ') Field_enemies[i, j] = new Cell();
                        if (line[j] == 'A') Field_enemies[i, j] = new Enemy(i, j);
                    }
                    i++;
                }
            }
        }

        static void Game_over()
        {
            Console.Clear();
            string path = "game_over.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void Victory(int general_score)
        {
            Console.Clear();
            string path = "victory.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("General score: " + general_score + " coins");
            Thread.Sleep(3000);
        }

        static void Shop(int general_score, int design)
        {
            Console.Clear();
            string path = "shop.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("Your money: " + general_score + " coins");
        }
        static int Shop_purchase(int general_score, int design)
        {
            Shop(general_score, design);
            ConsoleKeyInfo key_pressed = Console.ReadKey();

            while (key_pressed.Key != ConsoleKey.D4)
            {
                int price = 0, res = design;

                if (key_pressed.Key == ConsoleKey.D1)
                {
                    price = 20;
                    res = 1;
                }
                if (key_pressed.Key == ConsoleKey.D2)
                {
                    price = 50;
                    res = 2;
                }
                if (key_pressed.Key == ConsoleKey.D3)
                {
                    price = 100;
                    res = 3;
                }

                if (general_score >= price)
                {
                    general_score -= price;
                    Shop(general_score, design);
                    Console.WriteLine("Purchase was successfully made. Returning to the game...");
                    Thread.Sleep(3000);
                    return res;
                }
                else
                {
                    Shop(general_score, design);
                    Console.WriteLine("You do not have enough money for this purchase :(");
                }
                key_pressed = Console.ReadKey();
            }

            return design;  
        }
    }
}