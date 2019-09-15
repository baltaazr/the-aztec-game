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
        public Item[] inventory { get; set; }

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

        public string displayStats()
        {
            return string.Format("Current Stats:\nHealth: {0}\nStrength: {1}\nSpeed: {2}\nCourage: {3}\nLuck: {4}", stats["hp"], stats["dmgmod"], stats["speed"], stats["courage"], stats["luck"]);
        }
    }
}