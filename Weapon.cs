using System;


namespace the_aztec_game
{
   class Weapon : Item
   {
      public double dmg { get; set; }
      public double stamina { get; set; }

      public Weapon()
      {

      }

      override public double getRandDmg()
      {
         Random r = new Random();
         return (r.NextDouble() + 0.5) * dmg;
      }
   }
}