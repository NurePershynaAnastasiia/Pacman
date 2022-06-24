using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.GameProcess;

namespace PacmanConsole
{
    class Interface
    {
        public static void DrawField(string path, int generalScore)
        {
            FileReader(path);
            Console.WriteLine("Score: 0   coins");
            Console.WriteLine("General score: " + generalScore + "   coins");
        }
        public static void GameOver()
        {
            FileReader("game_over.txt");
        }

        public static void Intro()
        {
            FileReader("intro.txt");
            Thread.Sleep(500);
            FileReader("intro1.txt");
            Thread.Sleep(1500);
            FileReader("intro2.txt");
            Thread.Sleep(1500);
            FileReader("intro3.txt");
            Thread.Sleep(1000);
        }
        public static void Instructions()
        {
            FileReader("instructions.txt");
            Console.ReadKey();
        }
        public static void Victory(int generalScore)
        {
            FileReader("victory.txt");
            Console.WriteLine("General score: " + generalScore + " coins");
            Thread.Sleep(3000);
        }

        public static void Shop(int generalScore, char design)
        {
            FileReader("shop.txt");
            Console.WriteLine("Your money: " + generalScore + " coins");
            Console.WriteLine("Pacman design now: " + design);
        }

        public static int ChooseLevel()
        {
            FileReader("choose_level.txt");
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            if (keyPressed.Key == ConsoleKey.D1)
                return 1;
            if (keyPressed.Key == ConsoleKey.D2)
                return 2;
            if (keyPressed.Key == ConsoleKey.D3)
                return 3;
            return 1;

        }

        public static void FileReader(string path)
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
