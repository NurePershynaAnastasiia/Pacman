using System;


abstract class Element
{
    abstract public void Draw();
}
class Pacman : Element
{
    private int x, y;
    public bool lost;

    public Pacman(int x, int y, bool lost = false)
    {
        this.x = x;
        this.y = y;
        this.lost = lost;
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
        if (Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString() == "Enemy")
        {
            Game_over();
        }
        else if (Field[x + Coords_upd[direction].x, y + Coords_upd[direction].y].ToString() != "Wall")
        {
            this.x = x + Coords_upd[direction].x;
            this.y = y + Coords_upd[direction].y;
        }


    }
    public override void Draw()
    {
        Console.Write('o');
    }

    public void Game_over()
    {
        this.lost = true;
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

    public override void Draw()
    {
        Console.Write('A');
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


class Program
{
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
        int x, y, height, width;
        switch (lvl)
        {
            case 1:
                height = 7;
                width = 13;
                x = 3;
                y = 6;
                break;
            case 2:
                height = 7;
                width = 13;
                x = 3;
                y = 6;
                break;
            case 3:
                height = 13;
                width = 27;
                x = 4;
                y = 13;
                break;
            default:
                height = 13;
                width = 27;
                x = 3;
                y = 6;
                break;

        }

        Element[,] Field = new Element[height, width];
        Pacman pacman = new Pacman(x, y);

        Start(Field, lvl);
        Draw(Field);

        ConsoleKeyInfo key_pressed;
        key_pressed = Console.ReadKey();

        while (true && !pacman.lost)
        {
            Update(Field, pacman);

            key_pressed = (Console.KeyAvailable == false) ? key_pressed : Console.ReadKey();
            //direction pacman
            if (key_pressed.Key == ConsoleKey.W) pacman.Step(Field, Coords_upd, 'u');
            if (key_pressed.Key == ConsoleKey.S) pacman.Step(Field, Coords_upd, 'd');
            if (key_pressed.Key == ConsoleKey.A) pacman.Step(Field, Coords_upd, 'l');
            if (key_pressed.Key == ConsoleKey.D) pacman.Step(Field, Coords_upd, 'r');

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
    static void Update(Element[,] Field, Pacman pacman)
    {
        Field[pacman.X, pacman.Y] = pacman;
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
                    if (line[j] == 'A') Field[i, j] = new Enemy();
                    if (line[j] == 'o') Field[i, j] = new Pacman(i, j);
                }
                i++;
            }
        }
    }


}


