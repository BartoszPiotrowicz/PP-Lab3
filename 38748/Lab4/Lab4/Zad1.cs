//using System;

//class program
//{
//    static void Main()
//    {
//        int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
//        int total_gold = 0;
//        double average = 0;
//        int ten_gold_turns = 0;
//        int turn = 0;

//        foreach (int i in zlotoWTurach)
//        {
//            turn++;
//            Console.WriteLine("Tura " + turn + ": " + i);

//            if (i >= 10)
//                {
//                    ten_gold_turns++;
//                }

//            total_gold += i;
//        }

//        average = (double)total_gold / zlotoWTurach.Length;

//        Console.WriteLine("Total gold: " + total_gold);
//        Console.WriteLine("Average: " + average);
//        Console.WriteLine("10 gold turns: " + ten_gold_turns);

//        for (int i = zlotoWTurach.Length - 1; i > -1; i--)
//        {
//            Console.WriteLine("Tura " + i + ": " + zlotoWTurach[i]);
//        }
//    }
//}