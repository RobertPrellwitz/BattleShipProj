using System;
namespace BattleShip
{
    public class Control
    {
       //public GameBoard testGame;
        public Player player1;
        public Array tester;

        public Control()
        {
            Console.WriteLine("test");

            //testGame = new GameBoard();
            player1 = new Player();
            
        }

        public void sample()
        {
            
            tester = player1.gameBoard.PlayerBoard();
            player1.PositionShip(player1.submarine);
            player1.CheckPosition(player1.submarine, tester);
            player1.SetPosition(player1.submarine, tester);
            player1.gameBoard.PrintBoard(tester);
            player1.PositionShip(player1.destroyer);
            player1.CheckPosition(player1.destroyer, tester);
            player1.SetPosition(player1.destroyer, tester);
            player1.gameBoard.PrintBoard(tester);
            player1.PositionShip(player1.carrier);
            player1.CheckPosition(player1.carrier, tester);
            player1.SetPosition(player1.carrier, tester);
            player1.gameBoard.PrintBoard(tester);
        }



    


    }

}
