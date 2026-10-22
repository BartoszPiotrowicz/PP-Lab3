//using System;

//class program
//{
//    static void Main()
//    {
//        int max_hero_hp = 1;
//        int hero_hp = max_hero_hp;
//        int max_enemy_hp = 45;
//        int enemy_hp = max_enemy_hp;
//        int potion_count = 2;
//        int turn_number = 1;
//        string action = "";
//        bool flag = true;

//        while (flag)
//        {
//            Console.WriteLine("Turn " + turn_number);
//            Console.WriteLine("Hero HP: " + hero_hp + "/" + max_hero_hp);
//            Console.WriteLine("Enemy HP: " + enemy_hp + "/" + max_enemy_hp);

//            Console.WriteLine("Actions:");
//            Console.WriteLine("1. Attack");
//            Console.WriteLine("2. Potion");
//            Console.WriteLine("3. Flee\n");

//            Console.Write("Choose an action: ");
//            action = Console.ReadLine();

//            switch (action)
//            {
//                case "1":
//                    enemy_hp -= 12;
//                    if (enemy_hp < 0)
//                    {
//                        flag = false;
//                        Console.WriteLine("You win!");
//                    }
//                    else
//                    {
//                        hero_hp -= 7;
//                    }
//                    if (hero_hp < 0)
//                    {
//                        flag = false;
//                        Console.WriteLine("You failed!");
//                    }
//                    break;
//                case "2":
//                    if (potion_count > 0)
//                    {
//                        hero_hp += 15;
//                        potion_count--;
//                    }
//                    else
//                    {
//                        Console.WriteLine("No potions remaining");
//                    }
//                    break;
//                case "3":
//                    flag = false;
//                    Console.WriteLine("You ran away!");
//                    break;
//                default:
//                    Console.WriteLine("Inncorect action");
//                    break;
//            }

//            turn_number++;
//        }
//    }
//}