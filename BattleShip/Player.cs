using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BattleShip
{
    public class Player
    {
        // member Variables 
        int x; int y;
        public string name;
        public int ships;
        public List<Ship> fleet;
        public GameBoard gameBoard;
       // public GameBoard opponentBoard;
        public Submarine submarine;
        public BattleShip battleShip;
        public AirCraftCarrier carrier;
        public Destroyer destroyer;
        
        public Player()
        { // Constructor
            
            gameBoard = new GameBoard();
            
            submarine = new Submarine();
            destroyer = new Destroyer();

           
            

        }

        

        public void PositionShip(Ship ship)
        { // 1 = horizontal 2 = vertical
           
            {
                for (int i = 0; i < ship.size; i++)
                {
                    int choicex;
                    int choicey;
                    Console.WriteLine("\nInput the x Coordinate:\n");
                    bool checkx = Int32.TryParse(Console.ReadLine(), out choicex);
                    Console.WriteLine("Input the y Coordinate:\n");
                    bool checky = Int32.TryParse(Console.ReadLine(), out choicey);
                    ship.position.Add((choicex, choicey));
                }
            }

        }

        public bool CheckPosition(Ship ship, Array gameBoard)
        {
            bool check = true;
            int i = 0;
            while (i < ship.size) 
            {
                (int x, int y) = ship.position[i];

                if ((char)gameBoard.GetValue(x, y) != 'O') ;
                {
                        check = false;
                        break;
                }
                i++;
            }
            return check;

        }
        public void SetPosition(Ship ship, Array gameBoard)
        {
            for (int i = 0; i < ship.size; i++)
            {
                (int x, int y) = ship.position[i];
                gameBoard.SetValue('S', x, y);
            }
        }



    }

   
}
