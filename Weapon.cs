using System;


namespace the_aztec_game
{
   class Weapon : Item
   {
      public double dmg { get; set; }

      public Weapon(string name, int cost, string benefitCategory, int benefitValue) : base(name, cost, benefitCategory, benefitValue)
      {

      }

      override public double getRandDmg()
      {
         Random r = new Random();
         return (r.NextDouble() + 0.5) * dmg;
      }
   }
}