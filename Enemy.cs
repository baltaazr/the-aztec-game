using System;

using System.Collections.Generic;

namespace the_aztec_game
{
    class Enemy
    {
        public string name { get; set; }
        public string description { get; set; }

        public Dictionary<string, double> stats { get; set; }
        public Enemy()
        {

        }
        public double getRandDmg()
        {
            Random r = new Random();
            return (r.NextDouble() + 0.5) * stats["dmg"];
        }
    }
}