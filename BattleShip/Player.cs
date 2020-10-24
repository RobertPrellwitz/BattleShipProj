using System;
using System.Collections.Generic;


namespace BattleShip
{
    public abstract class Player
    {
        public string name;
        public int ships;
       
        public Player()
        {
        }

    }

    public class Player1 : Player
    {
        public Player1()
        {
            name = "Player 1";
            ships = 5;
        }
    }

    public class Player2 : Player
    {
        public Player2()
        {
            name = "Player 2";
            ships = 5;
        }
    }
}
