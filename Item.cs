namespace the_aztec_game
{
   abstract class Item
   {
      public string name { get; set; }

      public int cost { get; set; }

      public string benefitCategory { get; set; }
      public int benefitValue { get; set; }

      public Item(string itemName, int itemCost, string itemCategory, int itemValue)
      {
         name = itemName;
         cost = itemCost;
         benefitCategory = itemCategory;
         benefitValue = itemValue;

      }

      public abstract double getRandDmg();
   }
}