using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace the_aztec_game
{
   class Initializers
   {
      public static Room[] initTempleMap(List<Item> items)
      {
         Room[] templeMap = new Room[17];
         using (StreamReader r = new StreamReader("map.json"))
         {

            string json = r.ReadToEnd();
            Dictionary<string, dynamic> d = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            foreach (var room in d)
            {
               templeMap[Int32.Parse(room.Key)] = new Room();
               templeMap[Int32.Parse(room.Key)].description = (room.Value.description.ToString());
               templeMap[Int32.Parse(room.Key)].cash = Int32.Parse(room.Value.cash.ToString());
               for (int i = 0; i < room.Value.items.Count; i++)
               {
                  templeMap[Int32.Parse(room.Key)].items.Add(items[room.Value.items[i]]);
               }
            }

            foreach (var room in d)
            {
               if (room.Value.ContainsKey("n"))
               {
                  templeMap[Int32.Parse(room.Key)].n = templeMap[Int32.Parse(room.Value.n.ToString())];
               }
               if (room.Value.ContainsKey("s"))
               {
                  templeMap[Int32.Parse(room.Key)].s = templeMap[Int32.Parse(room.Value.s.ToString())];
               }
               if (room.Value.ContainsKey("e"))
               {
                  templeMap[Int32.Parse(room.Key)].e = templeMap[Int32.Parse(room.Value.e.ToString())];
               }
               if (room.Value.ContainsKey("w"))
               {
                  templeMap[Int32.Parse(room.Key)].w = templeMap[Int32.Parse(room.Value.w.ToString())];
               }
            }
         }
         return templeMap;
      }
      public static List<Enemy> initEnemies()
      {
         List<Enemy> enemies = new List<Enemy>();
         using (StreamReader r = new StreamReader("monsters.json"))
         {
            string json = r.ReadToEnd();
            Dictionary<string, dynamic> jsonMonsters = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            foreach (var jsonMonster in jsonMonsters)
            {
               var monsterValue = jsonMonster.Value;
               Dictionary<string, double> monsterStats = new Dictionary<string, double>();
               monsterStats.Add("hp", Convert.ToDouble(Int32.Parse(monsterValue.hp.ToString())));
               monsterStats.Add("damage", Convert.ToDouble(Int32.Parse(monsterValue.damage.ToString())));
               monsterStats.Add("speed", Convert.ToDouble(Int32.Parse(monsterValue.speed.ToString())));
               monsterStats.Add("courage", Convert.ToDouble(Int32.Parse(monsterValue.courage.ToString())));

               Enemy monster = new Enemy(monsterValue.name.ToString(), monsterValue.description.ToString(), monsterStats);
               enemies.Add(monster);

            }
         }
         return enemies;
      }

      public static List<Item> initItems(string jsonFilename)
      {
         List<Item> items = new List<Item>();
         using (StreamReader r = new StreamReader(jsonFilename))
         {
            string json = r.ReadToEnd();
            Dictionary<string, dynamic> jsonItems = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            foreach (var jsonItem in jsonItems)
            {
               var itemValue = jsonItem.Value;
               string itemClass = itemValue.type;
               switch (itemClass)
               {
                  case "Weapon":
                     Weapon weapon = new Weapon(itemValue.name.ToString(), Int32.Parse(itemValue.cost.ToString()), Convert.ToDouble(Int32.Parse(itemValue.dmg.ToString())));
                     items.Add(weapon);
                     break;
                  case "Armor":
                     Dictionary<string, double> armorPerks = JsonConvert.DeserializeObject<Dictionary<string, double>>(itemValue.perks.ToString());
                     Armor armor = new Armor(itemValue.name.ToString(), Int32.Parse(itemValue.cost.ToString()), armorPerks);
                     items.Add(armor);
                     break;
                  case "Consumable":
                     Dictionary<string, double> consumablePerks = JsonConvert.DeserializeObject<Dictionary<string, double>>(itemValue.perks.ToString());
                     Consumable consumable = new Consumable(itemValue.name.ToString(), Int32.Parse(itemValue.cost.ToString()), consumablePerks);
                     items.Add(consumable);
                     break;
                  default:
                     Console.WriteLine("Item initialization error");
                     break;
               }
            }
         }
         return items;
      }
   }
}