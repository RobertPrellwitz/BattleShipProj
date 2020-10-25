using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BattleShip
{
    public class GameBoard
    {
        int x;
        int y;
        char[,] board;

        public GameBoard()
        {
            x = 20;
            y = 20;
           board = new char[x,y];
        }

       

        public Array PlayerBoard()
        {
            //int x = 4; int y = 4;
           
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    board[i,j] = 'O';

                }
            }
            return board;

        }
        public void PrintBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i,j]);
                }
            }
        }
    }
}
