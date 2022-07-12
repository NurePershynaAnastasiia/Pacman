using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.GameProcess;
using CodeBase.Elements;
using static CodeBase.Moves.CommonMoves;

namespace PacmanConsole
{
    class Interface
    {
        public static void DrawField(Field field, Field fieldEnemies, GameFunctions.Draw Draw, int generalScore)
        {
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (fieldEnemies[i, j] is Enemy)
                        Draw(fieldEnemies[i, j]);
                    else if (field[i, j] is Wall)
                        DrawWall(field, (Wall)field[i, j]);
                    else
                        Draw(field[i, j]);
                }
                Console.WriteLine();
            }
            //FileReaderPrint(path);
            Console.WriteLine();
            Console.WriteLine("Score: 0   coins");
            Console.WriteLine("General score: " + generalScore + "   coins");
        }

        public static void DrawWall(Field field, Wall wall)
        {
            string resString = "";
            if (RandomMap.InBounds(new Coords(wall.X - 1, wall.Y), field) && field[wall.X - 1, wall.Y] is Wall)
                resString += "1";
            if (RandomMap.InBounds(new Coords(wall.X + 1, wall.Y), field) && field[wall.X + 1, wall.Y] is Wall)
                resString += "2";
            if (RandomMap.InBounds(new Coords(wall.X , wall.Y + 1), field) && field[wall.X, wall.Y + 1] is Wall)
                resString += "3";
            if (RandomMap.InBounds(new Coords(wall.X, wall.Y - 1), field) && field[wall.X, wall.Y - 1] is Wall)
                resString += "4";

            Dictionary<string, char> wallTexture = new Dictionary<string, char>();
            wallTexture.Add("", '═');
            wallTexture.Add("1", '║');
            wallTexture.Add("2", '║');
            wallTexture.Add("3", '═');
            wallTexture.Add("4", '═');
            wallTexture.Add("34", '═');
            wallTexture.Add("12", '║');
            wallTexture.Add("23", '╔');
            wallTexture.Add("24", '╗');
            wallTexture.Add("13", '╚');
            wallTexture.Add("14", '╝');
            wallTexture.Add("134", '╩');
            wallTexture.Add("123", '╠');
            wallTexture.Add("124", '╣');
            wallTexture.Add("234", '╦');
            wallTexture.Add("1234", '╬');

            Console.Write(wallTexture[resString]);
        }

        public static void GameOverPrint()
        {
            FileReaderPrint("game_over.txt");
        }

        public static void IntroPrint()
        {
            FileReaderPrint("intro.txt");
            Thread.Sleep(500);
            FileReaderPrint("intro1.txt");
            Thread.Sleep(1500);
            FileReaderPrint("intro2.txt");
            Thread.Sleep(1500);
            FileReaderPrint("intro3.txt");
            Thread.Sleep(1000);
        }

        public static void InstructionsPrint()
        {
            FileReaderPrint("instructions.txt");
            Console.ReadKey();
        }

        public static void VictoryPrint(int generalScore)
        {
            FileReaderPrint("victory.txt");
            Console.WriteLine("General score: " + generalScore + " coins");
            Thread.Sleep(3000);
        }

        public static void ShopPrint(int generalScore, char design)
        {
            FileReaderPrint("shop.txt");
            Console.WriteLine("Your money: " + generalScore + " coins");
            Console.WriteLine("Pacman design now: " + design);
        }

        public static int ChooseLevelPrint()
        {
            FileReaderPrint("choose_level.txt");
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            if (keyPressed.Key == ConsoleKey.D1)
                return 1;
            if (keyPressed.Key == ConsoleKey.D2)
                return 2;
            if (keyPressed.Key == ConsoleKey.D3)
                return 3;
            if (keyPressed.Key == ConsoleKey.D4)
                return 4;
            return 1;
        }

        public static void FileReaderPrint(string path)
        {
            Console.Clear();
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
