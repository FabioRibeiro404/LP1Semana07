using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        private static int cost = 5;

        public SettlerUnit(int movement, int health) : base(movement, health)
        {
            mov = 1;
            health = 2;
        }

        public int GetCost()
        {
            return cost;
        } 
    }
}