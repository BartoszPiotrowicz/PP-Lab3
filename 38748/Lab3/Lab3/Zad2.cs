//using System;

//class program
//{
//    static void Main()
//    {
//        Console.Write("Day count: ");
//        int day_count = int.Parse(Console.ReadLine());

//        bool flag = false;

//        if (day_count < 1 || day_count > 7)
//        {
//            Console.WriteLine("Days given not in range");
//            day_count = 0;
//        }

//        int gold_found = 0;
//        int gold_count = 0;
//        int good_days = 0;

//        for (int i = 1; i <= day_count; i++)
//        {
//            Console.Write("Gold found: ");
//            gold_found = int.Parse(Console.ReadLine());
//            gold_count += gold_found;

//            if (gold_found > 10)
//            {
//                good_days++;
//            }

//            Console.WriteLine("Day " + i + " gold found: " + gold_found);
//        }

//        Console.WriteLine("\nTotal gold found: " + gold_count);
//        Console.WriteLine("Days with more than 10 gold found: " + good_days);
//    }
//}