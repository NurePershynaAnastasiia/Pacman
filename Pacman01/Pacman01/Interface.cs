using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.GameProcess;
using CodeBase.Elements;

namespace PacmanConsole
{
    class Interface
    {
        public static void DrawField(string path, int generalScore)
        {
            FileReaderPrint(path);
            Console.WriteLine("Score: 0   coins");
            Console.WriteLine("General score: " + generalScore + "   coins");
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
