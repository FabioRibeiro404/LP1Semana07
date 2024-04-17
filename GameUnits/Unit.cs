using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health; 
        }

        public virtual int Health()
        {
            return health;
        }

        public void Move()
        {

        }

    }
}