using System.Collections.Generic;
namespace the_aztec_game
{
    class Room
    {
        public string description { get; set; }
        public List<Item> items { get; set; }

        public int cash { get; set; }

        public Room n { get; set; }
        public Room e { get; set; }
        public Room s { get; set; }
        public Room w { get; set; }

        public Room()
        {

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