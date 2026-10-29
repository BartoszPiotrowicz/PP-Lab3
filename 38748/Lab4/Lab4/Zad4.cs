//using System;
//using System.Collections.Generic;

//class program
//{
//    static void Main()
//    {
//        int turn_count = 0;

//        while (true)
//        {
//            Console.Write("Give turns (1-10): ");
//            string input = Console.ReadLine();

//            if (int.TryParse(input, out turn_count))
//            {
//                turn_count = int.Parse(input);
//            }

//            if (turn_count >= 1 && turn_count <= 10)
//            {
//                break;
//            }
//        }

//        int[] turns = new int[turn_count];

//        int count = 0;

//        int sum = 0;
//        int min = 0;
//        int max = 0;

//        int first_max_turn = 0;
//        int max_turn_count = 0;
//        int first_zero_turn = 0;

//        while (count < turn_count)
//        {
//            Console.Write("Give a gold amount: ");
//            string input = Console.ReadLine();

//            if (int.TryParse(input, out turns[count]))
//            {
//                turns[count] = int.Parse(input);
//                if (turns[count] >= 0)
//                {
//                    if (count == 0)
//                    {
//                        min = turns[count];
//                    }

//                    sum += turns[count];

//                    if (turns[count] > max)
//                    {
//                        max = turns[count];
//                    }

//                    if (turns[count] < min)
//                    {
//                        min = turns[count];
//                    }

//                    count++;
//                }
//            }
//        }

//        Console.WriteLine("Sum: " + sum);
//        Console.WriteLine("Max: " + max);
//        Console.WriteLine("Min: " + min);

//        bool maxFlag = true;
//        bool zeroFlag = true;

//        for (int i = 0; i < turns.Length; i++)
//        {
//            if (turns[i] == max && maxFlag)
//            {
//                first_max_turn = i + 1;
//                maxFlag = false;
//            }

//            if (turns[i] == max)
//            {
//                max_turn_count++;
//            }

//            if (turns[i] == 0 && zeroFlag)
//            {
//                first_zero_turn = i + 1;
//                zeroFlag = false;
//            }
//        }

//        Console.WriteLine("First turn with max number: " + first_max_turn);
//        Console.WriteLine("Turns with max count: " + max_turn_count);

//        if (!zeroFlag)
//            Console.WriteLine("First turn with zero: " + first_zero_turn);
//        else
//            Console.WriteLine("There's no zero");

//    }
//}