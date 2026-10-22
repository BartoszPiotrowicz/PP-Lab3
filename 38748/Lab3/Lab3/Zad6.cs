using System;

class program
{
    static void Main()
    {
        // Get parameters
        //Console.WriteLine("Your name: ");
        //string name = Console.ReadLine();

        // Testing variables
        string name = "Jerzy";
        int max_hp = 100;
        int current_hp = 20;
        int gold = 0;
        int potion_count = 0;
        int turn = 1;
        bool flag = true;

        // Get HP
        while (true)
        {
            string input = Console.ReadLine();
            bool input_flag = int.TryParse(input, out int turn_count);

            if (input_flag)
            {
                current_hp = int.Parse(input);
                break;
            }
        }

        //// Write out Hero card
        //Console.ForegroundColor = ConsoleColor.Blue;
        //Console.WriteLine("=====HERO CARD=====");
        //Console.ResetColor();
        //Console.WriteLine("Hero: " + name);
        //Console.WriteLine("Health: " + current_hp + "/" + max_hp);
        //Console.WriteLine("Level: " + level);
        //Console.WriteLine("Strength: " + strength);
        //Console.WriteLine("Potion count: " + potion_count);
        //Console.WriteLine("Has map: " + has_map);
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("------STATUS------");
        //Console.ResetColor();
        //Console.Write("Has low health: ");
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine(is_low_health);
        //Console.ResetColor();
        //Console.Write("Is alive: ");
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine(is_alive);
        //Console.ResetColor();
        //Console.Write("Is prepared: ");
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine(is_prepared);
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("------ACTION------");
        //Console.ResetColor();

        ////Action logic
        //if (is_alive)
        //{
        //    switch (action)
        //    {
        //        case "1":
        //            Console.WriteLine("Your damage is: " + strength);
        //            break;
        //        case "2":
        //            if (potion_count > 0)
        //            {
        //                Console.WriteLine("Healed to full");
        //                current_hp = max_hp;
        //                potion_count--;
        //            }
        //            else
        //            {
        //                Console.WriteLine("You have no potions");
        //            }
        //            break;
        //        case "3":
        //            if (is_prepared)
        //            {
        //                Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //                Console.WriteLine("You travel to The Dungeon");
        //                Console.ResetColor();
        //            }
        //            else
        //            {
        //                Console.ForegroundColor = ConsoleColor.DarkRed;
        //                Console.WriteLine("You're not prepared for The Dungeon");
        //                Console.ResetColor();
        //            }
        //            break;
        //        case "4":
        //            Console.WriteLine("You sewerslided");
        //            current_hp = 0;
        //            break;
        //        default:
        //            Console.WriteLine("Inncorect action");
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.ForegroundColor = ConsoleColor.DarkRed;
        //    Console.WriteLine("Cannot perform action. You're dead!");
        //    Console.ResetColor();
        //}
    }
}