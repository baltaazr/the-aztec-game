using System;
using System.Collections.Generic;

namespace the_aztec_game
{
   class Game
   {
      private Player player;
      private Room[] templeMap;
      private List<Item> items;

      private List<Item> templeItems;
      private List<Enemy> enemies;

      public Game()
      {
         initAll();
         typewriterStyleOutput("What is your player's name?: ");
         string name = Console.ReadLine();

         typewriterStyleOutput("What is your player's occupation?: ");
         string occupation = Console.ReadLine();

         player = new Player(name, occupation);

         //             int characterPoints = 200;

         //             if (player.occupation.ToLower() == "soccer player" || player.occupation.ToLower() == "football player")
         //             {
         //                 player.stats["speed"] += 5;
         //                 typewriterStyleOutput(@"

         // Because of your great skills as a football player, you are given 5 extra points on speed!");
         //             }

         //             typewriterStyleOutput(string.Format(@"
         // Character Points: 200
         // {0}
         // There are four categories to place your character points: Health, Damage, Speed, Courage, and Luck.
         // ", player.getStringStats()));

         //             typewriterStyleOutput(@"
         // Every character point added to health adds 1 health point. 
         // How many character points would you like to spend on health?: ");
         //             int cphp = waitForInt();
         //             characterPoints -= cphp;
         //             player.stats["hp"] += cphp;

         //             typewriterStyleOutput(@"
         // Every character point added to strength adds 0.05 to the damage modifier. 
         // How many character points would you like to spend on strength?: ");
         //             int cpdm = waitForInt();
         //             characterPoints -= cpdm;
         //             player.stats["dmgmod"] += cpdm * 0.05;

         //             typewriterStyleOutput(@"
         // Every character point added to speed increases the chance of attacking first by 1%. 
         // How many character points would you like to spend on speed?: ");
         //             int cps = waitForInt();
         //             characterPoints -= cps;
         //             player.stats["speed"] += cps;

         //             typewriterStyleOutput(@"
         // Every character point added to courage increase the chance of dealing crits by 1%. 
         // How many character points would you like to spend on courage?: ");
         //             int cpc = waitForInt();
         //             characterPoints -= cpc;
         //             player.stats["courage"] += cpc;

         //             typewriterStyleOutput(@"
         // Every character point added to luck increases the chance of meeting a weaker enemy by 0.5%.
         // How many character points would you like to spend on luck?: ");
         //             int cpl = waitForInt();
         //             characterPoints -= cpl;
         //             player.stats["luck"] += cpl * 0.5;
         //             player.stats["hp"] += characterPoints;

         //             typewriterStyleOutput(string.Format("\n{0}\n", player.getStringStats()));
         //             typewriterStyleOutput(string.Format(@"
         // It is the year 1952, you have convinced a private American company that goes by the name
         // “Dart” to fund you for a trip to Mexico to investigate a mysterious aztec ruin that you saw in a
         // dream. Despite being initially hesitant about going on this quest, you have been “convinced”
         // by the Chicago mafia who want your payment. You hope that the money is enough to pay for
         // your studies while being a {0} and your debt to the Chicago Outfit, a well
         // known gang made by Al Capone.
         // ", player.occupation));
         //             typewriterStyleOutput("\n\nPress <Enter> to continue the dialogue.");
         //             Console.Read();
         //             typewriterStyleOutput(@"
         // Your great idea started one early morning in Chicago:");
         //             Console.Read();
         //             typewriterStyleOutput(@"

         // It was just like any other morning as you walked down fifth street in your work clothes. Traffic
         // blaring, and sky littered with puffs of clouds. Crowds of people in their suits and overcoats
         // stroll past you as you make your way to work.");
         //             Console.Read();

         //             typewriterStyleOutput("\nSuddenly, the noises stop.");
         //             Console.Read();
         //             typewriterStyleOutput("\nThe fedoras and the suits disappear. The streets and roads are completely empty.");
         //             Console.Read();
         //             typewriterStyleOutput("\nYou wonder what just happened, but before you know it, everything becomes dark.");
         //             Console.Read();
         //             typewriterStyleOutput(@"

         // You begin to hear the sound of bugs and realize you’re deep in a jungle. You realize you
         // are somewhere near El Mammeyal with a small village near it. The jungle pulls you in.");
         //             Console.Read();
         //             typewriterStyleOutput(@"

         // Torches light up and you see moss covered walls with vines slithered in between the cracks.
         // You look ahead and there appears to be a gigantic temple - like structure, parts of it plated in
         // gold.
         // ");
         //             Console.ReadLine();

         //             typewriterStyleOutput(@"

         // Press <Enter> to investigate.");

         //             Console.ReadLine();

         //             typewriterStyleOutput(@"

         // You have entered the center of the temple. All of a sudden, your surroundings light up and
         // everything is set ablaze. You have no way out and fear ripples throughout you.
         // ");
         //             Console.Read();
         //             int drumtime = 1500;

         //             Console.WriteLine("\nBOOM BOOM");
         //             System.Threading.Thread.Sleep(drumtime);

         //             typewriterStyleOutput("\nYou begin to hear beats of drums.\n ");
         //             System.Threading.Thread.Sleep(drumtime);

         //             Console.WriteLine("\nBOOM BOOM");
         //             System.Threading.Thread.Sleep(drumtime);

         //             typewriterStyleOutput(@"
         // They appear to be getting louder.
         // ");
         //             System.Threading.Thread.Sleep(drumtime);

         //             typewriterStyleOutput(@"

         // You feel a dribble of cold sweat slide down behind your neck.");
         //             Console.Read();
         //             typewriterStyleOutput(@"

         // Suddenly, it all becomes quiet.");
         //             Console.Read();
         //             typewriterStyleOutput(@"

         // Then you hear a voice speaking a mysterious language calling
         // to you and an insane laughter. The voices get louder and louder until… ");
         //             System.Threading.Thread.Sleep(4000);
         //             Console.WriteLine("\nRING!!!");

         //             typewriterStyleOutput(@"

         // You open your eyes and sit up on your bed. With your whole body drenched with sweat, you
         // realize you are in your bedroom– and it was all a dream. Or was it?");
         //             Console.Read();

         //             typewriterStyleOutput(string.Format(@"

         // You look besides you, and pick up the phone with dread. It was Tony Accardo, the Big boss of
         // the Chicago Outfit.

         //    Tony : {0} Do you have the money yet boy?               
         // ", player.name));
         //             System.Threading.Thread.Sleep(3000);
         //             typewriterStyleOutput(@"         
         // You : I - I’m getting it soon.");
         //             System.Threading.Thread.Sleep(2000);
         //             typewriterStyleOutput(@"

         //    Tony : I’m getting really impatient. Tell us what you need to earn this money, or it’s a bye bye.

         // In this frenzy, you realize that temple of gold in your dreams would be your way out of debt.");

         //             Console.Read();

         //             typewriterStyleOutput(@"

         // You arrive in mexico, to meet with the locals there around the location of the ruins. You have
         // 1000 pesos. There you can buy supplies that could be important to the journey. You walk into
         // a house of one of the locals, a man named Juan Perez greets you.
         // ");

         //             Console.ReadLine();
         //             int jpconvo1 = 3000;
         //             typewriterStyleOutput(string.Format(@"

         // You : My name is {0}, a {1} from America.
         // ", player.name, player.occupation));
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(string.Format(@"

         //    Juan Perez : Hello, {0}, that is a nice job, my niece works as a {1}
         //    too. So, what brings you here?            
         // ", player.name, player.occupation));
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"

         // You (Thinking about your debt to the Chicago Outfit) : I… I am here to find the ruins of the
         // nearby Aztec temple.            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"

         //    Juan Perez : How do you know of this temple? Only few people outside of this town knows of it.
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"            

         // You : I had a dream that I will find it here.            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"

         //    Juan Perez : It is interesting that you know of this ruin, but
         //    if you were to explore it, beware of the tecuanitin of the jungle.            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"            

         // You : If you already know of the ruin, why haven’t you explored it yet?            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"

         //    Juan Perez : Because of local legends surrounding the place.            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"

         // You : Alright.            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"

         //    Juan Perez : Wait… Eat this herb, it will help you against the mosquitos            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"            

         //    You took the herb from Juan Perez and ate it, it was slightly bitter, but it was okay. You felt
         //    slightly dizzy, but it was short lasting.            
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"          

         // You : How do I get there?               
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(@"

         //    Juan Perez : Remember this sequence : you go North, North, East, East, South, than West.
         // ");
         //             System.Threading.Thread.Sleep(jpconvo1);
         //             typewriterStyleOutput(string.Format(@"

         // You, thinking to yourself : Ok. I hope I remember. Although my job as a {1} did
         // not prepare me for this.
         // ", player.name, player.occupation));
         //             Console.Read();
         //             typewriterStyleOutput(@"

         // You walked away before seeing a small store that sold equipments
         // for jungle exploration, from a place called Las cosas de Daniel.

         //    What do you do?

         //       1 : Get equipments from Daniel’s

         //             or

         //       2 : Ehhh… I don’ t need Daniel’s slimy tools.
         // ");

         //             string storeChoice = waitForInput(new string[] { "1", "2" });

         //             if (storeChoice.Equals("1"))
         //             {
         //                 int danconvo1 = 2000;
         //                 typewriterStyleOutput(@"
         // You walk over to the store for the tools you need.");
         //                 System.Threading.Thread.Sleep(danconvo1);
         //                 typewriterStyleOutput(@"

         // Daniel: Hola! Who are you ?");
         //                 System.Threading.Thread.Sleep(danconvo1);
         //                 typewriterStyleOutput(string.Format(@" 

         //    You : My name is {0}, I want equipments for exploring the nearby ancient temple.
         //  ", player.name));
         //                 System.Threading.Thread.Sleep(danconvo1);
         //                 typewriterStyleOutput(@" 
         // Daniel: Sure. Here are some things you could buy.

         // Daniel brings out some things from a shack behind the house.

         // ");

         //                 showItems();
         //                 purchaseItems();
         //                 Console.Read();
         //             }
         //             typewriterStyleOutput(string.Format(@"

         // You are well equipped for this job, but now it’s time for you to gain your money and pay off
         // your debt. You say goodbye to Juan Perez {0} and head to
         // your jeep. You close the car door and continue on your way into the jungle. With the somewhat
         // vague instructions Juan Perez has given you, you follow his directions.
         // What were the direcitons?
         // (Type N for North, S for South, etc. Add spacing between each direction)", storeChoice == "1" ? "and Daniel" : ""));
         //             string answerDirections = Console.ReadLine();
         //             if (!answerDirections.ToUpper().Trim().Equals("N N E E S W"))
         //                 while (!Console.ReadLine().ToUpper().Equals("N N E E S W"))
         //                 {
         //                     player.stats["hp"] -= 5;
         //                     typewriterStyleOutput(string.Format(@"

         // You seemed to have gotten lost. You lose 5 health while trying to find the right location.
         // You're health now is {0}. Enter in the correct directions!!
         // ", player.stats["hp"]));

         //                     if (player.stats["hp"] <= 0)
         //                     {
         //                         unconscious();
         //                     }
         //                 }
         //             typewriterStyleOutput(@"
         // You finally arrived at the spot and got off your jeep.It was all so familiar, the trees, the rocks,
         // just like in your dream. There stood the gaping mouth of the gold temple, its dark mouth
         // opened wide.Vines covered the rest of the walls, leaving shiny flecks of gold showing between
         // the wood.");
         //             Console.Read();
         //             typewriterStyleOutput(string.Format(@"

         // It was just like your dream. You took a deep breath and walked towards the temple,
         // thinking about why you signed up for this. But you remember the low pay from your job as a
         // {0}, the Chicago Outfit’s threats, the mountain of debt and continued into the dark
         // esophagus of the ruins.", player.occupation));

         //             Console.ReadLine();

         typewriterStyleOutput(@"

You walk into the ruins, holding your breath, as the luxuries of the temple reveal themselves
around you. Beautiful art and vibrant color graze the walls and cieling of aztec rituals and life.
But as you watch the hallway expand behind you, you feel a gust of cold air breeze past you.
The light seemed dimmer as your torch quivers with fear. Suddenly you here a voice call out.        

Who Dares Enter the temple…

What do you respond?
");

         if (Console.ReadLine().ToLower() == "i do")
         {
            player.stats["courage"] += 2;
            typewriterStyleOutput(string.Format(@"
                
A laugh vibrates through the chambers. But instead of feeling a chill down your spine, you
suddenly gain the urge to laugh along with the voice.You gained two points to Courage.
Current Courage stats: {0}", player.stats["courage"]));
         }
         typewriterStyleOutput(@"
            
You can move around the temple using the <n, s, e and w> key, each key moving you north, south
east and west respectively. You can also type <i> to check your inventory, <st> to check your stats,
<d> to get a description of the room and <l> to look around the room.
");

         player.templeRoomLoc = 1;
         player.currentRoom = templeMap[player.templeRoomLoc];
         while (player.templeRoomLoc != 16)
         {
            string templeInput = waitForInput(new string[] { "n", "s", "e", "w", "i", "st", "d", "l" });
            switch (templeInput)
            {
               case "i":
                  (string inventoryString, string[] inventoryOptions) = player.getStringInventory();
                  typewriterStyleOutput(string.Format(@"

{0}                        
If you want more detail on any specific item, type the number next to the item
or <e> to exit the inventory menu.
", inventoryString));
                  while (true)
                  {


                     string inventoryInput = waitForInput(inventoryOptions);
                     if (inventoryInput == "e")
                     {
                        break;
                     }

                     Item itemSelected = player.inventory[Int32.Parse(inventoryInput) - 1];
                     typewriterStyleOutput(string.Format(@"
                        
{0}: {1}", itemSelected.name, itemSelected.getStringStats()));
                     if (itemSelected is Armor)
                     {
                        typewriterStyleOutput(@"
                            
Do you wish to equip this armor in place of your currently equipped armor?
<Yes / No>");
                        string armorInput = waitForInput(new string[] { "Yes", "No" });
                        if (armorInput == "Yes")
                        {
                           player.equipArmor(Int32.Parse(inventoryInput) - 1);
                        }
                     }
                  }
                  break;
               case "st":
                  typewriterStyleOutput(string.Format(@"

{0}                        
Values in parantheses are from your current armor equipped", player.getStringStats()));
                  break;
               case "d":
                  typewriterStyleOutput(string.Format(@"

{0}", player.currentRoom.description));
                  break;
               case "l":
                  if (player.currentRoom.items.Count == 0)
                  {
                     typewriterStyleOutput(@"
                            
You look around the room and appear to find nothing of value.");
                  }
                  else
                  {
                     (string itemsString, string[] itemsOption) = player.currentRoom.getStringItems();
                     typewriterStyleOutput(string.Format(@"
                            
You look around the room and appear to find:
{0}
You grab the money. To pick up all the items, press <a>.
Or press the number next to specific item you want to pick up.
Press e if you don't want to pick up any item.", itemsString));
                     player.cash += player.currentRoom.cash;
                     player.currentRoom.cash = 0;

                     string itemsInput = waitForInput(itemsOption);
                     if (itemsInput == "e")
                     {
                        break;
                     }
                     else if (itemsInput == "a")
                     {
                        player.inventory.AddRange(player.currentRoom.items);
                        player.currentRoom.items = new List<Item>();
                        break;
                     }

                     Item itemSelectedRoom = player.currentRoom.items[Int32.Parse(itemsInput) - 1];
                     player.inventory.Add(itemSelectedRoom);
                     player.currentRoom.items.RemoveAt(Int32.Parse(itemsInput) - 1);
                     break;
                  }
                  break;
               default:
                  moveRoom(templeInput);
                  break;
            }
         }





         /*typewriterStyleOutput(@"

Xolotl, falls to the ground, dying.
         ");
         Console.Read();
         typewriterStyleOutput(@"

You realize there is something off about Xolotl, as if it wasn’t actually a god. Huh.         
         ");
         Console.Read();
         typewriterStyleOutput(@"

You realize that it was just a costume. You grab the dog mask and pull it off, revealing Juan Perez’s face.                 
         ");
         Console.Read();
         typewriterStyleOutput(@"

You: What. You. Why did you do it?
         ");
         Console.Read();
         typewriterStyleOutput(@"
      

   Juan: I want all this gold for myself. I heard you were coming to find it, I gave you that hallucinogentic herbs.
   I then sent you here so I could kill you and take all your money away from everyone else. HAHAHAHAHAAHHhahah.
         ");
         Console.Read();
         typewriterStyleOutput(@"
      
You: That seems uneccassarily complicated.
         ");
         Console.Read();
         typewriterStyleOutput(string.Format(@"      

   Juan: I need my money too, {0}.     
         ", player.name));
         Console.Read();
         typewriterStyleOutput(@"

Juan lays still until he breathes his last breath.  
         ");
         Console.Read();
         typewriterStyleOutput(@"

You get up and walk out the temple, baffled. The sun never looked so bright in your life.         
         ");
         Console.Read();
         typewriterStyleOutput(@"


          |
          |   .
   `.  *  |     .'
     `. ._|_* .'  .
   . * .'   `.  *
-------|     |-------
   .  *`.___.' *  .
      .'  |* `.  *
    .' *  |  . `.
        . |
          | 
         
         ");
         Console.Read();

         typewriterStyleOutput(@"

You fly back to Chicago two days later. It was a long flight, but you finally get home to your apartment at 7:00 PM, 
exhausted from your journey. 
");
         Console.Read();
         typewriterStyleOutput(string.Format(@"

You quickly go to sleep after gobbling down a cheese burger. When you wake up from the next morning, 
you look at all the money you brought back after trading the gold for pesos, a grand total of {1}
 – way more than you could get in a four year’s work as a {0}. 
", player.occupation, player.cash));
         Console.Read();
         typewriterStyleOutput(@"

The doorbell rings. You open the door.");
         Console.Read();
         typewriterStyleOutput(@"

Two guys stand in front holding a thompson machine gun. Woah. Surprise. 

They are both from the Chicago Outfit. One of the guys you recognize is called Joe Baloney.
");
         Console.Read();
         typewriterStyleOutput(string.Format(@"

Joe: Heard ya’s back. You betta be {0}?
", player.name));
         Console.Read();
         typewriterStyleOutput(@"

   You: Yas.
");
         Console.Read();
         typewriterStyleOutput(@"

Joe: Do you have more than 5000?
");
         Console.Read();
         typewriterStyleOutput(string.Format(@"

You: I-I have {0}.
", player.cash));
         Console.Read();
         if (player.cash > 5000)
         {
            typewriterStyleOutput(@"

You: We can talk this out. Haha.
");
            Console.Read();
            typewriterStyleOutput(string.Format(@"

   Joe: G’ol’night {0}.
", player.name));
            Console.Read();
            typewriterStyleOutput(@"

Joe and the other guy point their guns at you and press the trigger.
");
            Console.Read();
         }
         else
         {
            typewriterStyleOutput(@"

   Joe: Han’em’in. Ya slinky dip.
");
            Console.Read();
            typewriterStyleOutput(@"

You give over 5000 to them, happily to be free from your debt.
");
            Console.Read();
            typewriterStyleOutput(string.Format(@"

Joe: Ya ain’t dying today, huh, {0}.
", player.name));
            Console.Read();
            typewriterStyleOutput(@"

They both walk out the door, leaving you with a big sense of joy.
");
            Console.Read();
         }
         typewriterStyleOutput(@"

The End. 
");
         Console.Read();
         typewriterStyleOutput(@"

Thanks for playing. Game created by Baltazar Zuniga, Daniel Ku, Julian Blackthorn, Ian Huang, and Min Lee. 
");*/
      }


      private void moveRoom(string dir)
      {
         switch (dir)
         {
            case "n":
               if (player.currentRoom.n.deadEnd)
               {
                  typewriterStyleOutput(@"

That way is a dead end");
                  break;
               }
               else
               {
                  player.currentRoom = player.currentRoom.n;
               }
               break;
            case "s":
               if (player.currentRoom.s.deadEnd)
               {
                  typewriterStyleOutput(@"

That way is a dead end");
                  break;
               }
               else
               {
                  player.currentRoom = player.currentRoom.s;
               }
               break;
            case "e":
               if (player.currentRoom.e.deadEnd)
               {
                  typewriterStyleOutput(@"

That way is a dead end");
                  break;
               }
               else
               {
                  player.currentRoom = player.currentRoom.e;
               }
               break;
            case "w":
               if (player.currentRoom.w.deadEnd)
               {
                  typewriterStyleOutput(@"

That way is a dead end");
                  break;
               }
               else
               {
                  player.currentRoom = player.currentRoom.w;
               }
               break;
         }

      }

      private void showItems()
      {
         int index = 1;
         foreach (var item in items)
         {

            typewriterStyleOutput(string.Format(@"
            {3}. {0} 
               Cost {1} pesos
               {2}

                              ", item.name, item.cost, item.getStringStats(), index));
            index++;
         }
      }

      private void purchaseItems()
      {

         List<string> itemNames = new List<string>();
         foreach (var item in items) itemNames.Add(item.name); //get all names
         List<string> purchasedItems = new List<string>();

         counterCheck(items, itemNames, purchasedItems);
         typewriterStyleOutput(@"
You bought: 
                  ");
         foreach (var item in items)
         {
            foreach (string purchasedItemName in purchasedItems)
               if (item.name.Equals(purchasedItemName))
               {
                  player.inventory.Add(item);
                  typewriterStyleOutput(string.Format(@"
   {0}
                  ", purchasedItemName));
               }
         }
      }

      private void counterCheck(List<Item> items, List<string> itemNames, List<string> purchasedItems)
      {
         while (true)
         {
            typewriterStyleOutput(string.Format(@"

What would you like to buy? <Enter Name> 
Cash: {0}
         ", player.cash));
            string itemName = waitForInput(itemNames.ToArray());
            Item item = findItemByName(itemName);
            if (player.cash - item.cost < 0)
            {
               typewriterStyleOutput(@"

What's that? You're out of money? Get out of my shop. 
         ");
               return;

            }

            if (!endSchoolShooting(purchasedItems, item, itemName))
            {
               typewriterStyleOutput(string.Format(@"
         
Don't buy the same of one weapon! Not a very wise choice of spending money. 

         ", itemName));
            }

            else
            {
               purchasedItems.Add(itemName);
               player.cash -= item.cost;

               typewriterStyleOutput(string.Format(@"
         
Muchas gracias for buying {0}!

         ", itemName));
            }
            typewriterStyleOutput(@"
         
Anything else? <Yes / No>

         ");
            string purchaseAnswer = waitForInput(new string[] { "Yes", "No" });
            if (purchaseAnswer.Equals("No")) return;

         }
      }

      private bool endSchoolShooting(List<string> purchasedItems, Item item, string itemName)
      {
         if (item.GetType().Equals(typeof(Weapon)))
            foreach (string purchasedItemName in purchasedItems)
               if (itemName.Equals(purchasedItemName))
                  return false;
         return true;
      }


      private Item findItemByName(string itemName)
      {
         foreach (var item in items)
            if (item.name.Equals(itemName))
               return item;

         return new Weapon("error", 0, 0);
      }


      private void combat(Enemy enemy)
      {
         typewriterStyleOutput(string.Format(@"

It seems you have encountered a hostile creature.

It seems to be a {0}, {1}.
", enemy.name, enemy.description));
         if (player.speedRollSuccess())
         {
            typewriterStyleOutput(@"

Because of your speed, you're able to deal the first move.
");
            if (playerCombatTurn(ref enemy))
            {
               typewriterStyleOutput(@"

Because of your speed, you're able to escape successfully.
");
               return;
            }
         } while (player.stats["hp"] > 0 && enemy.stats["hp"] > 0)
         {
            enemyCombatTurn(ref enemy);
            if (playerCombatTurn(ref enemy))
            {
               typewriterStyleOutput(@"

Because of your speed, you're able to escape successfully.
");
               return;
            }
         }
         if (player.stats["hp"] <= 0)
         {
            unconscious();
         }
         else
         {
            typewriterStyleOutput(@"

You're able to kill the enemy. Good job.");
         }

      }

      private bool playerCombatTurn(ref Enemy enemy)
      {
         typewriterStyleOutput(@"

What do you wish to do now?
");
         Dictionary<string, int> possibleMoves = player.getMoves();
         double dmgDealt = 0;
         int i = 1;
         List<string> intIndexToStringIndex = new List<string>();
         string[] possibleAnswers = new string[possibleMoves.Count];
         foreach (KeyValuePair<string, int> possibleMove in possibleMoves)
         {
            typewriterStyleOutput(string.Format(@"

{0}. {1}
", i, possibleMove.Key));
            intIndexToStringIndex[i] = possibleMove.Key;
            possibleAnswers[i - 1] = "" + i;
            i += 1;
         }
         int moveIndex = Int32.Parse(waitForInput(possibleAnswers));
         if (intIndexToStringIndex[moveIndex] == "Retreat")
         {
            if (player.speedRollSuccess())
            {
               return true;
            }
            else
            {
               typewriterStyleOutput(@"

You were unable to escape, seems like you weren't fast enough.
");
               return false;
            }
         }
         else if (intIndexToStringIndex[moveIndex] == "Punch")
         {
            dmgDealt = player.getRandPunchDamage();

         }
         else
         {
            dmgDealt = player.inventory[possibleMoves[intIndexToStringIndex[moveIndex]]].getRandDmg();
         }
         typewriterStyleOutput(string.Format(@"

You dealt {0} damage to the enemy. Not bad.
", dmgDealt));
         enemy.stats["hp"] -= dmgDealt;
         return false;
      }

      private void enemyCombatTurn(ref Enemy enemy)
      {
         double dmgDealt = enemy.getRandDmg();
         player.stats["hp"] -= dmgDealt;
         typewriterStyleOutput(string.Format(@"

The enemy has dealt {0} damage on you, your health is now {1}.
", dmgDealt, player.stats["hp"]));
      }

      private void unconscious()
      {
         typewriterStyleOutput(string.Format(@"

You go unconscious, and you wake up shortly after. You realize you lost {0}.
", player.cash > 2000 ? "2000 pesos" : "all your money"));
         player.unconscious();
      }
      private string waitForInput(string[] possibleAnswers, string errorMessage = "That wasn't a valid choice.\n")
      {
         while (true)
         {
            string input = Console.ReadLine();
            if (Array.Exists(possibleAnswers, ele => ele == input)) return input;
            else typewriterStyleOutput(errorMessage);
         }
      }

      private int waitForInt(string errorMessage = "Could not parse input. Please enter a valid integer: ")
      {
         while (true)
         {
            string input = Console.ReadLine();
            int actualInt;

            try
            {
               actualInt = Int32.Parse(input);
            }
            catch
            {
               typewriterStyleOutput(errorMessage);
               continue;
            }

            return actualInt;
         }
      }

      private void typewriterStyleOutput(string message)
      {
         for (int i = 0; i < message.Length; i++)
         {
            Console.Write(message[i]);
            System.Threading.Thread.Sleep(3);
            // System.Threading.Thread.Sleep(50);
         }
      }

      private void initAll()
      {
         enemies = Initializers.initEnemies();
         items = Initializers.initItems("items.json");
         templeItems = Initializers.initItems("temple-items.json");
         templeMap = Initializers.initTempleMap(templeItems);
      }
   }
}

//Room 12 dialogue
/*typewriterStyleOutput(@"

You walk down the hall that was dimly lit by fire, which was odd, considering that the temple had been abandoned for centuries. 
You feel dread crawl up your body as you slowly continue, as more paintings of a monstorus black dog in an aztec costume, covered the walls. 
");
         Console.Read();
         typewriterStyleOutput(@"

You realize you should have brought friends and rethink this plan, but then again, aztec gods are only a myth, right? 
");
         Console.Read();
         typewriterStyleOutput(string.Format(@"

Your years of studying and learning at Wilber Junior College to be a {0} proved that already. 
Suddenly, you stop in your tracks. 
", player.occupation));
         Console.Read();
         typewriterStyleOutput(@"

A giant humanoid black dog, just like the ones in the paintings, walk out from behind a pillar with an obsidian sword in hand. 

");
         Console.Read();
         typewriterStyleOutput(@"

Timiqui, 
The Dog man says as he walked forward towards you. 
");
         Console.Read();
         typewriterStyleOutput(@"

You suddenly remember the name of the god from a book you read a few years ago. A black dog god called Xolotl. 
There is no escaping, your only way out is to fight.
");
         Console.Read();
         typewriterStyleOutput(@"

Xolotl runs toward you, swift as shadow, gliding across the stones. You step back, dropping your torch...
");
         Console.Read();
         typewriterStyleOutput(@"

...but before you can do anything you feel the black obsidian blade slide into your stomach like a hot knife through butter. 
You feel as if the blade has drained your body of energy as you slide on the floor. 
");
         Console.Read();
         typewriterStyleOutput(@"

The Aztec god stands in front of you for a second before rummaging through your bag for money. 
");
         Console.Read();
         typewriterStyleOutput(@"

You watch in silence as Xolotl takes all the gold and the rest of your cash before walking away.
");
         Console.Read();

         typewriterStyleOutput(@"

You: Is this the end?
         ");
         Console.Read();

         typewriterStyleOutput(@"

You thought of the last words you want to say. What are they?
         ");
         string lastWords = Console.ReadLine();
         typewriterStyleOutput(string.Format(@"

You: {0}.
         ", lastWords));
         Console.Read();
         typewriterStyleOutput(@"

Just as you feel weaker, a small glowing light appear in front of you. 
It turns into a fiery warmth that spreads through the dead cold temple. 
The fire materializes into a red man with a glowing fire serpent on his back and feather tufts on each side. 
         ");
         Console.Read();
         typewriterStyleOutput(string.Format(@"

You: {0}. Who are you?
         ", lastWords.ToUpper()));
         Console.Read();
         typewriterStyleOutput(@"

The Red Man: I am Xiuhtecuhtli. And I will help just a wrong.
         ");
         Console.Read();
         typewriterStyleOutput(@"

He walks over and touches your forehead, giving you warmth throughout your body. You feel your wound heal itself and feel stronger than before. 
         ");
         Console.Read();
         typewriterStyleOutput(string.Format(@"

You increased your health by {0}
You increased your Damage by {0}
         ", (player.stats["hp"] / 2), (player.stats["dmgmod"] / 2)));
         player.stats["hp"] *= 1.5;
         player.stats["dmgmod"] *= 1.5;

         typewriterStyleOutput(string.Format(@"

{2}
         ", player.getStringStats()));
         Console.Read();
         typewriterStyleOutput(@"

You thank Xiuhtecuhtli, but he disappears mid-thank. You aren't sure what just happened, but you definitley feel re-energized.
You can go forwards or backwards. Where will you go?
         ");
         Console.Read(); */
