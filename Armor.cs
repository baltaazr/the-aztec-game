using System;
using System.Collections.Generic;

namespace the_aztec_game
{
   class Armor : Item
   {
      public Dictionary<string, double> perks { get; set; }

      public Armor(string name, int cost, string benefitCategory, int benefitValue) : base(name, cost, benefitCategory, benefitValue)
      {

      }

      override public double getRandDmg()
      {
         return 0;
      }
   }
}