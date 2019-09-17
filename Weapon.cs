using System;


namespace the_aztec_game
{
    class Weapon : Item
    {
        public double dmg { get; set; }

        public Weapon(string name, string description) : base(name, description)
        {

        }

        override public double getRandDmg()
        {
            Random r = new Random();
            return (r.NextDouble() + 0.5) * dmg;
        }
    }
}