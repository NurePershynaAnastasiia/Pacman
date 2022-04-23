using System;

abstract class Element
{
    abstract public void Draw();
}
class Pacman : Element
{
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

class Program
{
    static void Main(string[] args)
    {
        Element[,] Field = new Element[7, 13];


        //filling the field
        for (int i = 0; i < Field.GetLength(0); i++)
        {
            for (int j = 0; j < Field.GetLength(1); j++)
            {
                Field[i, j] = new Wall();
            }
        }
        for (int i = 1; i < Field.GetLength(0); i += 2)
        {
            for (int j = 1; j < Field.GetLength(1) - 1; j++)
            {
                Field[i, j] = new Coin();
            }
        }
        for (int i = 1; i < Field.GetLength(0) - 1; i++)
        {
            Field[i, 1] = new Coin();
            Field[i, 5] = new Coin();
            Field[i, 7] = new Coin();
            Field[i, 11] = new Coin();
        }
        Field[1, 6] = new Wall();
        Field[5, 6] = new Wall();

        Field[3, 6] = new Pacman();

        Field[1, 9] = new Enemy();
        Field[5, 1] = new Enemy();
        Field[5, 5] = new Enemy();

        Field[2, 1] = new Energizer();
        Field[5, 11] = new Energizer();
        //

        for (int i = 0; i < Field.GetLength(0); i++)
        {
            for (int j = 0; j < Field.GetLength(1); j++)
            {
                Field[i, j].Draw();
            }
            Console.WriteLine();
        }
    }
}


