using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        bool flag = true;
        string input = "";
        int count = 0;

        Dictionary<string, int> warehouse = new Dictionary<string, int>
        {
            { "Potion", 3 },
            { "Torch", 2 },
            { "Key", 1 }
        };

        while (true)
        {
            Console.WriteLine("1. Add to warehouse\n2. Take from warehouse\n3. Exit");
            Console.Write("Choose an action: ");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    foreach (KeyValuePair<string, int> pair in warehouse)
                    {
                        Console.WriteLine(pair.Key + ": " + pair.Value);
                    }

                    Console.Write("Choose which item: ");
                    input = Console.ReadLine();

                    Console.Write("Choose amount: ");
                    count = int.Parse(Console.ReadLine());

                    if (warehouse.ContainsKey(input))
                    {
                        warehouse[input] += count;
                    }
                    else
                    {
                        warehouse.Add(input, count);
                    }

                    break;
                case "2":
                    foreach (KeyValuePair<string, int> pair in warehouse)
                    {
                        Console.WriteLine(pair.Key + ": " + pair.Value);
                    }

                    Console.Write("Choose which item: ");
                    input = Console.ReadLine();

                    Console.Write("Choose amount: ");
                    count = int.Parse(Console.ReadLine());

                    if (warehouse.ContainsKey(input))
                    {
                        warehouse[input] -= count;
                    }
                    else
                    {
                        Console.WriteLine("This item doesn't exist");
                    }

                    if (warehouse[input] <= 0)
                    {
                        warehouse.Remove(input);
                    }

                    break;
                case "3":
                    flag = false;
                    break;
                default:
                    break;
            }

            if (flag)
            {
                foreach (KeyValuePair<string, int> pair in warehouse)
                {
                    Console.WriteLine(pair.Key + ": " + pair.Value);
                }
            }
            else
                break;
        }

    }
}