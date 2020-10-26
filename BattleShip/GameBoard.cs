using System;
using System.Collections.Generic;
using System.Dynamic;
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
            char[,] create = new char[x,y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                   create[i,j] = 'O';
                }
            }
            return create;

        }
        public void PrintBoard(Array array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array.GetValue(i, j));
                }
            }
        }

        public Array PlayerBoardII()
        {
            //char[,] board = new char[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    board[i, j] = 'O';
                }
            }
            return board;

        }

        public void PrintBoardII()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
            }
        }
    }
}
