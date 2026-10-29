//using System;
//using System.Collections.Generic;

//class program
//{
//    static void Main()
//    {
//        Dictionary<string, int> prices = new Dictionary<string, int>
//        {
//            { "Mikstura", 15 },
//            { "Pochodnia", 5 },
//            { "Miecz", 40 }
//        };

//        Console.WriteLine(prices.Count);

//        foreach (KeyValuePair<string, int> para in prices)
//        {
//            Console.WriteLine(para.Key + " " + para.Value);
//        }

//        Console.Write("Choose an item: ");
//        string input = Console.ReadLine();

//        if (prices.ContainsKey(input))
//        {
//            Console.WriteLine(prices[input]);
//        }
//        else
//        {
//            Console.WriteLine("Nie ma takiego przedmiotu");
//        }

//        prices["Mikstura"] = 12;

//        foreach (KeyValuePair<string, int> para in prices)
//        {
//            Console.WriteLine(para.Key + " " + para.Value);
//        }
//    }
//}