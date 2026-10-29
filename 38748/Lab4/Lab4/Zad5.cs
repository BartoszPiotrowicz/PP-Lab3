//using System;
//using System.Collections.Generic;

//class program
//{
//    static void Main()
//    {
//        List<string> items = new List<string>
//            {
//                "Miecz",
//                "Tarcza",
//                "Mikstura",
//                "Klucz"
//            };

//        do
//        {
//            for (int i = 0; i < items.Count; i++)
//            {
//                Console.WriteLine("Item " + (i + 1) + ": " + items[i]);
//            }

//            Console.Write("Give an item to remove: ");
//            string input = Console.ReadLine();
//            int index = 0;

//            if (int.TryParse(input, out index))
//            {
//                if (index >= 1 && index <= items.Count)
//                {
//                    string item = items[index - 1];
//                    items.RemoveAt(index - 1);
//                    Console.WriteLine("Removed: " + item);
//                }
//                else if (index < 1)
//                {
//                    Console.WriteLine("Give a positive number");
//                }
//                else
//                    Console.WriteLine("Give a number <= " + items.Count);
//            }
//            else
//                Console.WriteLine("Give an int");
//        }
//        while (items.Count > 0);

//        Console.WriteLine("Removed every item");

//    }
//}