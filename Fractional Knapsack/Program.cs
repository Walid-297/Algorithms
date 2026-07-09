using System;
using System.Collections.Generic;
using Fractional_Knapsack;

class Program
{
    public static void Main(string[] args)
    {
        // 1. Initialize a new knapsack instance with weight limit configuration
        Knapsack myKnapsack = new Knapsack(50);

        // 2. Prepare raw item input records
        List<Item> storeInventory = new List<Item>
        {
            new Item(60, 10, "Item A"),
            new Item(100, 20, "Item B"),
            new Item(120, 30, "Item C")
        };

        // 3. Sort your item lists in descending order based on value density ratio
        storeInventory.Sort((x, y) => y.Ratio.CompareTo(x.Ratio));

        // 4. Sequentially process item sets through the placement manager
        foreach (Item item in storeInventory)
        {
            if (myKnapsack.CurrentCapacity >= myKnapsack.MaxCapacity)
                break;

            myKnapsack.AddItem(item);
        }

        // 5. Display run results
        Console.WriteLine("Knapsack Processing Complete.");
        Console.WriteLine($"Total Knapsack Value Secured: {myKnapsack.TotalValue}");
        Console.WriteLine($"Total Bag Capacity Occupied: {myKnapsack.CurrentCapacity} / {myKnapsack.MaxCapacity}");
    }
}