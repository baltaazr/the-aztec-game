using System;
using System.Collections.Generic;

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
      double fix = Math.Pow(10, Configs.DAMAGE_PRECISION);

      return Math.Round((r.NextDouble() + 0.5) * dmg * fix) / fix;
    }

    override public string getStringStats()
    {
      return string.Format(@"This weapon does {0} damage.", dmg);
    }
    override public Dictionary<string, double> getPerks()
    {
      return new Dictionary<string, double>();
    }
  }
}