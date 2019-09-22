using System.Collections.Generic;
namespace the_aztec_game
{
    class Room
    {
        public bool deadEnd { get; set; }
        public string description { get; set; }
        public List<Item> items { get; set; }

        public int cash { get; set; }

        public Room n { get; set; }
        public Room e { get; set; }
        public Room s { get; set; }
        public Room w { get; set; }

        public Room(bool deadEndRoom = false)
        {
            if (!deadEndRoom)
            {
                n = new Room(true);
                s = new Room(true);
                e = new Room(true);
                w = new Room(true);
                items = new List<Item>();
                cash = 0;
                description = "";
                deadEnd = deadEndRoom;
            }
            deadEnd = deadEndRoom;
        }

        public (string inventoryString, string[] inventoryOptions) getStringItems()
        {
            string itemsString = "";
            string[] itemsOptions = new string[items.Count + 2];
            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                itemsString += string.Format("\n{0}. {1}", i + 1, item.name);
                itemsOptions[i] = string.Format("{0}", i + 1);
            }
            itemsString += string.Format("\n and {0} pesos.", cash);
            itemsOptions[items.Count] = "a";
            itemsOptions[items.Count + 1] = "e";
            return (itemsString, itemsOptions);
        }
    }
}