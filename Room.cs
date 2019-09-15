namespace the_aztec_game
{
    class Room
    {
        public string description { get; set; }
        public Item[] items { get; set; }

        public Room n { get; set; }
        public Room e { get; set; }
        public Room s { get; set; }
        public Room w { get; set; }

        public Room()
        {

        }
    }
}