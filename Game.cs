using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace the_aztec_game
{
   class Game
   {
      private Room[] templeMap = new Room[17];
      private Player player;

      private List<Item> items = new List<Item>();

      public Game()
      {
         typewriterStyleOutput("What is your player's name?: ");
         string name = Console.ReadLine();

         typewriterStyleOutput("What is your player's occupation?: ");
         string occupation = Console.ReadLine();

         player = new Player(name, occupation);

         int characterPoints = 200;

         typewriterStyleOutput(string.Format(@"
Character Points: 200
{0}
There are four categories to place your character points: Health, Damage, Speed, Courage, and Luck.
", player.getStats()));

         typewriterStyleOutput(@"
Every character point added to health adds 1 health point. 
How many character points would you like to spend on health?: ");
         int cphp = waitForInt();
         characterPoints -= cphp;
         player.stats["hp"] += cphp;
         player.maxhp = player.stats["hp"];

         typewriterStyleOutput(@"
Every character point added to strength adds 0.05 to the damage modifier. 
How many character points would you like to spend on strength?: ");
         int cpdm = waitForInt();
         characterPoints -= cpdm;
         player.stats["dmgmod"] += cpdm * 0.05;

         typewriterStyleOutput(@"
Every character point added to speed increases the chance of attacking first by 1%. 
How many character points would you like to spend on speed?: ");
         int cps = waitForInt();
         characterPoints -= cps;
         player.stats["speed"] += cps;

         typewriterStyleOutput(@"
Every character point added to courage increase the chance of dealing crits by 1%. 
How many character points would you like to spend on courage?: ");
         int cpc = waitForInt();
         characterPoints -= cpc;
         player.stats["courage"] += cpc;

         typewriterStyleOutput(@"
Every character point added to luck increases the chance of meeting a weaker enemy by 0.5%.
How many character points would you like to spend on luck?: ");
         int cpl = waitForInt();
         characterPoints -= cpl;
         player.stats["luck"] += cpl * 0.5;
         player.stats["hp"] += characterPoints;

         typewriterStyleOutput(string.Format("\n{0}\n", player.getStats()));
         typewriterStyleOutput(string.Format(@"
It is the year 1952, you have convinced a private American company that goes by the name
“Dart” to fund you for a trip to Mexico to investigate a mysterious aztec ruin that you saw in a
dream. Despite being initially hesitant about going on this quest, you have been “convinced”
by the Chicago mafia who want your payment. You hope that the money is enough to pay for
your studies while being a {0} and your debt to the Chicago Outfit, a well
known gang made by Al Capone.
", player.occupation));
         typewriterStyleOutput("\n\nPress <Enter> to continue the dialogue.");
         Console.Read();
         typewriterStyleOutput(@"
Your great idea started one early morning in Chicago:");
         Console.Read();
         typewriterStyleOutput(@"

It was just like any other morning as you walked down fifth street in your work clothes. Traffic
blaring, and sky littered with puffs of clouds. Crowds of people in their suits and overcoats
stroll past you as you make your way to work.");
         Console.Read();

         typewriterStyleOutput("\nSuddenly, the noises stop.");
         Console.Read();
         typewriterStyleOutput("\nThe fedoras and the suits disappear. The streets and roads are completely empty.");
         Console.Read();
         typewriterStyleOutput("\nYou wonder what just happened, but before you know it, everything becomes dark.");
         Console.Read();
         typewriterStyleOutput(@"

You begin to hear the sound of bugs and realize you’re deep in a jungle. You realize you
are somewhere near El Mammeyal with a small village near it. The jungle pulls you in.");
         Console.Read();
         typewriterStyleOutput(@"

Torches light up and you see moss covered walls with vines slithered in between the cracks.
You look ahead and there appears to be a gigantic temple - like structure, parts of it plated in
gold.
");
         Console.ReadLine();

         typewriterStyleOutput(@"
         
Press <Enter> to investigate.");

         Console.ReadLine();

         typewriterStyleOutput(@"

You have entered the center of the temple. All of a sudden, your surroundings light up and
everything is set ablaze. You have no way out and fear ripples throughout you.
");
         Console.Read();
         int drumtime = 1500;

         Console.WriteLine("\nBOOM BOOM");
         System.Threading.Thread.Sleep(drumtime);

         typewriterStyleOutput("\nYou begin to hear beats of drums.\n ");
         System.Threading.Thread.Sleep(drumtime);

         Console.WriteLine("\nBOOM BOOM");
         System.Threading.Thread.Sleep(drumtime);

         typewriterStyleOutput(@"
They appear to be getting louder.
");
         System.Threading.Thread.Sleep(drumtime);

         typewriterStyleOutput(@"

You feel a dribble of cold sweat slide down behind your neck.");
         Console.Read();
         typewriterStyleOutput(@"

Suddenly, it all becomes quiet.");
         Console.Read();
         typewriterStyleOutput(@"
         
Then you hear a voice speaking a mysterious language calling
to you and an insane laughter. The voices get louder and louder until… ");
         System.Threading.Thread.Sleep(4000);
         Console.WriteLine("\nRING!!!");

         typewriterStyleOutput(@"
         
You open your eyes and sit up on your bed. With your whole body drenched with sweat, you
realize you are in your bedroom– and it was all a dream. Or was it?");
         Console.Read();

         typewriterStyleOutput(string.Format(@"
            
You look besides you, and pick up the phone with dread. It was Tony Accardo, the Big boss of the Chicago Outfit and the person you are in debt to after paying too much money for college to be a {0}

   Tony : Do you have the money yet boy?               
", player.occupation));
         System.Threading.Thread.Sleep(3000);
         typewriterStyleOutput(@"         
You : I - I’m getting it soon.");
         System.Threading.Thread.Sleep(2000);
         typewriterStyleOutput(@"

   Tony : I’m getting really impatient. Tell us what you need to earn this money, or it’s a bye bye.

In this frenzy, you realize that temple of gold in your dreams would be your way out of debt.");

         Console.Read();

         typewriterStyleOutput(@"

You arrive in mexico, to meet with the locals there around the location of the ruins. You have
1000 pesos. There you can buy supplies that could be important to the journey. You walk into
a house of one of the locals, a man named Juan Perez greets you.
");

         Console.ReadLine();
         int jpconvo1 = 3000;
         typewriterStyleOutput(string.Format(@"

You : My name is {0}, a {1} from America.
", player.name, player.occupation));
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(string.Format(@"
            
   Juan Perez : Hello, {0}, that is a nice job, my niece works as a {1}
   too. So, what brings you here?            
", player.name, player.occupation));
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"

You (Thinking about your debt to the Chicago Outfit) : I… I am here to find the ruins of the
nearby Aztec temple.            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"
            
   Juan Perez : How do you know of this temple? Only few people outside of this town knows of it.
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"            
            
You : I had a dream that I will find it here.            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"
              
   Juan Perez : It is interesting that you know of this ruin, but
   if you were to explore it, beware of the tecuanitin of the jungle.            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"            
            
You : If you already know of the ruin, why haven’t you explored it yet?            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"
            
   Juan Perez : Because of local legends surrounding the place.            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"

You : Alright.            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"
            
   Juan Perez : Wait… Eat this herb, it will help you against the mosquitos            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"            

   You took the herb from Juan Perez and ate it, it was slightly bitter, but it was okay. You felt
   slightly dizzy, but it was short lasting.            
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"          

You : How do I get there?               
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(@"
            
   Juan Perez : Remember this sequence : you go North, North, East, East, South, than West.
");
         System.Threading.Thread.Sleep(jpconvo1);
         typewriterStyleOutput(string.Format(@"
            
You, thinking to yourself : Ok. I hope I remember. Although my job as a {1} did
not prepare me for this.
", player.name, player.occupation));

         Console.Read();
         typewriterStyleOutput(@"

You walked away before seeing a small store that sold equipments
for jungle exploration, from a place called Las cosas de Daniel.

   What do you do?

      1 : Get equipments from Daniel’s

            or

      2 : Ehhh… I don’ t need Daniel’s slimy tools.
");


         string store_choice = waitForInput(new string[] { "1", "2" });

         if (store_choice.Equals("1"))
         {
            int danconvo1 = 2000;
            typewriterStyleOutput(@"


You walk over to the store for the tools you need.");
            System.Threading.Thread.Sleep(danconvo1);
            typewriterStyleOutput(@"
            
Daniel: Hola! Who are you ?");
            System.Threading.Thread.Sleep(danconvo1);
            typewriterStyleOutput(string.Format(@" 

   You : My name is {0}, I want equipments for exploring the nearby ancient temple.
 ", player.name));
            System.Threading.Thread.Sleep(danconvo1);
            typewriterStyleOutput(@" 

Daniel: Sure. Here are some things you could buy.

Daniel brings out some things from a shack behind the house.");

            initItems();
            showItems();


            typewriterStyleOutput(string.Format(@"

You are well equipped for this job, but now it’s time for you to gain your money and pay off
your debt. You say goodbye to Juan Perez {0}and head to
your jeep. You close the car door and continue on your way into the jungle. With the somewhat
vague instructions Juan Perez has given you, you follow his directions.
What were the direcitons?
(Type N for North, S for South, etc. Add spacing between each direction)", store_choice.Equals("1") ? "and Daniel" : ""));
            while (!Console.ReadLine().Equals("N N E E S W"))
            {
               typewriterStyleOutput(string.Format(@"

You seemed to have gotten lost. You lose 5 health while trying to find the right location.
You're health now is {0}.
", player.stats["hp"]));
               if (player.stats["hp"] <= 0)
               {
                  unconscious();
               }
            }
            typewriterStyleOutput(string.Format(@"
                
You finally arrived at the spot and got off your jeep. It was all so familiar, the trees, the rocks,
just like in your dream. There stood the gaping mouth of the gold temple, its dark mouth
opened wide. Vines covered the rest of the walls, leaving shiny flecks of gold showing between
the wood. It was just like your dream. You took a deep breath and walked towards the temple,
thinking about why you signed up for this. But you remember the low pay from your job as a
{0}, the Chicago Outfit’s threats, the mountain of debt and continued into the dark
esophagus of the ruins.", player.occupation));
         }
      }


      private void initItems()
      {
         using (StreamReader r = new StreamReader("items.json"))
         {
            string json = r.ReadToEnd();
            Dictionary<string, dynamic> jsonItems = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            foreach (var jsonItem in jsonItems)
            {
               var itemValue = jsonItem.Value;
               string itemClass = itemValue.type;
               switch (itemClass)
               {
                  case "Weapon":
                     Weapon weapon = new Weapon(itemValue.name.ToString(), Int32.Parse(itemValue.cost.ToString()), itemValue.benefit.category.ToString(), Int32.Parse(itemValue.benefit.value.ToString()));
                     items.Add(weapon);
                     break;
                  case "Armor":
                     Armor armor = new Armor(itemValue.name.ToString(), Int32.Parse(itemValue.cost.ToString()), itemValue.benefit.category.ToString(), Int32.Parse(itemValue.benefit.value.ToString()));
                     items.Add(armor);
                     break;
                  case "Consumable":
                     //Console.WriteLine(Int32.Parse(itemValue.cost.ToString()).GetType());
                     Consumable consumable = new Consumable(itemValue.name.ToString(), Int32.Parse(itemValue.cost.ToString()), itemValue.benefit.category.ToString(), Int32.Parse(itemValue.benefit.value.ToString()));
                     items.Add(consumable);
                     break;
                  default:
                     Console.WriteLine("Item initialization error");
                     break;
               }
            }
         }
      }

      private void showItems()
      {
         foreach (var item in items)
         {
            int index = 1;
            typewriterStyleOutput(string.Format(@"

            {4}. {0} 
               Cost {1} pesos
               Increase {2} by {3} 

                              ", item.name, item.cost, item.benefitCategory, item.benefitValue, index));
            index++;

         }
      }

      private void purchaseItems()
      {


      }

      private void initTempleMap()
      {
         String[] dirs = { "n ", "e ", "s ", " w " };
         using (StreamReader r = new StreamReader("map.json "))
         {
            string json = r.ReadToEnd();
            Dictionary<string, dynamic> d = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            foreach (var key in d.Keys)
            {
               templeMap[Int32.Parse(key)] = new Room();
            }
            foreach (var key in d.Keys)
            {
               foreach (String dir in dirs)
               {
                  if (d[key].ContainsKey(dir))
                  {
                     typeof(Room).GetProperty(dir).SetValue(templeMap[Int32.Parse(key)], templeMap[Int32.Parse(d[key][dir])]);
                  }
               }
            }
         }
      }

      private string waitForInput(string[] possibleAnswers, string errorMessage = "You walked into the wall, maybe you shouldn't do that.\n")
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
         foreach (KeyValuePair<string, int> possibleMove in possibleMoves)
         {
            typewriterStyleOutput(string.Format(@"

{0}. {1}
", i, possibleMove.Key));
            intIndexToStringIndex[i] = possibleMove.Key;
            i += 1;
         }
         int moveIndex = waitForInt();
         if (intIndexToStringIndex[moveIndex].Equals("Retreat"))
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
         else if (intIndexToStringIndex[moveIndex].Equals("Punch"))
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
   }
}





