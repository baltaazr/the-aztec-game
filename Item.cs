namespace the_aztec_game
{
    abstract class Item
    {
        public string name { get; set; }
        public string description { get; set; }
        public Item(string itemName, string itemDescription)
        {
            name = itemName;
            description = itemDescription;
        }

        public abstract double getRandDmg();
    }
}