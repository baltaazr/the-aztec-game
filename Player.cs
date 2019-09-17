using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace the_aztec_game
{
   class Player
   {
      public string name { get; set; }

      public string occupation { get; set; }
      public Dictionary<string, double> stats { get; set; }
      public List<Item> inventory { get; set; }

      private int punchDmg;

      public Player(string playerName, string playerOccupation)
      {
         name = playerName;
         occupation = playerOccupation;
         stats = new Dictionary<string, double>();
         stats["hp"] = 40;
         stats["dmgmod"] = 1;
         stats["speed"] = 5;
         stats["courage"] = 0;
         stats["luck"] = 40;
      }

      public string getStats()
      {
         return string.Format(@"Current Stats:
  Health: {0}
  Strength: {1}
  Speed: {2}
  Courage: {3}
  Luck: {4}", stats["hp"], stats["dmgmod"], stats["speed"], stats["courage"], stats["luck"]);
      }

      public Dictionary<string, int> getMoves()
      {
         Dictionary<string, int> possibleMoves = new Dictionary<string, int>();
         possibleMoves["Punch"] = -1;
         possibleMoves["Retreat"] = -1;
         for (int i = 0; i < inventory.Count; i++)
         {
            Item item = inventory[i];
            if (item is Weapon)
            {
               possibleMoves[string.Format("Use {0}", item.name)] = i;
            }

         }
         return possibleMoves;
      }

      public bool speedRollSuccess()
      {
         Random r = new Random();
         return r.NextDouble() < stats["speed"] * 0.01;
      }

      public double getRandPunchDamage()
      {
         Random r = new Random();
         return (r.NextDouble() + 0.5) * punchDmg;
      }
   }
}