using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 5),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(),
            };

            (unit[0] as MilitaryUnit).Attack(units[1]);

            (unit[0] as MilitaryUnit).Attack(unit[2]);

            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }
        }
    }
}
