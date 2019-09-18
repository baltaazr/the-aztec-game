namespace the_aztec_game
{
    class Room
    {
        public string description { get; set; }
        public List<Item> items { get; set; }

        public double cash { get; set; }

        public Room n { get; set; }
        public Room e { get; set; }
        public Room s { get; set; }
        public Room w { get; set; }

        public Room()
        {

        }

        public string getStringItems()
        {
            string itemsString = "";
            string[] itemsOptions = new string[items.Count + 2];
            for (int i = 0; i < items; i++)
            {
                Item item = items[i];
                itemsString += string.Format("\n{0}. {1}", i + 1, item.name);
                inventoryOptions[i] = string.Format("{0}", i + 1);
            }
            inventoryString += string.Format("\n and {0} pesos.", cash);
            inventoryOptions[inventory.Count] = "a";
            inventoryOptions[inventory.Count + 1] = "e";
            return (inventoryString, inventoryOptions);
        }
    }
}