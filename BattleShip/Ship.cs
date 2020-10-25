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
            name = "Submarine";
            size = 3;

        }
    }
    public class BattleShip : Ship
    {
        public BattleShip()
        {
            name = "Battleship";
            size = 4;

        }
    }
    public class AirCraftCarrier : Ship
    {
        public AirCraftCarrier()
        {
            name = "AirCraftCarier";
            size = 5;

        }
    }
}
