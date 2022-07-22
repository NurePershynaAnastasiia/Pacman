using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Moves;
using static CodeBase.Moves.CommonMoves;

namespace CodeBase.GameProcess
{
    public static class RandomMap
    {
        public static int unvisitedCells = 0;
        public static Cell[] cellsUnvisitedArray = new Cell[200];

        enum Directions
        {
            up,
            down,
            left,
            right
        }

        public static Field GenerateGrid()
        {
            Random rnd = new Random();
            int height = rnd.Next(10, 15);
            Field field = new Field(height, height + 10);

            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0 && i < field.Height - 1 && j < field.Width - 1)
                    {
                        field[i, j] = new Cell(i, j);
                        cellsUnvisitedArray[unvisitedCells] = (Cell)field[i, j];
                        unvisitedCells++;
                    }
                    else
                        field[i, j] = new Wall(i, j);
                }
            }
            return field;
        }

        public static bool InBounds(Coords element, Field field, bool isInFrame)
        {
            if (isInFrame)
            {
                if (element.x > 0 && element.x < field.Height - 1 && element.y > 0 && element.y < field.Width - 1)
                    return true;
                else
                    return false;
            }
            else if (element.x >= 0 && element.x < field.Height && element.y >= 0 && element.y < field.Width)
                return true;
            return false;
        }

        public static bool IsUnvisited(Coords element, Field field, bool [,] fieldVisited)
        {
            if (InBounds(element, field, true))
            {
                if (fieldVisited[element.x, element.y] == false)
                    return true;
            }
            return false;
        }

        public static bool HasUnvisitedNeighbours(Cell cell, Field field, bool[,] fieldVisited)
        {
            foreach (int i in Enum.GetValues(typeof(Directions)))
            {
                if (IsUnvisited(new Coords(cell.X + GetDirectionElement(i, "cell").x, cell.Y + GetDirectionElement(i, "cell").y), field, fieldVisited))
                    return true;
            }
            return false;
        }

        public static Coords GetDirectionElement(int direction, string element)
        {
            int addition = 0;
            if (element == "cell")
                addition = 1;
            Dictionary<int, Coords> getDirection = new Dictionary<int, Coords>()
            {
                { 0, new Coords(-1 - addition, 0) },
                { 1, new Coords(1 + addition, 0) },
                { 2, new Coords(0, -1 - addition) },
                { 3, new Coords(0, 1 + addition) }
            };

            return getDirection[direction];
        }

        public static int ChooseUnvisitedNeighbour(Cell cell, Field field, bool[,] fieldVisited)
        {
            Random random = new Random();
            Coords newCell = new Coords(cell.X, cell.Y);
            int direction;
            do
            {
                direction = random.Next(0, 4);
            } while (IsUnvisited(new Coords(newCell.x + GetDirectionElement(direction, "cell").x, newCell.y + GetDirectionElement(direction, "cell").y), field, fieldVisited) == false);

            return direction;
        }

        public static Field GenerateLabyrinth()
        {
            Stack<Cell> cellStack = new Stack<Cell>();
            Field field = GenerateGrid();
            bool[,] fieldVisited = new bool[field.Height, field.Width];
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                    fieldVisited[i, j] = false;
            }

            int x = 1, y = 1;
            unvisitedCells--;
            while (unvisitedCells > 0)
            {
                fieldVisited[x, y] = true;
                if (HasUnvisitedNeighbours((Cell)field[x, y], field, fieldVisited))
                {
                    cellStack.Push((Cell)field[x, y]);
                    int direction = ChooseUnvisitedNeighbour((Cell)field[x, y], field, fieldVisited);
                    int cellBetweenX = x + GetDirectionElement(direction, "wall").x;
                    int cellBetweenY = y + GetDirectionElement(direction, "wall").y;
                    field[cellBetweenX, cellBetweenY] = new Cell(cellBetweenX, cellBetweenY);
                    x += GetDirectionElement(direction, "cell").x;
                    y += GetDirectionElement(direction, "cell").y;
                    unvisitedCells--;
                }
                else if (cellStack.Count > 0)
                {
                    Cell cell = cellStack.Pop();
                    x = cell.X;
                    y = cell.Y;
                }
                else
                {
                    int i = 0;
                    while (!IsUnvisited(new Coords(cellsUnvisitedArray[i].X, cellsUnvisitedArray[i].Y), field, fieldVisited))
                        i++;
                    x = cellsUnvisitedArray[i].X;
                    y = cellsUnvisitedArray[i].Y;
                }
            }

            field = RemoveDeadEnds(field);
            field = GenerateElements(field);

            return field;
        }

        public static int WallsAround(Cell cell, Field field)
        {
            int wallsAround = 0;
            foreach (int i in Enum.GetValues(typeof(Directions)))
            {
                Coords currentCoords = new Coords(cell.X + GetDirectionElement(i, "wall").x, cell.Y + GetDirectionElement(i, "wall").y);
                if (InBounds(currentCoords, field, false))
                {
                    if (field[currentCoords.x, currentCoords.y] is Wall)
                        wallsAround++;
                }
            }
            return wallsAround;
        }

        public static Field RemoveWalls(Cell cell, Field field)
        {
            foreach (int i in Enum.GetValues(typeof(Directions)))
            {
                Coords currentCoords = new Coords(cell.X + GetDirectionElement(i, "wall").x, cell.Y + GetDirectionElement(i, "wall").y);
                if (InBounds(currentCoords, field, true))
                {
                    if (field[currentCoords.x, currentCoords.y] is Wall)
                        field[currentCoords.x, currentCoords.y] = new Cell(currentCoords.x, currentCoords.y);
                }
            }
            return field;
        }

        public static Field RemoveDeadEnds(Field field)
        {
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (field[i, j] is Cell && WallsAround((Cell)field[i, j], field) >= 3)
                        RemoveWalls((Cell)field[i, j], field);
                }
            }
            return field;
        }

        public static Field GenerateElements(Field field)
        {
            int enemiesNumber = field.Width / 6, energizersNumber = enemiesNumber + 1;
            int currentPacmanNumber = 0, currentEnemiesNumber = 0, currentEnergizersNumber = 0;
            Random random = new Random();
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (field[i, j] is Cell)
                        field[i, j] = new Coin(i, j);
                }
            }
            while (currentPacmanNumber < 1)
            {
                int randomX = random.Next(1, 5);
                int randomY = random.Next(1, field.Width - 1);
                if (field[randomX, randomY] is Coin)
                {
                    currentPacmanNumber++;
                    field[randomX, randomY] = new Pacman(randomX, randomY, 0);
                }
            }
            while (currentEnemiesNumber < enemiesNumber)
            {
                int randomX = random.Next(5, field.Height - 1);
                int randomY = random.Next(1, field.Width - 1);
                if (field[randomX, randomY] is Coin)
                {
                    currentEnemiesNumber++;
                    field[randomX, randomY] = new Enemy(randomX, randomY);
                }
            }
            while (currentEnergizersNumber < energizersNumber)
            {
                int randomX = random.Next(1, field.Height - 1);
                int randomY = random.Next(1, field.Width - 1);
                if (field[randomX, randomY] is Coin)
                {
                    currentEnergizersNumber++;
                    field[randomX, randomY] = new Energizer(randomX, randomY);
                }
            }
            return field;
        }
    }
}
