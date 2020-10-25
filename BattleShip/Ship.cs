using System;
using System.Collections.Generic;

namespace BattleShip
{
    public abstract class Ship

    {
        public string name;
        public int size;
        public List<(int, int)> position;

        public Ship()
        {
        }
    }

    public class Destroyer: Ship
    {
        public Destroyer()
        {
            name = "Destroyer";
            size = 2;

        }
       

    }

    public class Submarine : Ship
    {
        public Submarine()
        {
            name = "Submanrine";
            size = 3;

        }
    }
}
