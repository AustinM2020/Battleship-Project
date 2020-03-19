using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Boards
    {
        public char coords;
        public int[,] board;
        public void MakeBoard()
        {
            coords = 'A';
            board = new int[21, 21];
            int rowLength = board.GetLength(0);
            int colHeight = board.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colHeight; j++)
                {
                    if (j == 0 && i < 10)
                    {
                        Console.Write(i + "  ");
                    }
                    else if (j == 0 && i > 9)
                    {
                        Console.Write(i + " ");
                    }
                    else if (i == 0 && j > 0)
                    {
                        Console.Write(coords + " ");
                        coords++;
                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");                    
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
