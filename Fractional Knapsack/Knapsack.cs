namespace Fractional_Knapsack
{
    public class Knapsack
    {
            public double MaxCapacity { get; set; }
            public double CurrentCapacity { get; set; }
            public double TotalValue { get; set; }
            public List<Item> Items { get; set; }

            // Initialize the knapsack parameters
            public Knapsack(double maxCapacity)
            {
                MaxCapacity = maxCapacity;
                CurrentCapacity = 0;
                TotalValue = 0;
                Items = new List<Item>();
            }

            // Add an item or a calculated fraction to the knapsack
            public void AddItem(Item newItem)
            {
                double availableSpace = MaxCapacity - CurrentCapacity;

                // If the item is too heavy, adjust its weight and value proportionally
                if (newItem.Weight > availableSpace)
                {
                    double diff = availableSpace;
                    newItem.Weight = diff;
                    newItem.Value = diff * newItem.Ratio;
                }

                // Add the item to the knapsack collection and update running totals
                Items.Add(newItem);
                CurrentCapacity += newItem.Weight;
                TotalValue += newItem.Value;
            }
        }
}
