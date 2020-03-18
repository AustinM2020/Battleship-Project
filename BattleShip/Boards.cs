using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Boards
    {
        public int[,] board;
        public void MakeBoard()
        {
            board = new int[20, 20];
            int rowLength = board.GetLength(0);
            int colHeight = board.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colHeight; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
