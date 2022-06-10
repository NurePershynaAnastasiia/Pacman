using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman04
{
    class Interface
    {

        public static void Game_over()
        {
            FileReader("game_over.txt");
        }

        public static void Victory(int general_score)
        {
            FileReader("victory.txt");
            Console.WriteLine("General score: " + general_score + " coins");
            Thread.Sleep(3000);
        }

        public static void Shop(int general_score, char design)
        {
            FileReader("shop.txt");
            Console.WriteLine("Your money: " + general_score + " coins");
            Console.WriteLine("Pacman design now: " + design);
        }

        public static int Choose_level()
        {
            FileReader("choose_level.txt");
            int x = Console.Read();
            x -= '0';
            if (x >= 1 && x <= 3) return x;
            else return 1;

        }

        public static void FileReader (string path)
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
