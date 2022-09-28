using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {

        bool dead = false;
        string Explore = "Explore?";
        string Inspect = "Inspect?";
        string Inspect1 = "Inspect?";
        string Approach = "Approach?";
        string Left = "Left,";
        string Left1 = "Left,";
        string Right = "Right,";
        string Middle = "or Middle?";
        string Left2 = "Left,";
        string Right1 = "or Right?";
        string Shoot = "Do You?";
        string Right2 = "or Right?";

        void death()
        {
            if (dead == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(2000);
                Console.WriteLine("You died a gruesome and painful death on Mars");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine($"You have landed on the Vacent Planet Mars. {Explore}");
        string answer = Console.ReadLine();

               
        if (answer == "Yes" | answer == "yes")

        {

            Console.WriteLine("You chose to explore.");
            Thread.Sleep(2000);
            Console.WriteLine($"After walking for several minutes, you come across a item. {Inspect}");
           answer = Console.ReadLine();
            if (answer == "Yes" | answer == "yes")

            {
                Console.WriteLine("You chose to inspect the item. It is a piece of Mars Rock. You placed it in your bag and continue to explore.");
                Thread.Sleep(2000);
                death();
            }

            else if (answer == "no" ^ answer == "No") 
            {
                    Console.WriteLine("You leave the item and walk away as the sand covers the item leaving you unable to find it again.");
                Thread.Sleep(2000);
                death();
            }

            {
                death();
                Console.WriteLine($"You notice up a hill a vast cave.");
                Thread.Sleep(2000);
            }
            

            
            {
                death();
                Console.WriteLine($"You come across another Item. {Inspect1}");
            }
            answer = Console.ReadLine();
            if (answer == "yes" | answer == "Yes")
               
            {
                death();
                Console.WriteLine("You chose to inspect the item. it is a sheet of metal, presumably from your spacecraft.");
                Thread.Sleep(2000);
                Console.WriteLine("You leave the sheet as it is too large for your bag.");
                Thread.Sleep(2000);
                Console.WriteLine("After exploring for sometime you decide to explore the cave.");
                Thread.Sleep(2000);
            }
            
            else if (answer == "no" ^ answer == "No")
            {
                death();
                Console.WriteLine("You leave the sheet in the sand.");
                Thread.Sleep(2000);
                Console.WriteLine("After exploring for sometime you decide to explore the cave.");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine(@"
 ********************************************************************************
*                    /   \              /'\       _                              *
*\_..           /'.,/     \_         .,'   \     / \_                            *
*    \         /            \      _/       \_  /    \     _                     *
*     \__,.   /              \    /           \/.,   _|  _/ \                    *
*          \_/                \  /',.,''\      \_ \_/  \/    \                   *
*                           _  \/   /    ',../',.\    _/      \                  *
*             /           _/m\  \  /    |         \  /.,/'\   _\                 *
*           _/           /MMmm\  \_     |          \/      \_/  \                *
*          /      \     |MMMMmm|   \__   \          \_       \   \_              *
*                  \   /MMMMMMm|      \   \           \       \    \             *
*                   \  |MMMMMMmm\      \___            \_      \_   \            *
*                    \|MMMMMMMMmm|____.'  /\_            \       \   \_          *
*                    /'.,___________...,,'   \            \   \        \         *
*                   /       \          |      \    |__     \   \_       \        *
*                 _/        |           \      \_     \     \    \       \_      *
*                /                               \     \     \_   \        \     *
*                                                 \     \      \   \__      \    *
*                                                  \     \_     \     \      \   *
*                                                   |      \     \     \      \  *
*                                                    \ms          |            \ *
 ********************************************************************************");
            {
                death();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(2000);
                Console.WriteLine("As you enter the cave a strong rotting smell comes from within.");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.WriteLine("After Walking throughout the passage ways you start to notice blood and bones on the floor.");
                Thread.Sleep(2000);
                Console.WriteLine("A sound of crunching and squelching grows as you reach a larger room of the cave.");
                Thread.Sleep(2000);
                Console.WriteLine("As you enter the large room before you is the cause of the noise.");
                Thread.Sleep(1000);
                Console.WriteLine("A large");
                Thread.Sleep(1000);
                Console.WriteLine("Slimey");
                Thread.Sleep(1000);
                Console.WriteLine("Black and Green Creature");
                Thread.Sleep(2000);
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(@"                                  
   ___                                      .-~. /_""-._
  `-._~-.                                  / /_ ""~o\  :Y
      \  \                                / : \~x.  ` ')
       ]  Y                              /  |  Y< ~-.__j
      /   !                        _.--~T : l  l<  /.-~
     /   /                 ____.--~ .   ` l /~\ \<|Y
    /   /             .-~~""        /| .    ',-~\ \L|
   /   /             /     .^   \ Y~Y \.^>/l_   ""--'
  /   Y           .-""(  .  l__  j_j l_/ /~_.-~    .
 Y    l          /    \  )    ~~~."" / `/""~ / \.__/l_
 |     \     _.-""      ~-{__     l  :  l._Z~-.___.--~
 |      ~---~           /   ~~""---\_  ' __[>
 l  .                _.^   ___     _>-y~
  \  \     .      .-~   .-~   ~>--""  /
   \  ~---""            /     ./  _.-'
    ""-.,_____.,_  _.--~\     _.-~
                ~~     (   _}
                        `. ~(
                          )  \
                         /,`--'~\--'");
                    Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Approach}");
            }
            answer= Console.ReadLine();
            if (answer == "yes" | answer == "Yes")
            {
                death();
                Console.WriteLine("As you take a step towards the Beast it notices you and has decided you are its next meal.");
                Thread.Sleep(2000);
            }

            else if (answer == "no" ^ answer == "No")
            {
                death();
                Console.WriteLine("As you slowly back away from the Beast it notices you and has decided you are its next meal");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.WriteLine("To keep yourself alive you run away from the Monster as it chases you throughout the passage ways.");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Due to the Monsters large size its footsteps shake the cave causing the route you took to collapsed forcing you to find a new route.");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.WriteLine($"You come across a decision to either go left or right. Go {Left} {Right2}");
            }
            answer = Console.ReadLine();
            if (answer == "Left" | answer == "left")
            {
                death();
                Console.WriteLine("You have ran into a dead end and the monster blocks your path");
                Thread.Sleep(2000);
                Console.WriteLine("The monster has taken you as its next victim and has eaten your upper body.");
                dead = true;
                death();
            }

            else if (answer == "Right" ^ answer == "right")
            {
                death();
                Console.WriteLine("You carry on running from the Monster.");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.WriteLine("You come across a choice of three different routes this time.");
                Thread.Sleep(2000);
                Console.WriteLine($"Go {Left1} {Right} {Middle}");
            }
            answer = Console.ReadLine();
            if (answer == "Left" | answer == "left")
            {
                death();
                Console.WriteLine("You have ran into a dead end and monster blocks your path.");
                Thread.Sleep(2000);
                Console.WriteLine("The Monster has taken you as its next victim and has eaten your upper body.");
                dead = true;
                death();
            }
            else if (answer == "Right" ^ answer == "right")
            {
                death();
                Console.WriteLine("You have ran into a dead end and monster blocks your path.");
                Thread.Sleep(2000);
                Console.WriteLine("The Monster has taken you as its next victim and has eaten your upper body.");
                dead = true;
                death();
            }
            else if (answer == "Middle" ^ answer == "middle" )
            {
                death();
                Console.WriteLine("You carry on running from the monster.");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.WriteLine("You come across yet another choice.");
                Thread.Sleep(2000);
                Console.WriteLine($"{Left2} {Right1}");
            }
            answer = Console.ReadLine();
            if (answer == "Left" | answer == "left")
            {
                death();
                Console.WriteLine("You have ran into a dead end and monster blocks your path.");
                Thread.Sleep(2000);
                Console.WriteLine("The Monster has taken you as its next victim and has eaten your upper body.");
                dead = true;
                death();
            }

            else if (answer == "Right" ^ answer == "right")
            {
                death();
                Console.WriteLine("You carry on running from the Monster.");
                Thread.Sleep(2000);
            }
            {
                death();
                Console.WriteLine("You see a light at the end of the tunnel but the monster is catching you.");
                Thread.Sleep(2000);
                Console.WriteLine($"You have the chance to shoot the cave entrance down stopping the Monster. {Shoot}");
            }
            answer = Console.ReadLine();
            if (answer == "Yes" | answer == "yes")
            {
                death();
                Console.WriteLine("");
             Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The roof of the cave falls before the monster stopping it from getting to you.");
            Thread.Sleep(2000);
                Console.WriteLine("You lay on the floor, tired, to regain your breath and energy before making your way back to your Shuttle.");
            Thread.Sleep(2000);
            Console.WriteLine("You take off in your Shuttle and start your voyage back to earth with your findings and a near death experience with it.");
                Thread.Sleep(2000);
                Console.WriteLine("Thank you for playing the Mars Expedition.");
            }

            else if (answer == "no" ^ answer == "No")
            {
                death();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The floor caves in on the Monster due to its Gigantic mass leaving it helpless and unable to reach you.");
                Thread.Sleep(2000);
                Console.WriteLine("You lay on the floor, tired, to regain your breath and energy before making your way back to your Shuttle.");
                Thread.Sleep(2000);
                Console.WriteLine("You take off in your Shuttle and start your voyage back to earth with your findings and a near death experience with it.");
                Thread.Sleep(2000);
                Console.WriteLine("Thank you for playing the Mars Expedition.");
            }
        }


        else if (answer == "no" ^ answer == "No")
        {
            dead = true;
            death();
        }
        
        

    }
      
}

