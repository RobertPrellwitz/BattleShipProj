using System;
using System.Collections.Generic;
namespace BattleShip
{
    public class GameBoard
    {
        int x;
        int y;
        char[,] board;

        public GameBoard()
        {
            board = new char[x, y];
        }



        public Array PlayerBoard()
        {
            int x = 20; int y = 20;
           
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    board[x, y] = 'O';

                }
            }
            return board;

        }
    }
}
