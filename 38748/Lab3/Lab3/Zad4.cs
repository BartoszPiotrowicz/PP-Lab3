//using System;

//class program
//{
//    static void Main()
//    {
//        string input = "";

//        while (true)
//        {
//            input = Console.ReadLine();

//            bool flag = int.TryParse(input, out int turn_count);

//            if (!flag)
//            {
//                Console.WriteLine("This is not an int");
//                continue;
//            }
//            else if (turn_count < 1)
//            {
//                Console.WriteLine("Give a number greater than 0");
//                continue;
//            }
//            else if (turn_count > 10)
//            {
//                Console.WriteLine("Give a number smaller than 11");
//                continue;
//            }

//            Console.WriteLine("Good job :thumbsup:");

//            for (int i = 0; i < turn_count; i++)
//            {
//                Console.WriteLine($"Turn {i + 1}");
//            }

//            break;
//        }
//    }
//}