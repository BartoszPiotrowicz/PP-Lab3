//using System;
//using System.Collections.Generic;

//class program
//{
//    static void Main()
//    {
//        List<string> plecak = new List<string>
//        {
//            "Miecz",
//            "Mikstura",
//            "Pochodnia"
//        };

//        for (int i = 0; i < plecak.Count; i++)
//        {
//            Console.WriteLine(plecak[i]);
//        }

//        Console.WriteLine();

//        for (int i = 0; i < plecak.Count; i++)
//        {
//            Console.WriteLine(i+1 + ". " + plecak[i]);
//        }

//        string input = Console.ReadLine();

//        plecak.Add(input);

//        if (plecak.Contains("Mikstura"))
//        {
//            Console.WriteLine("Has potion");
//        }

//        Console.Write("Removed potion: ");
//        Console.WriteLine(plecak.Remove("Mikstura"));

//        Console.WriteLine("\nBackpack: ");

//        for (int i = 0; i < plecak.Count; i++)
//        {
//            Console.WriteLine(plecak[i]);
//        }
//    }
//}