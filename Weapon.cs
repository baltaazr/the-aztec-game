using System;


namespace the_aztec_game
{
    class Weapon : Item
    {
        public double dmg { get; set; }

        public Weapon(string name, int cost, double weaponDmg) : base(name, cost)
        {
            dmg = weaponDmg;
        }

        override public double getRandDmg()
        {
            Random r = new Random();
            return (r.NextDouble() + 0.5) * dmg;
        }

        override public string getStringStats()
        {
            return string.Format(@"This weapon does {0} damage.", dmg);
        }
    }
}