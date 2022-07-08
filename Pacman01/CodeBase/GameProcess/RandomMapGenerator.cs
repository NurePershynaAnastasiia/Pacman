using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.GameProcess;


namespace CodeBase.GameProces
{
    public class RandomMapGenerator
    {
        public static void GenerateMap()
        {
            char[,] Map = new char[30, 30];
            Random rnd = new Random();
            int height = rnd.Next(10, 20);
            int width = height + 5;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    Map[i, j] = ' ';
            }
            int enemyNumber = (height * width / 50 == 0) ? 1 : height * width / 50;
            int energizerNumber = enemyNumber + 1;
            int currentX = rnd.Next(1, width - 1);
            int currentY = rnd.Next(1, height - 1);
            int enemyNumberNow = 0, energizerNumberNow = 0, pacmanNumberNow = 0;
            for (int k = 0; k < height * width / 2; k++)
            {
                //choosing Direction
                bool moved = false;
                int directionRnd = rnd.Next(1, 5);
                while (!moved)
                {
                    directionRnd++;
                    switch (directionRnd % 4)
                    {
                        case 1:
                            if (currentX + 1 < width - 1)
                            {
                                currentX++;
                                moved = true;
                            }
                            break;
                        case 2:
                            if (currentX - 1 > 0)
                            {
                                currentX--;
                                moved = true;
                            }
                            break;
                        case 3:
                            if (currentY + 1 < height - 1)
                            {
                                currentY++;
                                moved = true;
                            }
                            break;
                        case 4:
                            if (currentY - 1 > 0)
                            {
                                currentY--;
                                moved = true;
                            }
                            break;
                    }
                }
                //choosing Element
                bool placed = false;
                while (!placed)
                {
                    int elementRnd = rnd.Next(1, 5);
                    switch (elementRnd)
                    {
                        case 1:
                            if (pacmanNumberNow == 0)
                            {
                                Map[currentY, currentX] = 'o';
                                pacmanNumberNow++;
                                placed = true;
                            }
                            break;
                        case 2:
                            if (enemyNumberNow < enemyNumber)
                            {
                                Map[currentY, currentX] = 'A';
                                enemyNumberNow++;
                                placed = true;
                            }
                            break;
                        case 3:
                            if (energizerNumberNow < energizerNumber)
                            {
                                Map[currentY, currentX] = '@';
                                energizerNumberNow++;
                                placed = true;
                            }
                            break;
                        default:
                            Map[currentY, currentX] = '.';
                            placed = true;
                            break;
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (Map[i, j] == ' ')
                        Map[i, j] = '#';
                    Console.Write(Map[i, j]);
                }
                Console.WriteLine();
            }
            
        }

        
    }
}
