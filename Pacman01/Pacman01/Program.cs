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
            private int x, y, time = 0;
            private bool lost, scared = false;
            

            public Pacman(int x, int y, bool lost = false)
            {
                this.x = x;
                this.y = y;
                this.lost = lost;
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

            public void Step(Element[,] Field, Dictionary<char, Coords> Coords_upd, char direction)
            {
                Field[x, y] = new Cell();
                string tmp = Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString();
                
                if (tmp.Substring(tmp.IndexOf('+') + 1) != "Wall")
                {
                    if (tmp.Substring(tmp.IndexOf('+') + 1) == "Energizer")
                        this.scared = true;
                    
                    this.x = x + Coords_upd[direction].x;
                    this.y = y + Coords_upd[direction].y;
                }
                if (tmp.Substring(tmp.IndexOf('+') + 1) == "Enemy")
                {
                    if (!this.scared)
                    {
                        this.Lost = true;
                        Game_over();
                    }
                    else
                    {
                         
                    }
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
                Console.Write('o');
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
        class Enemy : Element
        {
            private int x, y;
            private bool lost;
            public Element prev = new Coin();
            private bool scared = false;

            public Enemy(int x, int y, bool lost = false)
            {
                this.x = x;
                this.y = y;
                this.prev = prev;

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

            public void Step(Element[,] Field, Dictionary<char, Coords> Coords_upd, Pacman pacman)
            {
                Random rnd = new Random();
                char direction = 'u';
                switch (rnd.Next() % 4)
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


                Field[this.x, this.y] = prev;

                string tmp = Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString();

                if (tmp.Substring(tmp.IndexOf('+') + 1) != "Wall")
                {
                    prev = Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y];
                    this.x = x + Coords_upd[direction].x;
                    this.y = y + Coords_upd[direction].y;
                }

               

                if (tmp.Substring(tmp.IndexOf('+') + 1) == "Pacman")
                {
                    this.Lost = true;
                    Game_over();
                }
               

            }

            public override void Draw()
            {
                if (!this.scared)
                    Console.Write('A');
                else
                    Console.Write('V');
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
            int pac_x, pac_y, height, width, e1_x, e1_y;
            switch (lvl)
            {
                case 1:
                    height = 7; width = 17;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    break;
                case 2:
                    height = 7; width = 13;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    break;
                case 3:
                    height = 7; width = 13;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    break;
                default:
                    height = 7; width = 13;
                    pac_x = 3; pac_y = 6;
                    e1_x = 1; e1_y = 9;
                    break;

            }

            Element[,] Field = new Element[height, width];
            Pacman pacman = new Pacman(pac_x, pac_y);
            Enemy enemy1 = new Enemy(e1_x, e1_y);

            Start(Field, lvl);
            Draw(Field);

            ConsoleKeyInfo key_pressed;
            key_pressed = Console.ReadKey();

            while (!pacman.Lost && !enemy1.Lost)
            {

                key_pressed = (Console.KeyAvailable == false) ? key_pressed : Console.ReadKey();
                //direction pacman
                if (key_pressed.Key == ConsoleKey.W) pacman.Step(Field, Coords_upd, 'u');
                if (key_pressed.Key == ConsoleKey.S) pacman.Step(Field, Coords_upd, 'd');
                if (key_pressed.Key == ConsoleKey.A) pacman.Step(Field, Coords_upd, 'l');
                if (key_pressed.Key == ConsoleKey.D) pacman.Step(Field, Coords_upd, 'r');

                Update(Field, pacman, enemy1);
                if (pacman.Lost || enemy1.Lost) Game_over();
                    

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
        static void Update(Element[,] Field, Pacman pacman, Enemy enemy1)
        {
            //Coords dictionary
            Dictionary<char, Coords> Coords_upd = new Dictionary<char, Coords>();
            Coords_upd.Add('u', new Coords(-1, 0));
            Coords_upd.Add('d', new Coords(1, 0));
            Coords_upd.Add('r', new Coords(0, 1));
            Coords_upd.Add('l', new Coords(0, -1));
            //

            Field[pacman.X, pacman.Y] = pacman;
            enemy1.Step(Field, Coords_upd, pacman);
            
            Field[enemy1.X, enemy1.Y] = enemy1;

            if (pacman.Scared)
                enemy1.Scared = true;
            else
                enemy1.Scared = false;

            Draw(Field);
           
        }
        static void Draw(Element[,] Field)
        {
            Console.Clear();
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Field[i, j].Draw();
                }
                Console.WriteLine();
            }
            Thread.Sleep(500);
        }

        static void Start(Element[,] Field, int lvl)
        {
            //filling the field 
            string path;
            switch (lvl)
            {
                case 1:
                    path = "lvl1.txt";
                    break;
                case 2:
                    path = "lvl1.txt";
                    break;
                case 3:
                    path = "lvl3.txt";
                    break;
                default:
                    path = "lvl1.txt";
                    break;

            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == '#') Field[i, j] = new Wall();
                        if (line[j] == '.') Field[i, j] = new Coin();
                        if (line[j] == ' ') Field[i, j] = new Cell();
                        if (line[j] == '@') Field[i, j] = new Energizer();
                        if (line[j] == 'A') Field[i, j] = new Enemy(i, j);
                        if (line[j] == 'o') Field[i, j] = new Pacman(i, j);
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
    }
}




