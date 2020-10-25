using System;
namespace BattleShip
{
    public class Control
    {
       public GameBoard testGame;

        public Control()
        {
            Console.WriteLine("test");

            testGame = new GameBoard();


            testGame.PlayerBoard();
            testGame.PrintBoard();

        }

        public void sample()
        {
            testGame.PlayerBoard();
            testGame.PrintBoard();
        }



    


    }

}
