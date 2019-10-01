using System.Collections.Generic;
namespace the_aztec_game
{
    abstract class Item
    {
        public string name { get; set; }
        public int cost { get; set; }

        public string image { get; set; }
        public Item(string itemName, int itemCost, string itemImage)
        {
            name = itemName;
            cost = itemCost;
            image = itemImage;
        }

        public abstract double getRandDmg();

        public abstract string getStringStats();

        public abstract Dictionary<string, double> getPerks();
    }
}