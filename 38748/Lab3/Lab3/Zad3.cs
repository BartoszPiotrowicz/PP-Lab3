//using System;

//class program
//{
//    static void Main()
//    {
//        int height = int.Parse(Console.ReadLine());

//        if (height > 1)
//        {
//            for (int i = 0; i < height; i++)
//            {
//                for (int j = 0; j < height * 2 - 1; j++)
//                {
//                    if (j > height + i + - 1)
//                    {
//                        Console.Write(" ");
//                    }
//                    else if (j < height - i - 1)
//                    {
//                        Console.Write(" ");
//                    }
//                    else
//                    {
//                        Console.Write("*");
//                    }
//                }

//                Console.WriteLine();
//            }

//            for (int i = 0; i < height - 1; i++)
//            {
//                Console.Write(" ");
//            }

//            Console.Write("*");
//        }
//        else
//        {
//            Console.WriteLine("Podano nie poprawną wysokość");
//        }
//    }
//}