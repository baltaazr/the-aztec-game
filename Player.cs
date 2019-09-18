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

        public Armor equippedArmor { get; set; }

        private int punchDmg;

        public int cash { get; set; }

        public int templeRoomLoc { get; set; }

        public Player(string playerName, string playerOccupation)
        {
            name = playerName;
            occupation = playerOccupation;
            cash = 1000;
            stats = new Dictionary<string, double>();
            stats["hp"] = 40;
            stats["dmgmod"] = 1;
            stats["speed"] = 5;
            stats["courage"] = 0;
            stats["luck"] = 40;
        }

        public string getStringStats()
        {
            return string.Format(@"Current Stats:
  Health: {0}
  Strength: {1}
  Speed: {2}
  Courage: {3}
  Luck: {4}", stringValOfStat("hp"), stringValOfStat("dmgmod"), stringValOfStat("speed"), stringValOfStat("courage"), stringValOfStat("luck"));
        }

        public Dictionary<string, double> getStatsWArmor()
        {
            statsWArmor = new Dictionary<string, double>();
            statsWArmor["hp"] = stats["hp"] + equippedArmor.perks["hp"];
            statsWArmor["dmgmod"] = stats["dmgmod"] + equippedArmor.perks["dmgmod"];
            statsWArmor["speed"] = stats["speed"] + equippedArmor.perks["speed"];
            statsWArmor["courage"] = stats["courage"] + equippedArmor.perks["courage"];
            statsWArmor["luck"] = stats["luck"] + equippedArmor.perks["luck"];
            return statsWArmor;
        }

        public string stringValOfStat(string stat)
        {
            return equippedArmor.perks[stat] != 0 ? string.Format("{0} (+{1})", stats[stat], equippedArmor.perks[stat]) : string.Format("{0}", stats[stat]);
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

        public void unconscious()
        {
            stats["hp"] = 40;
            if (cash <= 2000)
            {
                cash = 0;
            }
            else
            {
                cash -= 2000;
            }
        }

        public (string inventoryString, string[] inventoryOptions) getStringInventory()
        {
            string inventoryString = "You have a:";
            string[] inventoryOptions = new string[inventory.Count + 1];
            for (int i = 0; i < inventory; i++)
            {
                Item item = inventory[i];
                inventoryString += string.Format("\n{0}. {1}", i + 1, item.name + item == equippedArmor ? " (equipped)" : "");
                inventoryOptions[i] = string.Format("{0}", i + 1);
            }
            inventoryString += string.Format("\n and {0} pesos.", cash);
            inventoryOptions[inventory.Count] = "e";
            return (inventoryString, inventoryOptions);
        }

        public void equipArmor(int indexOfArmor)
        {
            equippedArmor = inventory[indexOfArmor];
        }
    }
}