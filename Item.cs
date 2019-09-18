namespace the_aztec_game
{
    abstract class Item
    {
        public string name { get; set; }
        public int cost { get; set; }
        public Item(string itemName, int itemCost)
        {
            name = itemName;
            cost = itemCost;
        }

        public abstract double getRandDmg();

        public abstract string getStringStats();
    }
}