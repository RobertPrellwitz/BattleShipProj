using System;
using System.Collections.Generic;

namespace BattleShip
{
    public abstract class Ship

    {
        public string name;
        public Array size;

        public Ship()
        {
        }
    }

    public class Destroyer: Ship
    {
        public Destroyer()
        {
            name = "Destroyer";
            char[,] array = new char[1, 1];

        }
       

    }

    public class Submarine : Ship
    {
        public Submarine()
        {
            name = "Submanrine";

        }
    }
}
