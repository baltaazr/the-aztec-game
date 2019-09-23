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

    public Item equippedArmor { get; set; }

    public Room currentRoom { get; set; }

    private int punchDmg = 10;

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
      equippedArmor = new Armor("T-shirt", 0, new Dictionary<string, double>() { { "hp", 0.0 }, { "dmgmod", 0.0 }, { "speed", 0.0 }, { "courage", 0.0 }, { "luck", 0.0 } });
      inventory = new List<Item>();
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
      Dictionary<string, double> statsWArmor = new Dictionary<string, double>();
      statsWArmor["hp"] = stats["hp"] + equippedArmor.getPerks()["hp"];
      statsWArmor["dmgmod"] = stats["dmgmod"] + equippedArmor.getPerks()["dmgmod"];
      statsWArmor["speed"] = stats["speed"] + equippedArmor.getPerks()["speed"];
      statsWArmor["courage"] = stats["courage"] + equippedArmor.getPerks()["courage"];
      statsWArmor["luck"] = stats["luck"] + equippedArmor.getPerks()["luck"];
      return statsWArmor;
    }

    public string stringValOfStat(string stat)
    {
      return equippedArmor.getPerks()[stat] != 0 ? string.Format("{0} (+{1})", stats[stat], equippedArmor.getPerks()[stat]) : string.Format("{0}", stats[stat]);
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
      double fix = Math.Pow(10, Configs.DAMAGE_PRECISION);

      return Math.Round((r.NextDouble() + 0.5) * punchDmg * fix) / fix;
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
      string inventoryString = "You have:";
      string[] inventoryOptions = new string[inventory.Count + 1];
      for (int i = 0; i < inventory.Count; i++)
      {
        Item item = inventory[i];

        inventoryString += string.Format("\n{0}. {1}", i + 1, item.name);
        if (item == equippedArmor)
        {
          inventoryString += " (equipped)";
        }
        inventoryOptions[i] = string.Format("{0}", i + 1);
      }
      if (inventory.Count == 0) inventoryString += "\n nothing so far";
      inventoryString += string.Format("\n and {0} pesos.", cash);
      inventoryOptions[inventory.Count] = "e";
      return (inventoryString, inventoryOptions);
    }

    public void equipArmor(int indexOfArmor)
    {
      equippedArmor = inventory[indexOfArmor];
    }

    public void consumeConsumable(int indexOfConsumable)
    {
      Item consumable = inventory[indexOfConsumable];
      inventory.RemoveAt(indexOfConsumable);
      stats["hp"] += consumable.getPerks()["hp"];
      stats["dmgmod"] += consumable.getPerks()["dmgmod"];
      stats["speed"] += consumable.getPerks()["speed"];
      stats["courage"] += consumable.getPerks()["courage"];
      stats["luck"] += consumable.getPerks()["luck"];
    }
  }
}